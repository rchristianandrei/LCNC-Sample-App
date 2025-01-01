Imports MongoDB.Bson

Public Interface IFormsRepo
    Function Save(form As FormModel) As Task

    Function LoadAll() As Task(Of IEnumerable(Of FormModel))

    Function LoadOne(id As ObjectId) As Task(Of FormModel)

    Function Delete(id As ObjectId) As Task
End Interface
