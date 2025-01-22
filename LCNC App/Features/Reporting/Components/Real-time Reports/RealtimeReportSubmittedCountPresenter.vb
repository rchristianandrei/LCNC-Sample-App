Public Class RealtimeReportSubmittedCountPresenter
    Implements IRealtimeReportKpi

    Private ReadOnly _view As New RealtimeReportTemplateView With {.Caption = "Submitted (Count)"}

    Private ReadOnly calculator As IReportSubmittedCountRepo

    Public Sub New(calculator As IReportSubmittedCountRepo)
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
