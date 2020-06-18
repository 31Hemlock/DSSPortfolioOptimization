<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriods
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
        Me.txtNewPeriods = New System.Windows.Forms.TextBox()
        Me.lblNewPeriods = New System.Windows.Forms.Label()
        Me.txtCurrentPeriods = New System.Windows.Forms.TextBox()
        Me.lblCurrentPeriods = New System.Windows.Forms.Label()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNewPeriods
        '
        Me.txtNewPeriods.BackColor = System.Drawing.Color.Moccasin
        Me.txtNewPeriods.Location = New System.Drawing.Point(293, 102)
        Me.txtNewPeriods.Name = "txtNewPeriods"
        Me.txtNewPeriods.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPeriods.TabIndex = 12
        '
        'lblNewPeriods
        '
        Me.lblNewPeriods.AutoSize = True
        Me.lblNewPeriods.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPeriods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNewPeriods.Location = New System.Drawing.Point(112, 100)
        Me.lblNewPeriods.Name = "lblNewPeriods"
        Me.lblNewPeriods.Size = New System.Drawing.Size(150, 20)
        Me.lblNewPeriods.TabIndex = 16
        Me.lblNewPeriods.Text = "New period number:"
        '
        'txtCurrentPeriods
        '
        Me.txtCurrentPeriods.BackColor = System.Drawing.Color.Moccasin
        Me.txtCurrentPeriods.Location = New System.Drawing.Point(293, 54)
        Me.txtCurrentPeriods.Name = "txtCurrentPeriods"
        Me.txtCurrentPeriods.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentPeriods.TabIndex = 11
        '
        'lblCurrentPeriods
        '
        Me.lblCurrentPeriods.AutoSize = True
        Me.lblCurrentPeriods.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPeriods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCurrentPeriods.Location = New System.Drawing.Point(64, 54)
        Me.lblCurrentPeriods.Name = "lblCurrentPeriods"
        Me.lblCurrentPeriods.Size = New System.Drawing.Size(198, 20)
        Me.lblCurrentPeriods.TabIndex = 15
        Me.lblCurrentPeriods.Text = "Current number of periods:"
        '
        'btnDiscard
        '
        Me.btnDiscard.BackColor = System.Drawing.Color.BurlyWood
        Me.btnDiscard.Location = New System.Drawing.Point(152, 210)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(110, 30)
        Me.btnDiscard.TabIndex = 14
        Me.btnDiscard.Text = "Discard changes"
        Me.btnDiscard.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSave.Location = New System.Drawing.Point(152, 174)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 30)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmPeriods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(421, 270)
        Me.Controls.Add(Me.txtNewPeriods)
        Me.Controls.Add(Me.lblNewPeriods)
        Me.Controls.Add(Me.txtCurrentPeriods)
        Me.Controls.Add(Me.lblCurrentPeriods)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmPeriods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPeriods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewPeriods As TextBox
    Friend WithEvents lblNewPeriods As Label
    Friend WithEvents txtCurrentPeriods As TextBox
    Friend WithEvents lblCurrentPeriods As Label
    Friend WithEvents btnDiscard As Button
    Friend WithEvents btnSave As Button
End Class
