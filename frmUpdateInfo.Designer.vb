<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateInfo
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtBudget = New System.Windows.Forms.TextBox()
        Me.lblBudgetDetail = New System.Windows.Forms.Label()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.txtEquity = New System.Windows.Forms.TextBox()
        Me.lblEquityDetail = New System.Windows.Forms.Label()
        Me.lblEquity = New System.Windows.Forms.Label()
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.lblRiskDetail = New System.Windows.Forms.Label()
        Me.lblRisk = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCalculate.Location = New System.Drawing.Point(381, 382)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(124, 48)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtBudget
        '
        Me.txtBudget.BackColor = System.Drawing.Color.Moccasin
        Me.txtBudget.Location = New System.Drawing.Point(16, 382)
        Me.txtBudget.Name = "txtBudget"
        Me.txtBudget.Size = New System.Drawing.Size(104, 20)
        Me.txtBudget.TabIndex = 18
        '
        'lblBudgetDetail
        '
        Me.lblBudgetDetail.AutoSize = True
        Me.lblBudgetDetail.Location = New System.Drawing.Point(13, 341)
        Me.lblBudgetDetail.Name = "lblBudgetDetail"
        Me.lblBudgetDetail.Size = New System.Drawing.Size(128, 13)
        Me.lblBudgetDetail.TabIndex = 17
        Me.lblBudgetDetail.Text = "Please enter your budget."
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.Location = New System.Drawing.Point(12, 296)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(306, 24)
        Me.lblBudget.TabIndex = 16
        Me.lblBudget.Text = "What is your budget for the project?"
        '
        'txtEquity
        '
        Me.txtEquity.BackColor = System.Drawing.Color.Moccasin
        Me.txtEquity.Location = New System.Drawing.Point(16, 240)
        Me.txtEquity.Name = "txtEquity"
        Me.txtEquity.Size = New System.Drawing.Size(104, 20)
        Me.txtEquity.TabIndex = 15
        '
        'lblEquityDetail
        '
        Me.lblEquityDetail.AutoSize = True
        Me.lblEquityDetail.Location = New System.Drawing.Point(13, 199)
        Me.lblEquityDetail.Name = "lblEquityDetail"
        Me.lblEquityDetail.Size = New System.Drawing.Size(324, 13)
        Me.lblEquityDetail.TabIndex = 14
        Me.lblEquityDetail.Text = "Please enter a value to represent your preferred social equity rating."
        '
        'lblEquity
        '
        Me.lblEquity.AutoSize = True
        Me.lblEquity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquity.Location = New System.Drawing.Point(12, 154)
        Me.lblEquity.Name = "lblEquity"
        Me.lblEquity.Size = New System.Drawing.Size(421, 24)
        Me.lblEquity.TabIndex = 13
        Me.lblEquity.Text = "What social equity rating would you prefer? (1-10)"
        '
        'txtRisk
        '
        Me.txtRisk.BackColor = System.Drawing.Color.Moccasin
        Me.txtRisk.Location = New System.Drawing.Point(16, 95)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(104, 20)
        Me.txtRisk.TabIndex = 12
        '
        'lblRiskDetail
        '
        Me.lblRiskDetail.AutoSize = True
        Me.lblRiskDetail.Location = New System.Drawing.Point(13, 54)
        Me.lblRiskDetail.Name = "lblRiskDetail"
        Me.lblRiskDetail.Size = New System.Drawing.Size(310, 13)
        Me.lblRiskDetail.TabIndex = 11
        Me.lblRiskDetail.Text = "Please enter a value to represent your preferred beta coefficient."
        '
        'lblRisk
        '
        Me.lblRisk.AutoSize = True
        Me.lblRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRisk.Location = New System.Drawing.Point(12, 9)
        Me.lblRisk.Name = "lblRisk"
        Me.lblRisk.Size = New System.Drawing.Size(440, 24)
        Me.lblRisk.TabIndex = 10
        Me.lblRisk.Text = "How risky would you like for your profile to be? (0-2)"
        '
        'frmUpdateInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(544, 454)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBudget)
        Me.Controls.Add(Me.lblBudgetDetail)
        Me.Controls.Add(Me.lblBudget)
        Me.Controls.Add(Me.txtEquity)
        Me.Controls.Add(Me.lblEquityDetail)
        Me.Controls.Add(Me.lblEquity)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.lblRiskDetail)
        Me.Controls.Add(Me.lblRisk)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmUpdateInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdateInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtBudget As TextBox
    Friend WithEvents lblBudgetDetail As Label
    Friend WithEvents lblBudget As Label
    Friend WithEvents txtEquity As TextBox
    Friend WithEvents lblEquityDetail As Label
    Friend WithEvents lblEquity As Label
    Friend WithEvents txtRisk As TextBox
    Friend WithEvents lblRiskDetail As Label
    Friend WithEvents lblRisk As Label
End Class
