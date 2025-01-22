Public Interface IReportAHTRepo

    Function Calculate(form As FormModel) As Task(Of String)

End Interface
