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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        pnlComponents = New Guna.UI2.WinForms.Guna2Panel()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BorderRadius = 6
        btnSubmit.CustomizableEdges = CustomizableEdges1
        btnSubmit.DisabledState.BorderColor = Color.DarkGray
        btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray
        btnSubmit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSubmit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSubmit.Dock = DockStyle.Bottom
        btnSubmit.Font = New Font("Segoe UI", 9F)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(0, 416)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSubmit.Size = New Size(463, 34)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "Submit"
        ' 
        ' pnlComponents
        ' 
        pnlComponents.CustomizableEdges = CustomizableEdges3
        pnlComponents.Dock = DockStyle.Fill
        pnlComponents.Location = New Point(0, 0)
        pnlComponents.Name = "pnlComponents"
        pnlComponents.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlComponents.Size = New Size(463, 416)
        pnlComponents.TabIndex = 2
        ' 
        ' FormView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 450)
        Controls.Add(pnlComponents)
        Controls.Add(btnSubmit)
        Name = "FormView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormView"
        ResumeLayout(False)
    End Sub

    Private WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlComponents As Guna.UI2.WinForms.Guna2Panel
End Class
