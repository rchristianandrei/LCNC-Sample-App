Public Interface IReportResponseTimeRepo

    Function Calculate(form As FormModel) As Task(Of String)

End Interface
