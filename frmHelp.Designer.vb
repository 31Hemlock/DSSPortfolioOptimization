<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblDevTools = New System.Windows.Forms.Label()
        Me.lblEndProgram = New System.Windows.Forms.Label()
        Me.lblPreferences = New System.Windows.Forms.Label()
        Me.lblMenuHelp = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMathModel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnReturn.Location = New System.Drawing.Point(576, 730)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(115, 44)
        Me.btnReturn.TabIndex = 13
        Me.btnReturn.Text = "Return to Menu"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblContact.Location = New System.Drawing.Point(9, 234)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(240, 18)
        Me.lblContact.TabIndex = 12
        Me.lblContact.Text = "as well as their contact information."
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(9, 216)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(504, 18)
        Me.lblTeam.TabIndex = 11
        Me.lblTeam.Text = "The ""Meet the team"" label allows you to view pictures of the team members,"
        '
        'lblDevTools
        '
        Me.lblDevTools.AutoSize = True
        Me.lblDevTools.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevTools.Location = New System.Drawing.Point(6, 171)
        Me.lblDevTools.Name = "lblDevTools"
        Me.lblDevTools.Size = New System.Drawing.Size(536, 18)
        Me.lblDevTools.TabIndex = 10
        Me.lblDevTools.Text = "The ""Developer tools"" button allows the user to change developer-level variables." &
    ""
        '
        'lblEndProgram
        '
        Me.lblEndProgram.AutoSize = True
        Me.lblEndProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndProgram.Location = New System.Drawing.Point(9, 121)
        Me.lblEndProgram.Name = "lblEndProgram"
        Me.lblEndProgram.Size = New System.Drawing.Size(385, 18)
        Me.lblEndProgram.TabIndex = 9
        Me.lblEndProgram.Text = "The ""End program"" button allows you to end the program."
        '
        'lblPreferences
        '
        Me.lblPreferences.AutoSize = True
        Me.lblPreferences.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreferences.Location = New System.Drawing.Point(6, 74)
        Me.lblPreferences.Name = "lblPreferences"
        Me.lblPreferences.Size = New System.Drawing.Size(546, 18)
        Me.lblPreferences.TabIndex = 8
        Me.lblPreferences.Text = "The ""Preferences"" label allows you to add your preferences to calculate a solutio" &
    "n."
        '
        'lblMenuHelp
        '
        Me.lblMenuHelp.AutoSize = True
        Me.lblMenuHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenuHelp.Location = New System.Drawing.Point(298, 23)
        Me.lblMenuHelp.Name = "lblMenuHelp"
        Me.lblMenuHelp.Size = New System.Drawing.Size(116, 25)
        Me.lblMenuHelp.TabIndex = 7
        Me.lblMenuHelp.Text = "Menu Help"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 308)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(637, 404)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblMathModel
        '
        Me.lblMathModel.AutoSize = True
        Me.lblMathModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblMathModel.Location = New System.Drawing.Point(6, 285)
        Me.lblMathModel.Name = "lblMathModel"
        Me.lblMathModel.Size = New System.Drawing.Size(515, 20)
        Me.lblMathModel.TabIndex = 15
        Me.lblMathModel.Text = "Listed below is the mathematical model we used to develop our solution:"
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(712, 789)
        Me.Controls.Add(Me.lblMathModel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.lblDevTools)
        Me.Controls.Add(Me.lblEndProgram)
        Me.Controls.Add(Me.lblPreferences)
        Me.Controls.Add(Me.lblMenuHelp)
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHelp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents lblContact As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblDevTools As Label
    Friend WithEvents lblEndProgram As Label
    Friend WithEvents lblPreferences As Label
    Friend WithEvents lblMenuHelp As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMathModel As Label
End Class
