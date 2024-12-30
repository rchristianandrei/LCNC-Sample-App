<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTextbox
    Inherits FormControlComponent

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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtTextbox = New Guna.UI2.WinForms.Guna2TextBox()
        SuspendLayout()
        ' 
        ' lblLabel
        ' 
        lblLabel.AutoSize = False
        lblLabel.BackColor = SystemColors.Control
        lblLabel.Dock = DockStyle.Top
        lblLabel.Enabled = False
        lblLabel.Location = New Point(1, 1)
        lblLabel.Name = "lblLabel"
        lblLabel.Size = New Size(198, 17)
        lblLabel.TabIndex = 0
        lblLabel.Text = "Textbox Label"
        ' 
        ' txtTextbox
        ' 
        txtTextbox.BackColor = SystemColors.Control
        txtTextbox.BorderRadius = 6
        txtTextbox.CustomizableEdges = CustomizableEdges1
        txtTextbox.DefaultText = ""
        txtTextbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtTextbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtTextbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTextbox.Dock = DockStyle.Fill
        txtTextbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTextbox.Font = New Font("Segoe UI", 9F)
        txtTextbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTextbox.Location = New Point(1, 18)
        txtTextbox.Name = "txtTextbox"
        txtTextbox.PasswordChar = ChrW(0)
        txtTextbox.PlaceholderText = ""
        txtTextbox.SelectedText = ""
        txtTextbox.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtTextbox.Size = New Size(198, 29)
        txtTextbox.TabIndex = 1
        ' 
        ' FormTextbox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(txtTextbox)
        Controls.Add(lblLabel)
        Name = "FormTextbox"
        Padding = New Padding(1)
        Size = New Size(200, 48)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTextbox As Guna.UI2.WinForms.Guna2TextBox

End Class
