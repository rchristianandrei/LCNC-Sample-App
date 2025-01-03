<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        pnlComponents = New Guna.UI2.WinForms.Guna2Panel()
        btnStart = New Guna.UI2.WinForms.Guna2Button()
        tmr1s = New Timer(components)
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnSubmit.BorderRadius = 6
        btnSubmit.CustomizableEdges = CustomizableEdges1
        btnSubmit.DisabledState.BorderColor = Color.DarkGray
        btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray
        btnSubmit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSubmit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSubmit.Font = New Font("Segoe UI", 9F)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(12, 404)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSubmit.Size = New Size(439, 34)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "Submit"
        ' 
        ' pnlComponents
        ' 
        pnlComponents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlComponents.CustomizableEdges = CustomizableEdges3
        pnlComponents.Location = New Point(12, 52)
        pnlComponents.Name = "pnlComponents"
        pnlComponents.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlComponents.Size = New Size(439, 346)
        pnlComponents.TabIndex = 2
        ' 
        ' btnStart
        ' 
        btnStart.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnStart.BorderRadius = 6
        btnStart.CustomizableEdges = CustomizableEdges5
        btnStart.DisabledState.BorderColor = Color.DarkGray
        btnStart.DisabledState.CustomBorderColor = Color.DarkGray
        btnStart.DisabledState.FillColor = Color.Green
        btnStart.DisabledState.ForeColor = Color.White
        btnStart.Font = New Font("Segoe UI", 9F)
        btnStart.ForeColor = Color.White
        btnStart.Location = New Point(12, 12)
        btnStart.Name = "btnStart"
        btnStart.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnStart.Size = New Size(439, 34)
        btnStart.TabIndex = 3
        btnStart.Text = "Start"
        ' 
        ' tmr1s
        ' 
        tmr1s.Interval = 1000
        ' 
        ' FormView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 450)
        Controls.Add(btnStart)
        Controls.Add(pnlComponents)
        Controls.Add(btnSubmit)
        Name = "FormView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormView"
        ResumeLayout(False)
    End Sub

    Private WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlComponents As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Private WithEvents tmr1s As Timer
End Class
