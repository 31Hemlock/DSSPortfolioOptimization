<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeveloperData
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
        Me.lblVariables = New System.Windows.Forms.Label()
        Me.btnInvestments = New System.Windows.Forms.Button()
        Me.btnPeriods = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVariables
        '
        Me.lblVariables.AutoSize = True
        Me.lblVariables.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblVariables.Location = New System.Drawing.Point(12, 18)
        Me.lblVariables.Name = "lblVariables"
        Me.lblVariables.Size = New System.Drawing.Size(259, 22)
        Me.lblVariables.TabIndex = 0
        Me.lblVariables.Text = "Edit developer variables below:"
        '
        'btnInvestments
        '
        Me.btnInvestments.BackColor = System.Drawing.Color.BurlyWood
        Me.btnInvestments.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnInvestments.Location = New System.Drawing.Point(145, 102)
        Me.btnInvestments.Name = "btnInvestments"
        Me.btnInvestments.Size = New System.Drawing.Size(153, 52)
        Me.btnInvestments.TabIndex = 4
        Me.btnInvestments.Text = "Change number of investments"
        Me.btnInvestments.UseVisualStyleBackColor = False
        '
        'btnPeriods
        '
        Me.btnPeriods.BackColor = System.Drawing.Color.BurlyWood
        Me.btnPeriods.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnPeriods.Location = New System.Drawing.Point(145, 180)
        Me.btnPeriods.Name = "btnPeriods"
        Me.btnPeriods.Size = New System.Drawing.Size(153, 52)
        Me.btnPeriods.TabIndex = 5
        Me.btnPeriods.Text = "Change number of periods"
        Me.btnPeriods.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.BurlyWood
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnMenu.Location = New System.Drawing.Point(333, 315)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(113, 45)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Return to Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'frmDeveloperData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(458, 372)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnPeriods)
        Me.Controls.Add(Me.btnInvestments)
        Me.Controls.Add(Me.lblVariables)
        Me.Name = "frmDeveloperData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Developer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVariables As Label
    Friend WithEvents btnInvestments As Button
    Friend WithEvents btnPeriods As Button
    Friend WithEvents btnMenu As Button
End Class
