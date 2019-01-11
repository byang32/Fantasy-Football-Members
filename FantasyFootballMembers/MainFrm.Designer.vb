<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtTname = New System.Windows.Forms.TextBox()
        Me.grpbxMemberInfo = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstboxMembers = New System.Windows.Forms.ListBox()
        Me.lblCurrentMembers = New System.Windows.Forms.Label()
        Me.lblDisplayFName = New System.Windows.Forms.Label()
        Me.lblDisplayLName = New System.Windows.Forms.Label()
        Me.lblDisplayMemID = New System.Windows.Forms.Label()
        Me.lblDisplayTeamName = New System.Windows.Forms.Label()
        Me.grpbox2Display = New System.Windows.Forms.GroupBox()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.lblDisplayWins = New System.Windows.Forms.Label()
        Me.lblStatsF = New System.Windows.Forms.Label()
        Me.lblStatsL = New System.Windows.Forms.Label()
        Me.lblStatsTN = New System.Windows.Forms.Label()
        Me.lblStatsChamp = New System.Windows.Forms.Label()
        Me.lblStatsID = New System.Windows.Forms.Label()
        Me.grpbxMemberInfo.SuspendLayout()
        Me.grpbox2Display.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(20, 36)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(90, 20)
        Me.lblFname.TabIndex = 0
        Me.lblFname.Text = "First Name:"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(20, 117)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(90, 20)
        Me.lblLname.TabIndex = 1
        Me.lblLname.Text = "Last Name:"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Location = New System.Drawing.Point(20, 196)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(99, 20)
        Me.lblTeamName.TabIndex = 3
        Me.lblTeamName.Text = "Team Name:"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(125, 36)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(100, 26)
        Me.txtFname.TabIndex = 4
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(125, 111)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(100, 26)
        Me.txtLname.TabIndex = 5
        '
        'txtTname
        '
        Me.txtTname.Location = New System.Drawing.Point(125, 196)
        Me.txtTname.Name = "txtTname"
        Me.txtTname.Size = New System.Drawing.Size(100, 26)
        Me.txtTname.TabIndex = 7
        '
        'grpbxMemberInfo
        '
        Me.grpbxMemberInfo.Controls.Add(Me.btnSubmit)
        Me.grpbxMemberInfo.Controls.Add(Me.txtFname)
        Me.grpbxMemberInfo.Controls.Add(Me.lblTeamName)
        Me.grpbxMemberInfo.Controls.Add(Me.txtTname)
        Me.grpbxMemberInfo.Controls.Add(Me.lblFname)
        Me.grpbxMemberInfo.Controls.Add(Me.txtLname)
        Me.grpbxMemberInfo.Controls.Add(Me.lblLname)
        Me.grpbxMemberInfo.Location = New System.Drawing.Point(29, 35)
        Me.grpbxMemberInfo.Name = "grpbxMemberInfo"
        Me.grpbxMemberInfo.Size = New System.Drawing.Size(237, 369)
        Me.grpbxMemberInfo.TabIndex = 8
        Me.grpbxMemberInfo.TabStop = False
        Me.grpbxMemberInfo.Text = "New Member Information"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(24, 318)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(201, 32)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lstboxMembers
        '
        Me.lstboxMembers.FormattingEnabled = True
        Me.lstboxMembers.ItemHeight = 20
        Me.lstboxMembers.Location = New System.Drawing.Point(310, 60)
        Me.lstboxMembers.Name = "lstboxMembers"
        Me.lstboxMembers.Size = New System.Drawing.Size(146, 344)
        Me.lstboxMembers.TabIndex = 9
        '
        'lblCurrentMembers
        '
        Me.lblCurrentMembers.AutoSize = True
        Me.lblCurrentMembers.Location = New System.Drawing.Point(306, 35)
        Me.lblCurrentMembers.Name = "lblCurrentMembers"
        Me.lblCurrentMembers.Size = New System.Drawing.Size(115, 20)
        Me.lblCurrentMembers.TabIndex = 10
        Me.lblCurrentMembers.Text = "League Teams"
        '
        'lblDisplayFName
        '
        Me.lblDisplayFName.AutoSize = True
        Me.lblDisplayFName.Location = New System.Drawing.Point(125, 22)
        Me.lblDisplayFName.Name = "lblDisplayFName"
        Me.lblDisplayFName.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayFName.TabIndex = 12
        Me.lblDisplayFName.Text = "*"
        '
        'lblDisplayLName
        '
        Me.lblDisplayLName.AutoSize = True
        Me.lblDisplayLName.Location = New System.Drawing.Point(125, 86)
        Me.lblDisplayLName.Name = "lblDisplayLName"
        Me.lblDisplayLName.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayLName.TabIndex = 13
        Me.lblDisplayLName.Text = "*"
        '
        'lblDisplayMemID
        '
        Me.lblDisplayMemID.AutoSize = True
        Me.lblDisplayMemID.Location = New System.Drawing.Point(125, 281)
        Me.lblDisplayMemID.Name = "lblDisplayMemID"
        Me.lblDisplayMemID.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayMemID.TabIndex = 14
        Me.lblDisplayMemID.Text = "*"
        '
        'lblDisplayTeamName
        '
        Me.lblDisplayTeamName.AutoSize = True
        Me.lblDisplayTeamName.Location = New System.Drawing.Point(125, 152)
        Me.lblDisplayTeamName.Name = "lblDisplayTeamName"
        Me.lblDisplayTeamName.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayTeamName.TabIndex = 15
        Me.lblDisplayTeamName.Text = "*"
        '
        'grpbox2Display
        '
        Me.grpbox2Display.Controls.Add(Me.lblStatsID)
        Me.grpbox2Display.Controls.Add(Me.lblStatsChamp)
        Me.grpbox2Display.Controls.Add(Me.lblStatsTN)
        Me.grpbox2Display.Controls.Add(Me.lblStatsL)
        Me.grpbox2Display.Controls.Add(Me.lblStatsF)
        Me.grpbox2Display.Controls.Add(Me.lblDisplayWins)
        Me.grpbox2Display.Controls.Add(Me.lblDisplayFName)
        Me.grpbox2Display.Controls.Add(Me.lblDisplayTeamName)
        Me.grpbox2Display.Controls.Add(Me.lblDisplayLName)
        Me.grpbox2Display.Controls.Add(Me.lblDisplayMemID)
        Me.grpbox2Display.Location = New System.Drawing.Point(479, 60)
        Me.grpbox2Display.Name = "grpbox2Display"
        Me.grpbox2Display.Size = New System.Drawing.Size(256, 346)
        Me.grpbox2Display.TabIndex = 16
        Me.grpbox2Display.TabStop = False
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.Location = New System.Drawing.Point(475, 35)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(91, 20)
        Me.lblStats.TabIndex = 17
        Me.lblStats.Text = "Team Stats"
        '
        'lblDisplayWins
        '
        Me.lblDisplayWins.AutoSize = True
        Me.lblDisplayWins.Location = New System.Drawing.Point(125, 217)
        Me.lblDisplayWins.Name = "lblDisplayWins"
        Me.lblDisplayWins.Size = New System.Drawing.Size(15, 20)
        Me.lblDisplayWins.TabIndex = 16
        Me.lblDisplayWins.Text = "*"
        '
        'lblStatsF
        '
        Me.lblStatsF.AutoSize = True
        Me.lblStatsF.Location = New System.Drawing.Point(20, 22)
        Me.lblStatsF.Name = "lblStatsF"
        Me.lblStatsF.Size = New System.Drawing.Size(90, 20)
        Me.lblStatsF.TabIndex = 17
        Me.lblStatsF.Text = "First Name:"
        '
        'lblStatsL
        '
        Me.lblStatsL.AutoSize = True
        Me.lblStatsL.Location = New System.Drawing.Point(20, 86)
        Me.lblStatsL.Name = "lblStatsL"
        Me.lblStatsL.Size = New System.Drawing.Size(90, 20)
        Me.lblStatsL.TabIndex = 18
        Me.lblStatsL.Text = "Last Name:"
        '
        'lblStatsTN
        '
        Me.lblStatsTN.AutoSize = True
        Me.lblStatsTN.Location = New System.Drawing.Point(11, 152)
        Me.lblStatsTN.Name = "lblStatsTN"
        Me.lblStatsTN.Size = New System.Drawing.Size(99, 20)
        Me.lblStatsTN.TabIndex = 19
        Me.lblStatsTN.Text = "Team Name:"
        '
        'lblStatsChamp
        '
        Me.lblStatsChamp.AutoSize = True
        Me.lblStatsChamp.Location = New System.Drawing.Point(4, 217)
        Me.lblStatsChamp.Name = "lblStatsChamp"
        Me.lblStatsChamp.Size = New System.Drawing.Size(106, 20)
        Me.lblStatsChamp.TabIndex = 20
        Me.lblStatsChamp.Text = "League Wins:"
        '
        'lblStatsID
        '
        Me.lblStatsID.AutoSize = True
        Me.lblStatsID.Location = New System.Drawing.Point(18, 281)
        Me.lblStatsID.Name = "lblStatsID"
        Me.lblStatsID.Size = New System.Drawing.Size(92, 20)
        Me.lblStatsID.TabIndex = 21
        Me.lblStatsID.Text = "Member ID:"
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 416)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.grpbox2Display)
        Me.Controls.Add(Me.lblCurrentMembers)
        Me.Controls.Add(Me.lstboxMembers)
        Me.Controls.Add(Me.grpbxMemberInfo)
        Me.Name = "MainFrm"
        Me.Text = "Fantasy FootBall League"
        Me.grpbxMemberInfo.ResumeLayout(False)
        Me.grpbxMemberInfo.PerformLayout()
        Me.grpbox2Display.ResumeLayout(False)
        Me.grpbox2Display.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblTeamName As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtTname As TextBox
    Friend WithEvents grpbxMemberInfo As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstboxMembers As ListBox
    Friend WithEvents lblCurrentMembers As Label
    Friend WithEvents lblDisplayFName As Label
    Friend WithEvents lblDisplayLName As Label
    Friend WithEvents lblDisplayMemID As Label
    Friend WithEvents lblDisplayTeamName As Label
    Friend WithEvents grpbox2Display As GroupBox
    Friend WithEvents lblStatsID As Label
    Friend WithEvents lblStatsChamp As Label
    Friend WithEvents lblStatsTN As Label
    Friend WithEvents lblStatsL As Label
    Friend WithEvents lblStatsF As Label
    Friend WithEvents lblDisplayWins As Label
    Friend WithEvents lblStats As Label
End Class
