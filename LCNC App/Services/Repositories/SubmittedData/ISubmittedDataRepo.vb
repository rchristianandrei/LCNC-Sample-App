Imports MongoDB.Bson

Public Interface ISubmittedDataRepo
    Function Insert(data As SubmittedDataModel) As Task

    Function GetData(formId As ObjectId, fromDate As Date, toDate As Date) As Task(Of IEnumerable(Of SubmittedDataModel))
End Interface
