Public Interface IRealtimeReportKpi


    ReadOnly Property View As UserControl

    Function Calculate(form As FormModel) As Task

End Interface
