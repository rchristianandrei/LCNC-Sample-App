Imports Guna.UI2.WinForms

Public Class ExportRawReportView

#Region "Properties"
    Public Property FromDate() As Date
        Get
            Return Me.dtpForm.Value
        End Get
        Set(ByVal value As Date)
            Me.dtpForm.Value = value
        End Set
    End Property

    Public Property ToDate() As Date
        Get
            Return Me.dtpTo.Value
        End Get
        Set(ByVal value As Date)
            Me.dtpTo.Value = value
        End Set
    End Property

    Public ReadOnly Property ColIdlIndex() As Integer
        Get
            Return Me.colId.Index
        End Get
    End Property

    Public ReadOnly Property ColFormIDIndex() As Integer
        Get
            Return Me.colFormID.Index
        End Get
    End Property

    Public ReadOnly Property ColFormNameIndex() As Integer
        Get
            Return Me.colFormName.Index
        End Get
    End Property

    Public ReadOnly Property ColDateTimeIndex() As Integer
        Get
            Return Me.colDateTimeSubmitted.Index
        End Get
    End Property

    Public ReadOnly Property DataGrid() As Guna2DataGridView
        Get
            Return Me.grdData
        End Get
    End Property
#End Region

#Region "Events"
    Public Event LoadData()

    Public Event ExportData()
#End Region

#Region "Event Handlers"
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        RaiseEvent LoadData()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        RaiseEvent ExportData()
    End Sub
#End Region
End Class