<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.bttn_barebones = New System.Windows.Forms.Button()
        Me.bttn_qtMod = New System.Windows.Forms.Button()
        Me.bttn_editEnv = New System.Windows.Forms.Button()
        Me.bttn_advanced = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bttn_help = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bttn_last = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttn_barebones
        '
        Me.bttn_barebones.Location = New System.Drawing.Point(12, 210)
        Me.bttn_barebones.Name = "bttn_barebones"
        Me.bttn_barebones.Size = New System.Drawing.Size(300, 46)
        Me.bttn_barebones.TabIndex = 0
        Me.bttn_barebones.Text = "Export Barebones Basic Framework"
        Me.bttn_barebones.UseVisualStyleBackColor = True
        '
        'bttn_qtMod
        '
        Me.bttn_qtMod.Location = New System.Drawing.Point(12, 314)
        Me.bttn_qtMod.Name = "bttn_qtMod"
        Me.bttn_qtMod.Size = New System.Drawing.Size(300, 46)
        Me.bttn_qtMod.TabIndex = 2
        Me.bttn_qtMod.Text = "Dump Qt Module"
        Me.bttn_qtMod.UseVisualStyleBackColor = True
        '
        'bttn_editEnv
        '
        Me.bttn_editEnv.Location = New System.Drawing.Point(12, 366)
        Me.bttn_editEnv.Name = "bttn_editEnv"
        Me.bttn_editEnv.Size = New System.Drawing.Size(300, 46)
        Me.bttn_editEnv.TabIndex = 3
        Me.bttn_editEnv.Text = "Edit DCC Enviroment Variable"
        Me.bttn_editEnv.UseVisualStyleBackColor = True
        '
        'bttn_advanced
        '
        Me.bttn_advanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn_advanced.Location = New System.Drawing.Point(12, 262)
        Me.bttn_advanced.Name = "bttn_advanced"
        Me.bttn_advanced.Size = New System.Drawing.Size(300, 46)
        Me.bttn_advanced.TabIndex = 4
        Me.bttn_advanced.Text = "Export Advanced Framework"
        Me.bttn_advanced.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PyUiCreator.My.Resources.Resources.logo
        Me.PictureBox1.InitialImage = Global.PyUiCreator.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 120)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'bttn_help
        '
        Me.bttn_help.Location = New System.Drawing.Point(12, 136)
        Me.bttn_help.Name = "bttn_help"
        Me.bttn_help.Size = New System.Drawing.Size(299, 46)
        Me.bttn_help.TabIndex = 5
        Me.bttn_help.Text = "Click me for Help?"
        Me.bttn_help.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PyUiCreator.My.Resources.Resources.bottom
        Me.PictureBox2.InitialImage = Global.PyUiCreator.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 526)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(330, 110)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'bttn_last
        '
        Me.bttn_last.Enabled = False
        Me.bttn_last.Location = New System.Drawing.Point(13, 470)
        Me.bttn_last.Name = "bttn_last"
        Me.bttn_last.Size = New System.Drawing.Size(300, 46)
        Me.bttn_last.TabIndex = 7
        Me.bttn_last.Text = "_Debug Mode"
        Me.bttn_last.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(97, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PyQt Code Generator V0.51"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 569)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttn_last)
        Me.Controls.Add(Me.bttn_help)
        Me.Controls.Add(Me.bttn_advanced)
        Me.Controls.Add(Me.bttn_editEnv)
        Me.Controls.Add(Me.bttn_qtMod)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bttn_barebones)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PyQt UI Gen Tools (V.0.5)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttn_barebones As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bttn_qtMod As Button
    Friend WithEvents bttn_editEnv As Button
    Friend WithEvents bttn_advanced As Button
    Friend WithEvents bttn_help As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents bttn_last As Button
    Friend WithEvents Label1 As Label
End Class
