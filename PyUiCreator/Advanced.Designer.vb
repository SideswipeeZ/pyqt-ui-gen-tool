<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Advanced
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Advanced))
        Me.bttn_main = New System.Windows.Forms.Button()
        Me.Rdo_Env = New System.Windows.Forms.RadioButton()
        Me.Rdo_Man = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_PValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LstBx_QtImports = New System.Windows.Forms.CheckedListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_FilePath = New System.Windows.Forms.TextBox()
        Me.txt_WinTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ClassName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_Size2 = New System.Windows.Forms.TextBox()
        Me.txt_Size1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_pan = New System.Windows.Forms.ComboBox()
        Me.bttn_Pre = New System.Windows.Forms.Button()
        Me.bttn_toggle = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.RichTextBox()
        Me.chk_houStyle = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttn_main
        '
        Me.bttn_main.Location = New System.Drawing.Point(14, 580)
        Me.bttn_main.Name = "bttn_main"
        Me.bttn_main.Size = New System.Drawing.Size(384, 53)
        Me.bttn_main.TabIndex = 0
        Me.bttn_main.Text = "Export Python Code File"
        Me.bttn_main.UseVisualStyleBackColor = True
        '
        'Rdo_Env
        '
        Me.Rdo_Env.AutoSize = True
        Me.Rdo_Env.Checked = True
        Me.Rdo_Env.Location = New System.Drawing.Point(9, 51)
        Me.Rdo_Env.Name = "Rdo_Env"
        Me.Rdo_Env.Size = New System.Drawing.Size(179, 17)
        Me.Rdo_Env.TabIndex = 3
        Me.Rdo_Env.TabStop = True
        Me.Rdo_Env.Text = "Via Enviroment Variable(Houdini)"
        Me.Rdo_Env.UseVisualStyleBackColor = True
        '
        'Rdo_Man
        '
        Me.Rdo_Man.AutoSize = True
        Me.Rdo_Man.Location = New System.Drawing.Point(220, 51)
        Me.Rdo_Man.Name = "Rdo_Man"
        Me.Rdo_Man.Size = New System.Drawing.Size(103, 17)
        Me.Rdo_Man.TabIndex = 4
        Me.Rdo_Man.Text = "Via Manual Path"
        Me.Rdo_Man.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select option to load Qt Module from."
        '
        'txt_PValue
        '
        Me.txt_PValue.Location = New System.Drawing.Point(6, 106)
        Me.txt_PValue.Name = "txt_PValue"
        Me.txt_PValue.Size = New System.Drawing.Size(362, 20)
        Me.txt_PValue.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Please Type the Enviroment Variable/ Path. (Leave Blank for Default Value)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Rdo_Env)
        Me.GroupBox1.Controls.Add(Me.txt_PValue)
        Me.GroupBox1.Controls.Add(Me.Rdo_Man)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 137)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Qt Module"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LstBx_QtImports)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 163)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Qt Imports"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Import QtCore, QtWidget, QtCompat"
        '
        'LstBx_QtImports
        '
        Me.LstBx_QtImports.FormattingEnabled = True
        Me.LstBx_QtImports.Items.AddRange(New Object() {"QtGui", "QtMultimedia", "QtNetwork", "QtQML", "QtQuick"})
        Me.LstBx_QtImports.Location = New System.Drawing.Point(6, 49)
        Me.LstBx_QtImports.Name = "LstBx_QtImports"
        Me.LstBx_QtImports.Size = New System.Drawing.Size(176, 94)
        Me.LstBx_QtImports.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PyUiCreator.My.Resources.Resources.bottom
        Me.PictureBox2.InitialImage = Global.PyUiCreator.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(-6, 639)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(831, 120)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_FilePath)
        Me.GroupBox3.Controls.Add(Me.txt_WinTitle)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_ClassName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 352)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 221)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Class Properties"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Please Enter UI File Path (Leave Blank of Default)"
        '
        'txt_FilePath
        '
        Me.txt_FilePath.Location = New System.Drawing.Point(16, 181)
        Me.txt_FilePath.Name = "txt_FilePath"
        Me.txt_FilePath.Size = New System.Drawing.Size(352, 20)
        Me.txt_FilePath.TabIndex = 4
        '
        'txt_WinTitle
        '
        Me.txt_WinTitle.Location = New System.Drawing.Point(12, 114)
        Me.txt_WinTitle.Name = "txt_WinTitle"
        Me.txt_WinTitle.Size = New System.Drawing.Size(356, 20)
        Me.txt_WinTitle.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Please Enter Window Title( Leave Blank for Default)"
        '
        'txt_ClassName
        '
        Me.txt_ClassName.Location = New System.Drawing.Point(13, 46)
        Me.txt_ClassName.Name = "txt_ClassName"
        Me.txt_ClassName.Size = New System.Drawing.Size(356, 20)
        Me.txt_ClassName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Please Enter Class Name(Leave Blank for Default)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chk_houStyle)
        Me.GroupBox4.Controls.Add(Me.txt_Size2)
        Me.GroupBox4.Controls.Add(Me.txt_Size1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cmb_pan)
        Me.GroupBox4.Location = New System.Drawing.Point(212, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(186, 163)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "UI Properties"
        '
        'txt_Size2
        '
        Me.txt_Size2.Location = New System.Drawing.Point(88, 58)
        Me.txt_Size2.Name = "txt_Size2"
        Me.txt_Size2.Size = New System.Drawing.Size(70, 20)
        Me.txt_Size2.TabIndex = 4
        Me.txt_Size2.Text = "500"
        '
        'txt_Size1
        '
        Me.txt_Size1.Location = New System.Drawing.Point(12, 57)
        Me.txt_Size1.Name = "txt_Size1"
        Me.txt_Size1.Size = New System.Drawing.Size(70, 20)
        Me.txt_Size1.TabIndex = 3
        Me.txt_Size1.Text = "500"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Size of Window: X:Y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Selected: "
        '
        'cmb_pan
        '
        Me.cmb_pan.FormattingEnabled = True
        Me.cmb_pan.Items.AddRange(New Object() {"Shelf", "Panel"})
        Me.cmb_pan.Location = New System.Drawing.Point(62, 15)
        Me.cmb_pan.Name = "cmb_pan"
        Me.cmb_pan.Size = New System.Drawing.Size(117, 21)
        Me.cmb_pan.TabIndex = 0
        '
        'bttn_Pre
        '
        Me.bttn_Pre.Location = New System.Drawing.Point(405, 581)
        Me.bttn_Pre.Name = "bttn_Pre"
        Me.bttn_Pre.Size = New System.Drawing.Size(402, 52)
        Me.bttn_Pre.TabIndex = 13
        Me.bttn_Pre.Text = "Generate Preview"
        Me.bttn_Pre.UseVisualStyleBackColor = True
        '
        'bttn_toggle
        '
        Me.bttn_toggle.Location = New System.Drawing.Point(300, 13)
        Me.bttn_toggle.Name = "bttn_toggle"
        Me.bttn_toggle.Size = New System.Drawing.Size(98, 23)
        Me.bttn_toggle.TabIndex = 14
        Me.bttn_toggle.Text = "Toggle Preview"
        Me.bttn_toggle.UseVisualStyleBackColor = True
        '
        'txtOut
        '
        Me.txtOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOut.ForeColor = System.Drawing.SystemColors.Window
        Me.txtOut.Location = New System.Drawing.Point(405, 13)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.Size = New System.Drawing.Size(402, 560)
        Me.txtOut.TabIndex = 15
        Me.txtOut.Text = ""
        '
        'chk_houStyle
        '
        Me.chk_houStyle.AutoSize = True
        Me.chk_houStyle.Location = New System.Drawing.Point(12, 88)
        Me.chk_houStyle.Name = "chk_houStyle"
        Me.chk_houStyle.Size = New System.Drawing.Size(146, 17)
        Me.chk_houStyle.TabIndex = 5
        Me.chk_houStyle.Text = "Inherit Houdini Stylesheet"
        Me.chk_houStyle.UseVisualStyleBackColor = True
        '
        'Advanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 683)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.bttn_toggle)
        Me.Controls.Add(Me.bttn_Pre)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bttn_main)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Advanced"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced Framework Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bttn_main As Button
    Friend WithEvents Rdo_Env As RadioButton
    Friend WithEvents Rdo_Man As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_PValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LstBx_QtImports As CheckedListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_ClassName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmb_pan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Size2 As TextBox
    Friend WithEvents txt_Size1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_FilePath As TextBox
    Friend WithEvents txt_WinTitle As TextBox
    Friend WithEvents bttn_Pre As Button
    Friend WithEvents bttn_toggle As Button
    Friend WithEvents txtOut As RichTextBox
    Friend WithEvents chk_houStyle As CheckBox
End Class
