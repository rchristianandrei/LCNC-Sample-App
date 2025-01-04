<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        mnsMenu = New MenuStrip()
        smiOpen = New ToolStripMenuItem()
        smiForm = New ToolStripMenuItem()
        smiEditor = New ToolStripMenuItem()
        pnlFeature = New Guna.UI2.WinForms.Guna2Panel()
        sepTop = New Guna.UI2.WinForms.Guna2Separator()
        smiReporting = New ToolStripMenuItem()
        mnsMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnsMenu
        ' 
        mnsMenu.Items.AddRange(New ToolStripItem() {smiOpen, smiEditor, smiReporting})
        mnsMenu.Location = New Point(0, 0)
        mnsMenu.Name = "mnsMenu"
        mnsMenu.Size = New Size(680, 24)
        mnsMenu.TabIndex = 0
        mnsMenu.Text = "MenuStrip1"
        ' 
        ' smiOpen
        ' 
        smiOpen.DropDownItems.AddRange(New ToolStripItem() {smiForm})
        smiOpen.Name = "smiOpen"
        smiOpen.Size = New Size(48, 20)
        smiOpen.Text = "Open"
        ' 
        ' smiForm
        ' 
        smiForm.Name = "smiForm"
        smiForm.Size = New Size(102, 22)
        smiForm.Text = "Form"
        ' 
        ' smiEditor
        ' 
        smiEditor.Name = "smiEditor"
        smiEditor.Size = New Size(50, 20)
        smiEditor.Text = "Editor"
        ' 
        ' pnlFeature
        ' 
        pnlFeature.CustomizableEdges = CustomizableEdges3
        pnlFeature.Dock = DockStyle.Fill
        pnlFeature.Location = New Point(0, 25)
        pnlFeature.Name = "pnlFeature"
        pnlFeature.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlFeature.Size = New Size(680, 425)
        pnlFeature.TabIndex = 1
        ' 
        ' sepTop
        ' 
        sepTop.Dock = DockStyle.Top
        sepTop.FillColor = SystemColors.ControlText
        sepTop.Location = New Point(0, 24)
        sepTop.Name = "sepTop"
        sepTop.Size = New Size(680, 1)
        sepTop.TabIndex = 7
        ' 
        ' smiReporting
        ' 
        smiReporting.Name = "smiReporting"
        smiReporting.Size = New Size(71, 20)
        smiReporting.Text = "Reporting"
        ' 
        ' MainView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(680, 450)
        Controls.Add(pnlFeature)
        Controls.Add(sepTop)
        Controls.Add(mnsMenu)
        MainMenuStrip = mnsMenu
        MinimumSize = New Size(696, 489)
        Name = "MainView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LCNC App"
        mnsMenu.ResumeLayout(False)
        mnsMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents pnlFeature As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents mnsMenu As MenuStrip
    Private WithEvents smiOpen As ToolStripMenuItem
    Private WithEvents smiEditor As ToolStripMenuItem
    Friend WithEvents sepTop As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents smiForm As ToolStripMenuItem
    Friend WithEvents smiReporting As ToolStripMenuItem

End Class
