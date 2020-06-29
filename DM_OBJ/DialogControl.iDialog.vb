Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Xml.Serialization


Namespace AI_Controllers
    Namespace DialogControl

        ''' <summary>
        ''' Individual Dialog containing Intents and EntityLists
        ''' </summary>
        ''' <remarks>Individual Dailogs should be single focused ; Such as a Customer care bot;  it may even be prudent ; to Sub catogrise tasks to sub dialogs</remarks>
        <Serializable()>
        Public Class iDialog
#Region "Standard Parameters"
            ''' <summary>
            ''' Holds the current context in the dialog
            ''' </summary>
            Public CurrentContext As New List(Of iIntent)
            ''' <summary>
            ''' Intents held by the Dialog
            ''' </summary>
            Public AvailableIntents As List(Of iIntent)
            ''' <summary>
            ''' Associated Entity Lists Used for Parameter identification for the contained intents 
            ''' </summary>
            Public AvailableEntityLists As List(Of iNamedEntitys)
            ''' <summary>
            ''' Name identifier of Dialog
            ''' </summary>
            Public DialogName As String
            ''' <summary>
            ''' The required parameters required to fulfil the outcome of the dialog 
            ''' ie: book a ticket : REQ : TICKETNUMBER / NAME / DATE / ETC
            ''' </summary>
            Public REQUIRED_PARAMETERS As New List(Of iEntity)
            ''' <summary>
            ''' The parameters which have been captured by the intents
            ''' </summary>
            Private CURRENT_DETECTED_PARAMETERS As New List(Of iEntity)
            ''' <summary>
            ''' number of detected paramters dtetcted by the dialog
            ''' </summary>
            ''' <returns></returns>
            Public ReadOnly Property NoOfDetectedParameters As Integer
                Get
                    If CURRENT_DETECTED_PARAMETERS IsNot Nothing Then
                        Return CURRENT_DETECTED_PARAMETERS.Count
                    Else
                        Return 0
                    End If
                End Get
            End Property

            ''' <summary>
            ''' Number of required parameters before fulfilment can take place
            ''' </summary>
            ''' <returns></returns>
            Public ReadOnly Property NoOfRequiredParameters As Integer
                Get
                    If REQUIRED_PARAMETERS IsNot Nothing Then
                        Return REQUIRED_PARAMETERS.Count
                    Else
                        Return 0
                    End If
                End Get
            End Property

#End Region
            ''' <summary>
            ''' Name of Dialog Must be SET
            ''' Individual Dialog containing Intents and EntityLists
            ''' </summary>
            ''' <param name="iName"></param>
            ''' <remarks>Individual Dailogs should be single focused ; Such as a Customer care bot;  it may even be prudent ; to Sub catogrise tasks to sub dialogs</remarks>
            Public Sub New(ByRef iName As String)
                DialogName = UCase(iName)
                AvailableEntityLists = New List(Of iNamedEntitys)
                AvailableIntents = New List(Of iIntent)
            End Sub
            Public Sub New()
                AvailableEntityLists = New List(Of iNamedEntitys)
                AvailableIntents = New List(Of iIntent)
            End Sub
#Region "Evaluate"
            ''' <summary>
            ''' Reduces lifespan for each Intent in Current Topics Lifespan 
            ''' Should be reduced after each turn response
            ''' </summary>
            Private Sub AdjustLifeSpan()
                On Error Resume Next
                Dim Removed As Boolean = False
                If CurrentContext.Count > 0 Then
                    For Each item In CurrentContext
                        If item.Lifespan = 0 Then
                            CurrentContext.Remove(item)
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
            'Responses : Replacements Need to be checked by checking the Stored Entity lists: 
            ': Response Strategy required
            ' : 


#End Region
#Region "Export"
            ''' <summary>
            ''' Serializes object to json
            ''' </summary>
            ''' <returns> </returns>
            Public Function ToJson() As String
                Dim Converter As New JavaScriptSerializer
                Return Converter.Serialize(Me)
            End Function
            ''' <summary>
            ''' Serializes Object to XML
            ''' </summary>
            ''' <param name="FileName"></param>
            Public Sub ToXML(ByRef FileName As String)
                Dim serialWriter As StreamWriter
                serialWriter = New StreamWriter(FileName)
                Dim xmlWriter As New XmlSerializer(Me.GetType())
                xmlWriter.Serialize(serialWriter, Me)
                serialWriter.Close()
            End Sub

            ''' <summary>
            ''' deserialize object from Json
            ''' </summary>
            ''' <param name="Str">json</param>
            ''' <returns></returns>
            Public Shared Function FromJson(ByRef Str As String) As iDialog
                Try
                    Dim Converter As New JavaScriptSerializer

                    Dim diag As iDialog = Converter.Deserialize(Of iDialog)(Str)
                    Return diag
                Catch ex As Exception
                    Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                    MessageBox.Show(ex.Message, "ERROR", Buttons)
                End Try
                Return Nothing
            End Function
            ''' <summary>
            ''' deserialize object from Json
            ''' </summary>
            ''' <param name="Str">json</param>
            ''' <returns></returns>
            Public Shared Function ListFromJson(ByRef Str As String) As List(Of iDialog)
                Try
                    Dim Converter As New JavaScriptSerializer
                    Dim diag As List(Of iDialog) = Converter.Deserialize(Of List(Of iDialog))(Str)
                    Return diag
                Catch ex As Exception
                    Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                    MessageBox.Show(ex.Message, "ERROR", Buttons)
                End Try
                Return Nothing
            End Function
#End Region


            ''' <summary>
            ''' Gets a response from current dialog / Responses and detections are held in the (AVAILABLEINTENTS)
            ''' Reponse genrated by the triggered intent will determine the response from the dialog
            '''  A Fallback Response will only be returned if there is current context. 
            '''  Each Search triggers a turn; 
            '''  The lifespan for items held in the current context are automatically adjusted each turn
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
                For Each ItemIntent In AvailableIntents
                    If ItemIntent.DetectIntent(UCase(UserInput), CurrentContext) = True Then
                        'DETECTED
                        GetResponse = True

                        '1st. Response is returned from Intent
                        Response = ItemIntent.ReturnResponse()

                        'CHECK PARAMETERS:
                        If ItemIntent.NoOfReqParameters > 0 Then
                            'ADD DETECTED
                            REQUIRED_PARAMETERS.AddRange(ItemIntent.DetectedParameters)
                        Else
                            'No Parameters are required
                        End If

                        'ADD CONTEXT
                        If ItemIntent.OutputContext.Count > 0 Then
                            CurrentContext.AddRange(ItemIntent.OutputContext)
                        Else
                            'No output context
                        End If

                        'CHECK ACTIONS:
                        If ItemIntent.Actions.Count > 0 Then
                            '2nd Response is returned from Action
                            Response = ItemIntent.ExecuteActions()
                        Else
                            'No Actions
                        End If

                    Else
                        'INTENT NOT DETECTED
                    End If
                Next

                'Adjust LifeSpan; Current COntext items lifespans are reduced (ie: Turn based)
                If CurrentContext.Count > 0 Then
                    AdjustLifeSpan()
                Else
                    'No Current Context
                End If
            End Function
        End Class

    End Namespace
End Namespace