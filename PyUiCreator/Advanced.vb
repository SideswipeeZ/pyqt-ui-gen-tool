Public Class Advanced

    Public Shared Sub Advanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the Value to the First Item by Default.
        Advanced.txtOut.Text = ""
        Advanced.cmb_pan.SelectedIndex = 0
        Advanced.Size = New Size(419, 722)
    End Sub

    Public Shared Sub bttn_main_Click(sender As Object, e As EventArgs) Handles bttn_main.Click
        'Create File to Export
        Using sfd As New SaveFileDialog
            With sfd
                .AddExtension = True
                .DefaultExt = ".py"
                .Filter = "Python File (*.py)|*.py"
                .FilterIndex = 1
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Select The Location To Export Python File"
                .ValidateNames = True
            End With

            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim b As Byte() = Advanced.gatherData()
                Advanced.txtOut.Text = System.Text.Encoding.UTF8.GetString(b)
                My.Computer.FileSystem.WriteAllBytes(sfd.FileName, b, False)
            End If
        End Using
        'Advanced.Close()
    End Sub
    'Loads All Variables to Write to File.
    Public Function gatherData()
        Dim finalAll As String = ""

        'Write Comments First
        Dim CommentStr As String = System.Text.Encoding.UTF8.GetString(My.Resources.Comment)
        finalAll = finalAll + CommentStr


        'Write Normal Imports
        Dim normImp As String = "import os, sys" & vbCrLf
        finalAll = finalAll + normImp + vbCrLf


        'Write Qt Module Import
        If Rdo_Env.Checked = True And Rdo_Man.Checked = False Then
            'Enviroment String Here
            If txt_PValue.Text = Nothing Then
                finalAll = finalAll + "#Checks Houdini Enviroment for the variable PYUI and loads the path from it." + vbCrLf + "(lambda __g: [(sys.path.insert(0, str(ui_l)), None)[1] for __g['ui_l'] in [(hou.getenv('PYUI'))]][0])(globals())" + vbCrLf
            Else
                finalAll = finalAll + "#Checks Houdini Enviroment for the variable " + txt_PValue.Text + " and loads the path from it." + vbCrLf + "(lambda __g: [(sys.path.insert(0, str(ui_l)), None)[1] for __g['ui_l'] in [(hou.getenv('" + txt_PValue.Text + "'))]][0])(globals())" + vbCrLf
            End If

        ElseIf Rdo_Env.Checked = False And Rdo_Man.Checked = True Then
            'Manual Strings here
            If txt_PValue.Text = Nothing Then
                finalAll = finalAll + "#Point this Path to the Qt.py" + vbCrLf + "sys.path.insert(0,(" + "PATH_GOES_HERE" + "))" + vbCrLf
            Else
                finalAll = finalAll + "#Point this Path to the Qt.py" + vbCrLf + "sys.path.insert(0,(" + txt_PValue.Text + "))" + vbCrLf
            End If
        End If
        finalAll = finalAll + vbCrLf + vbCrLf


        'import From Qt.
        finalAll = finalAll + "#Qt Import Block " + vbCrLf
        Dim qtImports As String = "from Qt import QtCore, QtWidgets, QtCompat "
        For Each item In LstBx_QtImports.CheckedItems
            qtImports = qtImports + ", " + item + " "
        Next
        qtImports = qtImports + vbCrLf
        finalAll = finalAll + qtImports + vbCrLf


        'Import Class File
        finalAll = finalAll + "#Class Creation" + vbCrLf
        Dim classname As String
        If txt_ClassName.Text = Nothing Then
            classname = "class MyWindow(QtWidgets.QMainWindow):"
        Else
            classname = "class " + txt_ClassName.Text + "(QtWidgets.QMainWindow):"
        End If
        finalAll = finalAll + classname + vbCrLf
        'Load Init from File
        Dim wholeClass = System.Text.Encoding.UTF8.GetString(My.Resources.classinit)
        'Replace Class Name if entered
        If txt_ClassName.Text <> Nothing Then
            wholeClass = Replace(wholeClass, "MyWindow", txt_ClassName.Text)
        End If
        'Replace WinTitle If Entered
        If txt_WinTitle.Text <> Nothing Then
            wholeClass = Replace(wholeClass, "TITLE_HERE", txt_WinTitle.Text)
        End If
        'Replace Path If Entered
        If txt_FilePath.Text <> Nothing Then
            wholeClass = Replace(wholeClass, "PATH_HERE", txt_FilePath.Text)
        End If
        finalAll = finalAll + wholeClass + vbCrLf + vbCrLf


        'Load Interface Creation
        'Check if panel or not
        If cmb_pan.Text = "Shelf" Then
            finalAll = finalAll + "isPanel = False" + vbCrLf
        ElseIf cmb_pan.Text = "Panel" Then
            finalAll = finalAll + "isPanel = True" + vbCrLf
        End If
        'Check if classname exists
        Dim panCreate = System.Text.Encoding.UTF8.GetString(My.Resources.CreateInt)
        If txt_ClassName.Text <> Nothing Then
            panCreate = Replace(panCreate, "MyWindow", txt_ClassName.Text)
        End If
        'Replace WindowSize
        Dim SizeX, SizeY As Int32
        If txt_Size1.Text = Nothing Then
            SizeX = 500
        Else
            SizeX = Convert.ToInt32(txt_Size1.Text)
        End If

        If txt_Size2.Text = Nothing Then
            SizeY = 500
        Else
            SizeY = Convert.ToInt32(txt_Size2.Text)
        End If

        panCreate = Replace(panCreate, "SizeX", SizeX)
        panCreate = Replace(panCreate, "SizeY", SizeY)

        finalAll = finalAll + panCreate + vbCrLf

        'Convert to Bytes
        Dim finalBytes = System.Text.Encoding.Default.GetBytes(finalAll)
        Return finalBytes
    End Function

    'Prevent Illegal Characters in Int Text Boxes
    Private Sub Numb1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Size1.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Numb2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Size2.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    'Create the code to display in preview
    Private Sub bttn_Pre_Click(sender As Object, e As EventArgs) Handles bttn_Pre.Click
        Dim p As Byte() = Me.gatherData()
        Dim p1 As String = Replace(System.Text.Encoding.UTF8.GetString(p), System.Text.Encoding.UTF8.GetString(My.Resources.Comment), "")
        Me.txtOut.Text = p1
    End Sub

    Private Sub bttn_toggle_Click(sender As Object, e As EventArgs) Handles bttn_toggle.Click
        If Width < 828 Then
            Size = New Size(828, 722)
        Else
            Size = New Size(419, 722)
        End If
    End Sub

End Class