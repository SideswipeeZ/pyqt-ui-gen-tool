<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EVForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EVForm))
        Me.bttn_HouAuto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttn_setVersion = New System.Windows.Forms.Button()
        Me.cmb_found = New System.Windows.Forms.ComboBox()
        Me.bttn_ManualHou = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bttn_ManOpen = New System.Windows.Forms.Button()
        Me.txtManO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BottomPic = New System.Windows.Forms.PictureBox()
        Me.VarGroup = New System.Windows.Forms.GroupBox()
        Me.bttn_Find = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_VarIn = New System.Windows.Forms.TextBox()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVarD = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BottomPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VarGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttn_HouAuto
        '
        Me.bttn_HouAuto.Location = New System.Drawing.Point(11, 32)
        Me.bttn_HouAuto.Name = "bttn_HouAuto"
        Me.bttn_HouAuto.Size = New System.Drawing.Size(76, 42)
        Me.bttn_HouAuto.TabIndex = 0
        Me.bttn_HouAuto.Text = "(Autolocate)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Houdini"
        Me.bttn_HouAuto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bttn_setVersion)
        Me.GroupBox1.Controls.Add(Me.cmb_found)
        Me.GroupBox1.Controls.Add(Me.bttn_HouAuto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 214)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Auto Locate Enviroment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select Version:"
        '
        'bttn_setVersion
        '
        Me.bttn_setVersion.Enabled = False
        Me.bttn_setVersion.Location = New System.Drawing.Point(11, 156)
        Me.bttn_setVersion.Name = "bttn_setVersion"
        Me.bttn_setVersion.Size = New System.Drawing.Size(181, 31)
        Me.bttn_setVersion.TabIndex = 2
        Me.bttn_setVersion.Text = "Open File"
        Me.bttn_setVersion.UseVisualStyleBackColor = True
        '
        'cmb_found
        '
        Me.cmb_found.FormattingEnabled = True
        Me.cmb_found.Location = New System.Drawing.Point(11, 129)
        Me.cmb_found.Name = "cmb_found"
        Me.cmb_found.Size = New System.Drawing.Size(181, 21)
        Me.cmb_found.TabIndex = 1
        '
        'bttn_ManualHou
        '
        Me.bttn_ManualHou.Location = New System.Drawing.Point(6, 32)
        Me.bttn_ManualHou.Name = "bttn_ManualHou"
        Me.bttn_ManualHou.Size = New System.Drawing.Size(93, 42)
        Me.bttn_ManualHou.TabIndex = 3
        Me.bttn_ManualHou.Text = "(Manual)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Houdini"
        Me.bttn_ManualHou.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.bttn_ManOpen)
        Me.GroupBox2.Controls.Add(Me.txtManO)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.bttn_ManualHou)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 214)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manually Locate Enviroment"
        '
        'bttn_ManOpen
        '
        Me.bttn_ManOpen.Enabled = False
        Me.bttn_ManOpen.Location = New System.Drawing.Point(6, 156)
        Me.bttn_ManOpen.Name = "bttn_ManOpen"
        Me.bttn_ManOpen.Size = New System.Drawing.Size(198, 31)
        Me.bttn_ManOpen.TabIndex = 9
        Me.bttn_ManOpen.Text = "Open File"
        Me.bttn_ManOpen.UseVisualStyleBackColor = True
        '
        'txtManO
        '
        Me.txtManO.Location = New System.Drawing.Point(6, 129)
        Me.txtManO.Name = "txtManO"
        Me.txtManO.ReadOnly = True
        Me.txtManO.Size = New System.Drawing.Size(198, 20)
        Me.txtManO.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Selected Path:"
        '
        'BottomPic
        '
        Me.BottomPic.BackgroundImage = Global.PyUiCreator.My.Resources.Resources.bottom
        Me.BottomPic.InitialImage = Global.PyUiCreator.My.Resources.Resources.logo
        Me.BottomPic.Location = New System.Drawing.Point(-7, 499)
        Me.BottomPic.Name = "BottomPic"
        Me.BottomPic.Size = New System.Drawing.Size(457, 120)
        Me.BottomPic.TabIndex = 8
        Me.BottomPic.TabStop = False
        '
        'VarGroup
        '
        Me.VarGroup.Controls.Add(Me.txtVarD)
        Me.VarGroup.Controls.Add(Me.Label4)
        Me.VarGroup.Controls.Add(Me.bttn_Find)
        Me.VarGroup.Controls.Add(Me.Label3)
        Me.VarGroup.Controls.Add(Me.txt_VarIn)
        Me.VarGroup.Location = New System.Drawing.Point(12, 304)
        Me.VarGroup.Name = "VarGroup"
        Me.VarGroup.Size = New System.Drawing.Size(420, 189)
        Me.VarGroup.TabIndex = 9
        Me.VarGroup.TabStop = False
        Me.VarGroup.Text = "Variable Settings"
        '
        'bttn_Find
        '
        Me.bttn_Find.Enabled = False
        Me.bttn_Find.Location = New System.Drawing.Point(11, 138)
        Me.bttn_Find.Name = "bttn_Find"
        Me.bttn_Find.Size = New System.Drawing.Size(403, 32)
        Me.bttn_Find.TabIndex = 2
        Me.bttn_Find.Text = "Add Variable"
        Me.bttn_Find.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Select Variable name to Add (Case Sensitive):"
        '
        'txt_VarIn
        '
        Me.txt_VarIn.Enabled = False
        Me.txt_VarIn.Location = New System.Drawing.Point(11, 54)
        Me.txt_VarIn.Name = "txt_VarIn"
        Me.txt_VarIn.Size = New System.Drawing.Size(403, 20)
        Me.txt_VarIn.TabIndex = 0
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Location = New System.Drawing.Point(13, 270)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(65, 13)
        Me.lblLoc.TabIndex = 10
        Me.lblLoc.Text = "File Locked:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter Variable Data to Add"
        '
        'txtVarD
        '
        Me.txtVarD.Enabled = False
        Me.txtVarD.Location = New System.Drawing.Point(11, 112)
        Me.txtVarD.Name = "txtVarD"
        Me.txtVarD.Size = New System.Drawing.Size(403, 20)
        Me.txtVarD.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(106, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "(Autolocate)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maya"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(105, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "(Manual)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maya"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "MAYA (WIP)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MAYA (WIP)"
        '
        'EVForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 544)
        Me.Controls.Add(Me.lblLoc)
        Me.Controls.Add(Me.VarGroup)
        Me.Controls.Add(Me.BottomPic)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EVForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Enviroment Variable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BottomPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VarGroup.ResumeLayout(False)
        Me.VarGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttn_HouAuto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_found As ComboBox
    Friend WithEvents bttn_setVersion As Button
    Friend WithEvents bttn_ManualHou As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BottomPic As PictureBox
    Friend WithEvents txtManO As TextBox
    Friend WithEvents bttn_ManOpen As Button
    Friend WithEvents VarGroup As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_VarIn As TextBox
    Friend WithEvents bttn_Find As Button
    Friend WithEvents lblLoc As Label
    Friend WithEvents txtVarD As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
