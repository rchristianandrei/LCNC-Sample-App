<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealtimeReportTemplateView
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
        lblCaption = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblValue = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' lblCaption
        ' 
        lblCaption.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblCaption.AutoSize = False
        lblCaption.BackColor = Color.Transparent
        lblCaption.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCaption.Location = New Point(37, 16)
        lblCaption.Name = "lblCaption"
        lblCaption.Size = New Size(124, 33)
        lblCaption.TabIndex = 0
        lblCaption.Text = "Caption"
        lblCaption.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' lblValue
        ' 
        lblValue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblValue.AutoSize = False
        lblValue.BackColor = Color.Transparent
        lblValue.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblValue.Location = New Point(23, 62)
        lblValue.Name = "lblValue"
        lblValue.Size = New Size(150, 46)
        lblValue.TabIndex = 1
        lblValue.Text = "0"
        lblValue.TextAlignment = ContentAlignment.TopCenter
        ' 
        ' RealtimeReportTemplateView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(lblValue)
        Controls.Add(lblCaption)
        Name = "RealtimeReportTemplateView"
        Size = New Size(198, 127)
        ResumeLayout(False)
    End Sub

    Private WithEvents lblCaption As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents lblValue As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
