<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportingView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        mnsOptions = New MenuStrip()
        smiChooseForm = New ToolStripMenuItem()
        smiExportRawReport = New ToolStripMenuItem()
        sepTop = New Guna.UI2.WinForms.Guna2Separator()
        lblFormName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlKpis = New FlowLayoutPanel()
        prgLoading = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Timer1 = New Timer(components)
        btnRefreshNow = New Guna.UI2.WinForms.Guna2Button()
        mnsOptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnsOptions
        ' 
        mnsOptions.Items.AddRange(New ToolStripItem() {smiChooseForm, smiExportRawReport})
        mnsOptions.Location = New Point(0, 0)
        mnsOptions.Name = "mnsOptions"
        mnsOptions.Size = New Size(510, 24)
        mnsOptions.TabIndex = 3
        mnsOptions.Text = "MenuStrip1"
        ' 
        ' smiChooseForm
        ' 
        smiChooseForm.Name = "smiChooseForm"
        smiChooseForm.Size = New Size(90, 20)
        smiChooseForm.Text = "Choose Form"
        ' 
        ' smiExportRawReport
        ' 
        smiExportRawReport.Name = "smiExportRawReport"
        smiExportRawReport.Size = New Size(115, 20)
        smiExportRawReport.Text = "Export Raw Report"
        ' 
        ' sepTop
        ' 
        sepTop.Dock = DockStyle.Top
        sepTop.FillColor = SystemColors.ControlText
        sepTop.Location = New Point(0, 24)
        sepTop.Name = "sepTop"
        sepTop.Size = New Size(510, 1)
        sepTop.TabIndex = 7
        ' 
        ' lblFormName
        ' 
        lblFormName.BackColor = Color.Transparent
        lblFormName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFormName.Location = New Point(3, 31)
        lblFormName.Name = "lblFormName"
        lblFormName.Size = New Size(129, 27)
        lblFormName.TabIndex = 8
        lblFormName.Text = "Choose Form*"
        ' 
        ' pnlKpis
        ' 
        pnlKpis.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlKpis.Location = New Point(3, 64)
        pnlKpis.Name = "pnlKpis"
        pnlKpis.Size = New Size(504, 348)
        pnlKpis.TabIndex = 9
        ' 
        ' prgLoading
        ' 
        prgLoading.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        prgLoading.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        prgLoading.FillThickness = 5
        prgLoading.Font = New Font("Segoe UI", 12F)
        prgLoading.ForeColor = Color.White
        prgLoading.Location = New Point(473, 27)
        prgLoading.Minimum = 0
        prgLoading.Name = "prgLoading"
        prgLoading.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid
        prgLoading.ProgressThickness = 5
        prgLoading.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        prgLoading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        prgLoading.Size = New Size(34, 34)
        prgLoading.TabIndex = 10
        prgLoading.Text = "Guna2CircleProgressBar1"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' btnRefreshNow
        ' 
        btnRefreshNow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefreshNow.BorderRadius = 6
        btnRefreshNow.CustomizableEdges = CustomizableEdges2
        btnRefreshNow.DisabledState.BorderColor = Color.DarkGray
        btnRefreshNow.DisabledState.CustomBorderColor = Color.DarkGray
        btnRefreshNow.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRefreshNow.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRefreshNow.FillColor = Color.White
        btnRefreshNow.Font = New Font("Segoe UI", 9F)
        btnRefreshNow.ForeColor = SystemColors.ControlText
        btnRefreshNow.Location = New Point(371, 29)
        btnRefreshNow.Name = "btnRefreshNow"
        btnRefreshNow.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        btnRefreshNow.Size = New Size(96, 30)
        btnRefreshNow.TabIndex = 11
        btnRefreshNow.Text = "Refresh Now"
        ' 
        ' ReportingView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnRefreshNow)
        Controls.Add(prgLoading)
        Controls.Add(pnlKpis)
        Controls.Add(lblFormName)
        Controls.Add(sepTop)
        Controls.Add(mnsOptions)
        Name = "ReportingView"
        Size = New Size(510, 415)
        mnsOptions.ResumeLayout(False)
        mnsOptions.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents mnsOptions As MenuStrip
    Private WithEvents smiExportRawReport As ToolStripMenuItem
    Private WithEvents sepTop As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents smiChooseForm As ToolStripMenuItem
    Friend WithEvents lblFormName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlKpis As FlowLayoutPanel
    Friend WithEvents prgLoading As Guna.UI2.WinForms.Guna2CircleProgressBar
    Private WithEvents Timer1 As Timer
    Private WithEvents btnRefreshNow As Guna.UI2.WinForms.Guna2Button

End Class
