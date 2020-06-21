Imports System.IO

Imports System.Xml.Serialization

Namespace AI_Controllers


    Namespace DialogControl
        ''' <summary>
        ''' Used To Create and Manage Dialogs
        ''' </summary>
        Public Class DialogManager
            Public Dialogs As List(Of iDialog)
            Public CurrentDialog As iDialog
            Public CurrentResponse As String = ""
            Public Sub New()
                Dialogs = New List(Of iDialog)
            End Sub
#Region "Export"
            Public Shared Sub ExportDialog(ByRef Diag As iDialog, ByRef FilePath As String)
                Try
                    My.Computer.FileSystem.WriteAllText(FilePath & "\" & Diag.DialogName & ".Json", Diag.ToJson(), True)
                Catch ex As Exception
                    Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                    MessageBox.Show(ex.Message, "ERROR", Buttons)
                End Try
            End Sub
            Public Shared Sub ExportDialog(ByRef Diag As iDialog)
                Try
                    My.Computer.FileSystem.WriteAllText("\Dialogs\" & Diag.DialogName & ".Json", Diag.ToJson(), True)
                Catch ex As Exception
                    Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                    MessageBox.Show(ex.Message, "ERROR", Buttons)
                End Try
            End Sub

            Public Sub ExportDialogs()
                Try
                    For Each item In Dialogs
                        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Dialogs\" & item.DialogName & ".Json", item.ToJson(), True)
                    Next

                Catch ex As Exception
                    Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                    MessageBox.Show(ex.Message, "ERROR", Buttons)
                End Try
            End Sub
            Public Shared Sub ExportDialogs(ByRef AvailableDialogs As List(Of iDialog), ByRef FilePath As String)
                Try
                    For Each Diag In AvailableDialogs
                        My.Computer.FileSystem.WriteAllText(FilePath & "\" & Diag.DialogName & ".Json", Diag.ToJson(), True)
                    Next
                Catch ex As Exception
                    Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                    MessageBox.Show(ex.Message, "ERROR", Buttons)
                End Try
            End Sub

            Public Shared Sub ExportNamedEntity(ByRef NamedEntitys As iNamedEntitys, ByRef FilePath As String)
                My.Computer.FileSystem.WriteAllText(FilePath & "\" & NamedEntitys.EntityListName & ".Json", NamedEntitys.ToJson, True)
            End Sub
            Public Sub ExportNamedEntity(ByRef NamedEntitys As iNamedEntitys)
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\EntityLists\" & NamedEntitys.EntityListName & ".Json", NamedEntitys.ToJson, True)
            End Sub

            Public Sub ExportNamedEntitys(ByRef NamedEntitys As List(Of iNamedEntitys))
                If NamedEntitys IsNot Nothing Then
                    For Each item In NamedEntitys
                        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\EntityLists\" & item.EntityListName & ".Json", item.ToJson, True)
                    Next
                End If
            End Sub
            Public Shared Sub ExportNamedEntitys(ByRef NamedEntitys As List(Of iNamedEntitys), ByRef FilePath As String)
                If NamedEntitys IsNot Nothing Then
                    For Each item In NamedEntitys
                        My.Computer.FileSystem.WriteAllText(FilePath & "\" & item.EntityListName & ".Json", item.ToJson, True)
                    Next
                End If
            End Sub

            Public Sub ExportIntent(ByRef Intent As iIntent)
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Intents\" & Intent.IntentName & ".Json", Intent.ToJson, True)
            End Sub
            Public Sub ExportIntent(ByRef Intents As List(Of iIntent))
                If Intents IsNot Nothing Then
                    For Each intent In Intents
                        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Intents\" & intent.IntentName & ".Json", intent.ToJson, True)
                    Next
                End If
            End Sub
#End Region
#Region "Import"
            ''' <summary>
            '''  Imports dialogs From Json Files to class from Folder App.Path\Dialogs
            ''' </summary>
            Public Sub ImportDialogs()
                On Error Resume Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Dialogs\", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.Json")
                    Dim Str = My.Computer.FileSystem.ReadAllText(foundFile)
                    Dim diag As iDialog = iDialog.FromJson(Str)
                    Dialogs.Add(diag)
                Next
            End Sub
            ''' <summary>
            ''' Imports dialogs From Json Files to class from Given FilePath (Files Must have Ext *.Json) 
            ''' searches for json and attempts to retrive dialog
            ''' </summary>
            ''' <param name="Pathname"></param>
            ''' <returns></returns>
            Public Shared Function ImportDialogs(ByRef Pathname As String) As List(Of iDialog)
                Dim AvailableDialogs As New List(Of iDialog)
                On Error Resume Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Pathname, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.Json")
                    Dim Str = My.Computer.FileSystem.ReadAllText(foundFile)
                    Dim diag As iDialog = iDialog.FromJson(Str)
                    AvailableDialogs.Add(diag)
                Next
                Return AvailableDialogs
            End Function
            ''' <summary>
            '''  Imports dialogs From Json Files to class from text
            ''' </summary>
            ''' <param name="JsonFileText"></param>
            ''' <returns></returns>       
            Public Shared Function ImportDialog(ByRef JsonFileText As String) As iDialog
                Try
                    Dim Str As String = JsonFileText
                    Dim diag As iDialog = iDialog.FromJson(Str)
                    Return diag
                Catch ex As Exception
                    Return Nothing
                End Try
            End Function
#End Region

#Region "Response Generation"
            ''' <summary>
            ''' Checks current held dialogs for response
            ''' </summary>
            ''' <param name="UserInput">Input from User; Data held in the intents and entoitys should be held as UpperCase
            ''' The UserInput will be searched in Upper case ; 
            ''' If the Data stared in the intents and entitys are Lower case they may not be recognized</param>
            ''' <param name="Response">Generated response</param>
            ''' <returns>IF False is returned then there is No current context Held in the dialog, Dialog state is in START MODE, 
            ''' If true is returned the dialog states are updated, and a response has been populated een if it is a fallback response
            ''' A Fallback Response will only be returned if there is current context. </returns>
            Public Function GetResponse(ByRef UserInput As String, ByRef Response As String) As Boolean
                GetResponse = False
                'Check Dialogs / Check is Current dialog is Active
                If CurrentDialog IsNot Nothing Then
                    'return from current
                    If CurrentDialog.GetResponse(UserInput, Response) = True Then
                        'Check Current Dialog
                        If CurrentDialog.CurrentContext.Count < 1 Then
                            'Current dialog is complete
                            CurrentDialog = Nothing
                        Else
                            'Current dialog Still in play
                        End If
                        Return True
                    Else
                        Return False
                    End If
                Else
                    'check dialogs (no current)
                    For Each ItemDialog In Dialogs
                        'Detect Response
                        If ItemDialog.GetResponse(UserInput, Response) = True Then
                            'Detected
                            GetResponse = True
                            'set dialog
                            CurrentDialog = ItemDialog
                            Return GetResponse
                        Else
                            'no response detected
                        End If
                    Next
                End If
            End Function
            ''' <summary>
            ''' Returns Response from Dialog
            ''' </summary>
            ''' <param name="Dialog">Given dialog</param>
            ''' <param name="UserInput">Input from User; Data held in the intents and entoitys should be held as UpperCase
            ''' The UserInput will be searched in Upper case ; 
            ''' If the Data stared in the intents and entitys are Lower case they may not be recognized</param>
            ''' <param name="Response">Generated response</param>
            ''' <returns>IF False is returned then there is No current context Held in the dialog, Dialog state is in START MODE, 
            ''' If true is returned the dialog states are updated, and a response has been populated een if it is a fallback response
            ''' A Fallback Response will only be returned if there is current context. </returns>
            Private Function GetResponse(ByRef Dialog As iDialog, ByRef UserInput As String, ByRef Response As String) As Boolean
                Return Dialog.GetResponse(UserInput, Response)
            End Function
#End Region

        End Class
    End Namespace
End Namespace