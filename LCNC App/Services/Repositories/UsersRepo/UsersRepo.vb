Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class UsersRepo
    Implements IUsersRepo

    Private ReadOnly connString As String
    Private ReadOnly dbName = "lcncApp"
    Private ReadOnly colName = "users"

    Public Sub New(connString As String)
        Me.connString = connString
    End Sub

    Public Async Function Insert(user As UserModel) As Task Implements IUsersRepo.Insert
        user.DateTime = BsonDateTime.Create(DateTime.UtcNow)

        Dim client As New MongoClient(New MongoUrl(Me.connString))

        Dim database As IMongoDatabase = client.GetDatabase(Me.dbName)
        Dim collection As IMongoCollection(Of UserModel) = database.GetCollection(Of UserModel)(Me.colName)

        Await collection.InsertOneAsync(user)
    End Function

    Public Async Function GetOne(username As String, password As String) As Task(Of UserModel) Implements IUsersRepo.GetOne
        Dim client As New MongoClient(New MongoUrl(connString))

        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Dim collection As IMongoCollection(Of UserModel) = database.GetCollection(Of UserModel)(colName)

        Dim filter As FilterDefinition(Of UserModel) = Builders(Of UserModel).Filter.And(
            Builders(Of UserModel).Filter.Eq(Function(model) model.Username, username),
            Builders(Of UserModel).Filter.Gte(Function(model) model.Password, password)
        )
        Dim results = Await (Await collection.FindAsync(filter)).ToListAsync()

        Return If(results.Count <= 0, Nothing, results(0))
    End Function

    Public Async Function GetAll(username As String) As Task(Of IEnumerable(Of SubmittedDataModel)) Implements IUsersRepo.GetAll
        Dim client As New MongoClient(New MongoUrl(connString))

        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Dim collection As IMongoCollection(Of UserModel) = database.GetCollection(Of UserModel)(colName)

        Dim filter As FilterDefinition(Of UserModel) = Builders(Of UserModel).Filter.And(
            Builders(Of UserModel).Filter.Eq(Function(model) model.Username, username)
        )
        Dim results = Await collection.FindAsync(filter)

        Return Await results.ToListAsync()
    End Function
End Class
