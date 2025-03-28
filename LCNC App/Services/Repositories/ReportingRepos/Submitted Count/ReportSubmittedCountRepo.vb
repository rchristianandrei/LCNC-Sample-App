﻿Imports MongoDB.Driver

Public Class ReportSubmittedCountRepo
    Implements IReportSubmittedCountRepo

    Private ReadOnly connString As String
    Private ReadOnly dbName = "lcncApp"
    Private ReadOnly colName = "submittedData"

    Public Sub New(connString As String)
        Me.connString = connString
    End Sub

    Public Async Function Calculate(form As FormModel) As Task(Of String) Implements IReportSubmittedCountRepo.Calculate
        Dim client As New MongoClient(New MongoUrl(Me.connString))

        Dim database As IMongoDatabase = client.GetDatabase(Me.dbName)
        Dim collection As IMongoCollection(Of SubmittedDataModel) = database.GetCollection(Of SubmittedDataModel)(Me.colName)

        Dim filter As FilterDefinition(Of SubmittedDataModel) = Builders(Of SubmittedDataModel).Filter.And(
            Builders(Of SubmittedDataModel).Filter.Eq(Function(model) model.FormId, form.Id)
        )
        Dim submittedList = Await (Await collection.FindAsync(filter)).ToListAsync()

        Return submittedList.Count.ToString()
    End Function
End Class
