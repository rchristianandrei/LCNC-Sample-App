Public Class RealtimeReportAHTPresenter
    Implements IRealtimeReportKpi

    Private ReadOnly _view As New RealtimeReportTemplateView With {.Caption = "Average Handling Time", .Value = "00:00:00"}

    Private ReadOnly calculator As IReportAHTRepo

    Public Sub New(calculator As IReportAHTRepo)
        Me.calculator = calculator
    End Sub

#Region "Properties"
    Public ReadOnly Property View As UserControl Implements IRealtimeReportKpi.View
        Get
            Return _view
        End Get
    End Property
#End Region

#Region "Public Methods"
    Public Async Function Calculate(form As FormModel) As Task Implements IRealtimeReportKpi.Calculate
        Dim result = Await Me.calculator.Calculate(form)

        Me._view.Value = result
    End Function
#End Region
End Class
