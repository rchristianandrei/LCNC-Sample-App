Public Class RealtimeReportTemplateView

#Region "Properties"
    Public Property Caption() As String
        Get
            Return lblCaption.Text
        End Get
        Set(ByVal value As String)
            lblCaption.Text = value
        End Set
    End Property

    Public Property Value() As String
        Get
            Return lblValue.Text
        End Get
        Set(ByVal value As String)
            lblValue.Text = value
        End Set
    End Property
#End Region

End Class
