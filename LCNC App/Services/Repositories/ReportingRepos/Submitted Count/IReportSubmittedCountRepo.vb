Public Interface IReportSubmittedCountRepo

    Function Calculate(form As FormModel) As Task(Of String)

End Interface
