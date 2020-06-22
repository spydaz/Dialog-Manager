Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Xml.Serialization

Namespace AI_Controllers


    Namespace DialogControl





#Region "Dialog Manager"
        Public Class DialogManager
            ''' <summary>
            ''' Current Dialogs
            ''' </summary>
            Public Dialogs As List(Of iDialog)
            ''' <summary>
            ''' Topics that are set into current focus :
            ''' </summary>
            Public CurrentTopicList As List(Of iIntent)
            ''' <summary>
            ''' History of intents and turns : 
            ''' </summary>
            Public History As List(Of iIntent)
            ''' <summary>
            ''' Previous Intent : 
            ''' </summary>
            Public PrevIntent As iIntent
            ''' <summary>
            ''' Current Detected Intent: 
            ''' </summary>
            Public DetectedIntent As iIntent
            ''' <summary>
            ''' Current UserInput
            ''' </summary>
            Public UserInput As String
            ''' <summary>
            ''' Current Response
            ''' </summary>
            Public Response As String
            ''' <summary>
            ''' List of Intents to be held in the class for searching
            ''' </summary>
            Public MasterList As List(Of iIntent)
            ''' <summary>
            ''' Lists of Named Entitys (used as Parameters to be discovered)
            ''' </summary>
            Public EntityLists As List(Of iNamedEntitys)
            ''' <summary>
            ''' Parameters collected 
            ''' </summary>
            Public CollectedParameters As List(Of iEntity)
            ''' <summary>
            ''' Serializes object to json
            ''' </summary>
            ''' <returns> </returns>
            Public Function ToJson() As String
                Dim Converter As New JavaScriptSerializer
                Return Converter.Serialize(Me)
            End Function
            ''' <summary>
            ''' Detects if an intent has been detected from the currently held intents 
            ''' as well as the current topics are tested and compared. 
            ''' </summary>
            ''' <param name="mUserInput"></param>
            ''' <returns></returns>
            Private Function DetectIntent(ByRef mUserInput As String) As Boolean
                'Update internal Userinput
                UserInput = UCase(mUserInput)
                'Temp List
                Dim Detetcted As New List(Of iIntent)
                'Logic
                Dim Found As Boolean = False
                'detect intents
                For Each item In MasterList
                    'Current topic list is also sent 
                    If item.DetectIntent(UCase(mUserInput), CurrentTopicList) = True Then
                        Detetcted.Add(item)
                        Found = True
                        Return Found
                    Else
                    End If
                Next
                Return Found
            End Function
            ''' <summary>
            ''' Gets a list of detected intents
            ''' </summary>
            ''' <param name="mUserInput"></param>
            ''' <returns></returns>
            Private Function GetDetectedIntents(ByRef mUserInput As String) As List(Of iIntent)
                Dim Detected As New List(Of iIntent)
                'detect intents
                For Each item In MasterList
                    If item.DetectIntent(UCase(mUserInput), CurrentTopicList) = True Then
                        Detected.Add(item)
                    End If
                Next
                Return Detected
            End Function
            ''' <summary>
            ''' Reduces lifespan for each Intent in Current Topics Lifespan Should be reduced after each turn
            ''' </summary>
            Private Sub AdjustLifeSpan()
                On Error Resume Next
                Dim Removed As Boolean = False
                If CurrentTopicList.Count > 0 Then
                    For Each item In CurrentTopicList
                        If item.Lifespan = 0 Then
                            CurrentTopicList.Remove(item)
                            Removed = True
                        Else
                        End If
                        If item.Lifespan > 0 And Removed = False Then
                            item.Lifespan -= 1
                        Else
                        End If
                    Next
                Else
                End If
                'Reload
            End Sub
            ''' <summary>
            ''' MainFunction
            ''' </summary>
            ''' <param name="Userinput"></param>
            Public Sub SendQuery(ByRef Userinput As String)
                Me.UserInput = Userinput
                AdjustLifeSpan()
                If DetectIntent(Userinput) = True Then
                    'Searches for the intents Which have been detcted and adds 
                    'them to the list of detected intents
                    Dim DetectedIntents As List(Of iIntent) = GetDetectedIntents(Userinput)
                    'Which intent is correct?
                    'Update Current;
                    Dim DetectedIntent As iIntent = DetectedIntents.GetRandomIntent()
                    Me.DetectedIntent = DetectedIntent
                    'update history
                    History.Add(DetectedIntent)
                    'Update Current topics  (output Topics)
                    For Each itm In DetectedIntent.OutputContext
                        If DetectedIntent.Lifespan > 0 Then CurrentTopicList.Add(itm)
                    Next
                    'update current topic
                    If DetectedIntent.Lifespan > 0 Then CurrentTopicList.Add(DetectedIntent)
                    PrevIntent = History(History.Count - 1)
                    Response = DetectedIntent.ReturnResponse
                    'Collect any paramters detected  (changes response if parameter is unpopulated)
                    CollectParameters()
                Else
                    'Nothing was detected "FallbackIntent"
                    Response = "Could you please re-phrase the question"
                    DetectedIntent = New iIntent With {
                    .IntentName = "Fallback Response"}
                    DetectedIntent.AddTextResponse("Could you please re-phrase the question")
                    DetectedIntent.Lifespan = 1
                End If
            End Sub
            ''' <summary>
            ''' Collects Populated Parameters to Collected Params
            ''' </summary>
            Private Sub CollectParameters()
                'If the intent has parameters collect them
                If DetectedIntent.DetectedParameters.Count > 0 Then
                    For Each Param In DetectedIntent.DetectedParameters
                        If Param.ParameterName IsNot "" Then
                            CollectedParameters.Add(Param)
                        Else
                            'If the parameter is unpopulated then Add a Prompt to the response
                            'And Add the Intent to the Current intents 
                            For Each lst In EntityLists
                                If lst.EntityListName = Param.EntityListName Then
                                    'Nothing was detected "FallbackIntent"
                                    Response = lst.ParameterPrompt
                                    DetectedIntent = New iIntent With {
                    .IntentName = "Parameter Response"}
                                    DetectedIntent.AddTextResponse(lst.ParameterPrompt)
                                    DetectedIntent.Lifespan = 1
                                    DetectedIntent.Lifespan = +2
                                    CurrentTopicList.Add(DetectedIntent)
                                End If
                            Next
                        End If
                    Next
                Else
                End If
            End Sub
            Public Sub New()
                CurrentTopicList = New List(Of iIntent)
                History = New List(Of iIntent)
                MasterList = New List(Of iIntent)
                EntityLists = New List(Of iNamedEntitys)
                CollectedParameters = New List(Of iEntity)
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
                    Dialogs = New List(Of iDialog)
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
        End Class

#End Region



    End Namespace
End Namespace