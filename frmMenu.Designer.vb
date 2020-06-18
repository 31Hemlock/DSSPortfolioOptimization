<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.btnPreferences = New System.Windows.Forms.Button()
        Me.picTeam = New System.Windows.Forms.PictureBox()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.picDeveloper = New System.Windows.Forms.PictureBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblTitle.Location = New System.Drawing.Point(132, 150)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(637, 67)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "In order to personalize our results, we need to collect some user information pre" &
    "ferences before running our software."
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(345, 80)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(153, 33)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome!"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(333, 382)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(134, 24)
        Me.lblTeam.TabIndex = 2
        Me.lblTeam.Text = "Meet the team!"
        '
        'btnPreferences
        '
        Me.btnPreferences.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnPreferences.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnPreferences.Location = New System.Drawing.Point(337, 236)
        Me.btnPreferences.Name = "btnPreferences"
        Me.btnPreferences.Size = New System.Drawing.Size(170, 62)
        Me.btnPreferences.TabIndex = 3
        Me.btnPreferences.Text = "Add preferences"
        Me.btnPreferences.UseVisualStyleBackColor = False
        '
        'picTeam
        '
        Me.picTeam.Image = CType(resources.GetObject("picTeam.Image"), System.Drawing.Image)
        Me.picTeam.Location = New System.Drawing.Point(337, 409)
        Me.picTeam.Name = "picTeam"
        Me.picTeam.Size = New System.Drawing.Size(170, 109)
        Me.picTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeam.TabIndex = 4
        Me.picTeam.TabStop = False
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblDeveloper.Location = New System.Drawing.Point(12, 383)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(141, 24)
        Me.lblDeveloper.TabIndex = 5
        Me.lblDeveloper.Text = "Developer tools"
        '
        'picDeveloper
        '
        Me.picDeveloper.Image = CType(resources.GetObject("picDeveloper.Image"), System.Drawing.Image)
        Me.picDeveloper.Location = New System.Drawing.Point(12, 410)
        Me.picDeveloper.Name = "picDeveloper"
        Me.picDeveloper.Size = New System.Drawing.Size(167, 108)
        Me.picDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeveloper.TabIndex = 6
        Me.picDeveloper.TabStop = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnEnd.Location = New System.Drawing.Point(702, 466)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(126, 52)
        Me.btnEnd.TabIndex = 7
        Me.btnEnd.Text = "End Program"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(167, 101)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 9
        Me.picLogo.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(840, 530)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.picDeveloper)
        Me.Controls.Add(Me.lblDeveloper)
        Me.Controls.Add(Me.picTeam)
        Me.Controls.Add(Me.btnPreferences)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interface"
        CType(Me.picTeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents btnPreferences As Button
    Friend WithEvents picTeam As PictureBox
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents picDeveloper As PictureBox
    Friend WithEvents btnEnd As Button
    Friend WithEvents picLogo As PictureBox
End Class
