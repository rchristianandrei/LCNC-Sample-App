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
        mnsOptions = New MenuStrip()
        smiChooseForm = New ToolStripMenuItem()
        smiExportRawReport = New ToolStripMenuItem()
        sepTop = New Guna.UI2.WinForms.Guna2Separator()
        lblFormName = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        ' ReportingView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
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

End Class
