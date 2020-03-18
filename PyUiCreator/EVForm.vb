Imports System.IO

Public Class EVForm
    Public StrArr As String() = {"houdini16.0", "houdini16.5", "houdini17.0", "houdini17.5", "houdini18.0"}
    Dim ManPath As String = ""

    Private Sub bttn_HouAuto_Click(sender As Object, e As EventArgs) Handles bttn_HouAuto.Click
        'Init
        ManPath = ""
        cmb_found.Items.Clear()
        cmb_found.SelectedIndex = -1
        txtManO.Text = ""
        bttn_ManOpen.Enabled = False
        lblLoc.Text = ""
        bttn_Find.Enabled = False
        txt_VarIn.Enabled = False
        txt_VarIn.Text = ""
        txtVarD.Enabled = False
        txtVarD.Text = ""


        For i = 0 To UBound(StrArr)
            If Directory.Exists((My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\" + StrArr(i))) Then
                If File.Exists((My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\" + StrArr(i) + "\houdini.env")) Then
                    cmb_found.Items.Add(StrArr(i))
                End If
            End If
        Next

        If cmb_found.Items.Count = 0 Then
            'No Files/Folders Found within search range in docs.
            MsgBox("Could not Locate any Houdini Files/Folders in Default Install Location. Please Try Manually Loading the File.")
        Else
            'Enable Button
            bttn_setVersion.Enabled = True
            cmb_found.SelectedIndex = 0
        End If

    End Sub

    Private Sub bttn_ManualHou_Click(sender As Object, e As EventArgs) Handles bttn_ManualHou.Click
        'Init
        ManPath = ""
        bttn_setVersion.Enabled = False
        cmb_found.Items.Clear()
        cmb_found.SelectedIndex = -1
        txtManO.Text = ""
        lblLoc.Text = ""
        bttn_Find.Enabled = False
        txt_VarIn.Enabled = False
        txt_VarIn.Text = ""
        txtVarD.Enabled = False
        txtVarD.Text = ""

        'FilePath
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Locate Target Enviroment File"
        fd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        fd.Filter = "Houdini Enviroment File|houdini.env|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            txtManO.Text = strFileName
            ManPath = strFileName
            bttn_ManOpen.Enabled = True
        End If
    End Sub

    Private Sub EVForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoc.Text = ""
    End Sub

    Private Sub bttn_setVersion_Click(sender As Object, e As EventArgs) Handles bttn_setVersion.Click
        'Get File Location from combobox
        lblLoc.Text = (My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\" + cmb_found.Text + "\" + "houdini.env")
        bttn_Find.Enabled = True
        txt_VarIn.Enabled = True
        txtVarD.Enabled = True
    End Sub

    Private Sub bttn_ManOpen_Click(sender As Object, e As EventArgs) Handles bttn_ManOpen.Click
        'Set File Location Label to selection
        lblLoc.Text = ManPath
        bttn_Find.Enabled = True
        txt_VarIn.Enabled = True
        txtVarD.Enabled = True
    End Sub

    Public Sub AddVar(path, varT)
        'OpenFile Then Find Variable located
        Dim fPath = path
        Try
            Dim fi As New IO.FileInfo(fPath)
            Dim exists As Boolean = fi.Exists
            Dim IsReadOnly As Boolean = fi.IsReadOnly

            If exists = True Then
                If IsReadOnly = False Then
                    'Openfile
                    Dim fileO As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(lblLoc.Text)
                    Dim VarFound = False
                    Dim RLine As String
                    'Search file till end of stream for matching var
                    Do Until fileO.EndOfStream Or VarFound = True
                        RLine = fileO.ReadLine()
                        'Checkif RLine has the chosen variable
                        If RLine <> Nothing Then
                            If Microsoft.VisualBasic.Left(RLine, Len(varT)) = varT Then
                                'Set Var Found to True
                                MsgBox("Variable Already exists, Please try another variable")
                                VarFound = True
                            End If
                        End If
                    Loop
                    fileO.Close()
                    'Write Block
                    If VarFound = False Then
                        Dim fileW As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(lblLoc.Text, True)
                        'Write Empty Line then Comment then Var
                        fileW.WriteLine("")
                        fileW.WriteLine("#This Path Points to the PYUI Variable (Added by PYUI Creator)")
                        fileW.WriteLine(txt_VarIn.Text + " = " + Chr(34) + txtVarD.Text + Chr(34))
                        fileW.Close()
                        'Clear Boxes
                        txt_VarIn.Text = ""
                        txtVarD.Text = ""
                        MsgBox("Variable Successfully Written!")
                    End If
                Else
                        MsgBox("Error: Target File Flagged as Is Read Only.")
                End If
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub bttn_Find_Click(sender As Object, e As EventArgs) Handles bttn_Find.Click
        If txt_VarIn.Text <> Nothing And txtVarD.Text <> Nothing Then
            Call AddVar(lblLoc.Text, txt_VarIn.Text)
        Else
            MsgBox("Variable to Find cannot be Blank!")
        End If

    End Sub
End Class