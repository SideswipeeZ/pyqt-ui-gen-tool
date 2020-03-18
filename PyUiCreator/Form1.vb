Public Class MainWindow
    Public imgB As Boolean = False
    Public Counter As Integer = 0

    Public Shared Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttn_barebones_Click(sender As Object, e As EventArgs) Handles bttn_barebones.Click
        'Dump barebones.py file to disk
        Using sfd As New SaveFileDialog
            With sfd
                .AddExtension = True
                .DefaultExt = ".py"
                .Filter = "Python Code File (*.py)|*.py"
                .FilterIndex = 1
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Select The Location To Save The File"
                .ValidateNames = True
            End With

            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim b As Byte() = My.Resources.barebones
                My.Computer.FileSystem.WriteAllBytes(sfd.FileName, b, False)
            End If
        End Using
    End Sub

    Private Sub bttn_qtMod_Click(sender As Object, e As EventArgs) Handles bttn_qtMod.Click
        'Dump Qt.pyc File to Disk
        Using sfd As New SaveFileDialog
            With sfd
                .AddExtension = True
                .DefaultExt = ".pyc"
                .Filter = "Python Complied File (*.pyc)|*.pyc"
                .FilterIndex = 1
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Select The Location To Export Qt Module"
                .ValidateNames = True
            End With

            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim b As Byte() = My.Resources.Qt
                My.Computer.FileSystem.WriteAllBytes(sfd.FileName, b, False)
            End If
        End Using
    End Sub

    Private Sub bttn_editEnv_Click(sender As Object, e As EventArgs) Handles bttn_editEnv.Click
        'Add enviroment variable. Open Form.
        EVForm.Show()
    End Sub

    Private Sub bttn_help_Click(sender As Object, e As EventArgs) Handles bttn_help.Click
        'Help Button
        MsgBox("This Program creates a Python File with Code that is compatible with Qt for DCC application that support Python Scripting.

Barebones will Export a Python File with the bare minimum code required to run the script.

Advanced Will allow the creation of a more finely tuned code file.

You can also dump the Qt.pyc module from this program to a location of your choice.

Can also edit enviroment files from the menu for Houdini and/or (WIP)Maya.")
    End Sub

    Private Sub bttn_advanced_Click(sender As Object, e As EventArgs) Handles bttn_advanced.Click
        'Open Advanced Form Load
        Advanced.Show()
    End Sub

    Private Sub bttn_last_Click(sender As Object, e As EventArgs) Handles bttn_last.Click
        'Debug Mode
        MsgBox("There is no Debug Mode LOL")
    End Sub

    Public Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Change UI Image.
        If imgB = False Then
            PictureBox1.Image = My.Resources.logo2
            imgB = True
        ElseIf imgB = True Then
            PictureBox1.Image = My.Resources.logo
            imgB = False
        End If
        If Counter < 20 Then
            Counter = Counter + 1
        End If
        If Counter = 20 Then
            Call Deb()
        End If
    End Sub
    Public Sub Deb()
        bttn_last.Enabled = True

    End Sub

End Class
