<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterView
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BorderRadius = 6
        btnLogin.BorderThickness = 1
        btnLogin.CustomizableEdges = CustomizableEdges1
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.White
        btnLogin.Font = New Font("Segoe UI", 9F)
        btnLogin.ForeColor = SystemColors.ControlText
        btnLogin.Location = New Point(148, 235)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnLogin.Size = New Size(75, 30)
        btnLogin.TabIndex = 9
        btnLogin.Text = "Login"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BorderRadius = 6
        btnSignUp.CustomizableEdges = CustomizableEdges3
        btnSignUp.DisabledState.BorderColor = Color.DarkGray
        btnSignUp.DisabledState.CustomBorderColor = Color.DarkGray
        btnSignUp.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSignUp.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSignUp.Font = New Font("Segoe UI", 9F)
        btnSignUp.ForeColor = Color.White
        btnSignUp.Location = New Point(130, 155)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSignUp.Size = New Size(110, 45)
        btnSignUp.TabIndex = 8
        btnSignUp.Text = "Sign Up"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderRadius = 6
        txtPassword.CustomizableEdges = CustomizableEdges5
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9F)
        txtPassword.ForeColor = SystemColors.ControlText
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Location = New Point(115, 104)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.PlaceholderText = ""
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtPassword.Size = New Size(200, 36)
        txtPassword.TabIndex = 6
        ' 
        ' lblPassword
        ' 
        lblPassword.BackColor = Color.Transparent
        lblPassword.Location = New Point(56, 114)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(53, 17)
        lblPassword.TabIndex = 10
        lblPassword.TabStop = False
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderRadius = 6
        txtUsername.CustomizableEdges = CustomizableEdges7
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F)
        txtUsername.ForeColor = SystemColors.ControlText
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(115, 62)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PlaceholderText = ""
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtUsername.Size = New Size(200, 36)
        txtUsername.TabIndex = 4
        ' 
        ' lblUsername
        ' 
        lblUsername.BackColor = Color.Transparent
        lblUsername.Location = New Point(53, 72)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(56, 17)
        lblUsername.TabIndex = 7
        lblUsername.TabStop = False
        lblUsername.Text = "Username"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(149, 20)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(71, 27)
        Guna2HtmlLabel1.TabIndex = 5
        Guna2HtmlLabel1.TabStop = False
        Guna2HtmlLabel1.Text = "Register"
        ' 
        ' RegisterView
        ' 
        AcceptButton = btnSignUp
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 284)
        Controls.Add(btnLogin)
        Controls.Add(btnSignUp)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(Guna2HtmlLabel1)
        Name = "RegisterView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LCNC App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Private WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
