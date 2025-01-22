<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComponentsDropdownboxView
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnBringToFront = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' btnBringToFront
        ' 
        btnBringToFront.Anchor = AnchorStyles.Top
        btnBringToFront.BorderColor = Color.FromArgb(CByte(213), CByte(218), CByte(223))
        btnBringToFront.BorderRadius = 6
        btnBringToFront.BorderThickness = 1
        btnBringToFront.CustomizableEdges = CustomizableEdges1
        btnBringToFront.DisabledState.BorderColor = Color.DarkGray
        btnBringToFront.DisabledState.CustomBorderColor = Color.DarkGray
        btnBringToFront.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBringToFront.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBringToFront.FillColor = Color.White
        btnBringToFront.Font = New Font("Segoe UI", 9F)
        btnBringToFront.ForeColor = SystemColors.ControlText
        btnBringToFront.Location = New Point(26, 3)
        btnBringToFront.Margin = New Padding(0)
        btnBringToFront.Name = "btnBringToFront"
        btnBringToFront.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBringToFront.Size = New Size(104, 40)
        btnBringToFront.TabIndex = 8
        btnBringToFront.Text = "Open Items Uploader"
        ' 
        ' FormComponentsDropdownboxView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnBringToFront)
        Name = "FormComponentsDropdownboxView"
        Size = New Size(156, 118)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBringToFront As Guna.UI2.WinForms.Guna2Button

End Class
