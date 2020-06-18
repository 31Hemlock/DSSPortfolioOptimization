<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvestments
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.lblCurrentInvestments = New System.Windows.Forms.Label()
        Me.txtCurrentInvestments = New System.Windows.Forms.TextBox()
        Me.txtNewInvestments = New System.Windows.Forms.TextBox()
        Me.lblNewInvestments = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSave.Location = New System.Drawing.Point(151, 173)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDiscard
        '
        Me.btnDiscard.BackColor = System.Drawing.Color.BurlyWood
        Me.btnDiscard.Location = New System.Drawing.Point(151, 209)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(110, 30)
        Me.btnDiscard.TabIndex = 4
        Me.btnDiscard.Text = "Discard changes"
        Me.btnDiscard.UseVisualStyleBackColor = False
        '
        'lblCurrentInvestments
        '
        Me.lblCurrentInvestments.AutoSize = True
        Me.lblCurrentInvestments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCurrentInvestments.Location = New System.Drawing.Point(32, 53)
        Me.lblCurrentInvestments.Name = "lblCurrentInvestments"
        Me.lblCurrentInvestments.Size = New System.Drawing.Size(231, 20)
        Me.lblCurrentInvestments.TabIndex = 8
        Me.lblCurrentInvestments.Text = "Current number of investments:"
        '
        'txtCurrentInvestments
        '
        Me.txtCurrentInvestments.BackColor = System.Drawing.Color.Moccasin
        Me.txtCurrentInvestments.Location = New System.Drawing.Point(292, 53)
        Me.txtCurrentInvestments.Name = "txtCurrentInvestments"
        Me.txtCurrentInvestments.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentInvestments.TabIndex = 1
        '
        'txtNewInvestments
        '
        Me.txtNewInvestments.BackColor = System.Drawing.Color.Moccasin
        Me.txtNewInvestments.Location = New System.Drawing.Point(292, 101)
        Me.txtNewInvestments.Name = "txtNewInvestments"
        Me.txtNewInvestments.Size = New System.Drawing.Size(100, 20)
        Me.txtNewInvestments.TabIndex = 2
        '
        'lblNewInvestments
        '
        Me.lblNewInvestments.AutoSize = True
        Me.lblNewInvestments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNewInvestments.Location = New System.Drawing.Point(80, 99)
        Me.lblNewInvestments.Name = "lblNewInvestments"
        Me.lblNewInvestments.Size = New System.Drawing.Size(183, 20)
        Me.lblNewInvestments.TabIndex = 10
        Me.lblNewInvestments.Text = "New investment number:"
        '
        'frmInvestments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(421, 269)
        Me.Controls.Add(Me.txtNewInvestments)
        Me.Controls.Add(Me.lblNewInvestments)
        Me.Controls.Add(Me.txtCurrentInvestments)
        Me.Controls.Add(Me.lblCurrentInvestments)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmInvestments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change the number of investments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents lblCurrentInvestments As Label
    Friend WithEvents txtCurrentInvestments As TextBox
    Friend WithEvents txtNewInvestments As TextBox
    Friend WithEvents lblNewInvestments As Label
End Class
