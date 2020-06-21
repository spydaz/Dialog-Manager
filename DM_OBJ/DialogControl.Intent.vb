Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Xml.Serialization
Imports MSScriptControl

Namespace AI_Controllers
    Namespace DialogControl
        ''' <summary>
        ''' An intent categorizes an end-user's intention for one conversation turn. For each agent, you
        ''' define many intents, where your combined intents can handle a complete conversation. When an
        ''' end-user writes or says something, referred to as an end-user expression.
        '''
        ''' For example, you could create a weather agent that recognizes and responds to end-user
        ''' questions about the weather. You would likely define an intent for questions about the
        ''' weather forecast. If an end-user says "What's the forecast?", the system would match that
        ''' end-user expression to the forecast intent.
        '''
        ''' Additionally: Individual Intents Used to detect the user Purpose A Conversation Can be said
        ''' to be a series of intents Intents Contain Responses/Actions A Collection of intents can be
        ''' iterated Check DetectionOfIntent then Response Or Action can be taken Response could be a
        ''' further Question Which leads to another Intent To Intent Manager will check the previous
        ''' Intent to see if It has been fulfilled =&gt; the follow up intent needs to have a refference
        ''' to the previous intent . The historical responses and inputs can be reffered to by intent name
        ''' NOTE: 
        ''' 1.  DETECT INTENT
        ''' 2. IF ISFULFILMENT  
        ''' A: THEN   : RESPOND ACTION 
        ''' B:  ELSE    : RESPOND INTENT
        ''' </summary>
        <Serializable()>
        Public Class iIntent
#Region "Parameters"
            Private iGenerateOutputContext As Boolean = False
            ''' <summary>
            ''' If Intent is being used to get input from the user 
            ''' an intent can be generated as an output context item
            ''' collected by the intent
            ''' </summary>
            ''' <returns></returns>
            Public Property GenerateOutputContext As Boolean
                Get
                    Return iGenerateOutputContext
                End Get
                Set(value As Boolean)
                    iGenerateOutputContext = value
                End Set
            End Property
            ''' <summary>
            ''' PreRequisites for intent: 
            ''' 
            ''' These are Used to understand Previous Context required by the Intent
            ''' Such as User has Responded to a direct question; Or 
            ''' previously made a request Or 
            ''' Previously provided Entity data
            ''' 
            ''' Previously passed data is held in the output context of the inputcontext passed
            ''' Here the intents required have detected parameters  attached 
            ''' which also may need to be passed forwards until fulfilment
            ''' 
            ''' If populated The input Context items will be replaced by the CurrentContext passed from the DialogController
            ''' 
            ''' Context for intent: Using contexts, you can control the flow of a conversation. You can
            ''' configure contexts for an intent by setting input and output contexts, which are
            ''' identified by string names.
            '''
            ''' For instance: Two Intents May have the Same Trigger Words Such as YES... The question
            ''' now is Which intent Is the Yes Pertaining Too? The input Marker can be used to Denote
            ''' the Context of the Intent : IE: INPUT = MoviesRequest =&gt; YES The YES: Intent Contains
            ''' InputMoviesRequest. The data ie the movie could be Contained within the MoviesRequest
            ''' Intent which now can be retrieved by the YesMoviesRequest Intent Each Intent which had
            ''' simular triggers or were POTENTIAL YES intents: the Current Held Intent Would be
            ''' compared to the input Context If a Match Found then this would be the Selcted Correct
            ''' Intent to Respond From:
            ''' </summary>
            Public ReadOnly Property InputContext As List(Of iIntent)
                Get
                    Return iInputContext
                End Get
            End Property
            ''' <summary>
            ''' Output collected to be passed to next CurrentContext If intent is triggered: 
            ''' the intent may pass itself populated with detected parameters . 
            ''' Or dynamically create and intent to pass such as "ASK QUESTION" or a FollowUP INTENT
            ''' </summary>
            Public ReadOnly Property OutputContext As List(Of iIntent)
                Get
                    Return iOutputContext
                End Get
            End Property
            ''' <summary>
            ''' PreRequisites for intent: 
            ''' 
            ''' These are Used to understand Previous Context required by the Intent
            ''' Such as User has Responded to a direct question; Or 
            ''' previously made a request Or 
            ''' Previously provided Entity data
            ''' 
            ''' Previously passed data is held in the output context of the inputcontext passed
            ''' Here the intents required have detected parameters  attached 
            ''' which also may need to be passed forwards until fulfilment
            ''' 
            ''' If populated The input Context items will be replaced by the CurrentContext passed from the DialogController
            ''' 
            ''' Context for intent: Using contexts, you can control the flow of a conversation. You can
            ''' configure contexts for an intent by setting input and output contexts, which are
            ''' identified by string names.
            '''
            ''' For instance: Two Intents May have the Same Trigger Words Such as YES... The question
            ''' now is Which intent Is the Yes Pertaining Too? The input Marker can be used to Denote
            ''' the Context of the Intent : IE: INPUT = MoviesRequest =&gt; YES The YES: Intent Contains
            ''' InputMoviesRequest. The data ie the movie could be Contained within the MoviesRequest
            ''' Intent which now can be retrieved by the YesMoviesRequest Intent Each Intent which had
            ''' simular triggers or were POTENTIAL YES intents: the Current Held Intent Would be
            ''' compared to the input Context If a Match Found then this would be the Selcted Correct
            ''' Intent to Respond From:
            ''' </summary>
            Private iInputContext As New List(Of iIntent)
            ''' <summary>
            ''' Output collected to be passed to next CurrentContext If intent is triggered: 
            ''' the intent may pass itself populated with detected parameters . 
            ''' Or dynamically create and intent to pass such as "ASK QUESTION" or a FollowUP INTENT
            ''' 
            ''' </summary>
            Private iOutputContext As New List(Of iIntent)
            ''' <summary>
            ''' Used To Identify Intents
            ''' </summary>
            Public IntentName As String
            ''' <summary>
            ''' Description of Intent for Rich Text UI
            ''' </summary>
            Public IntentDescription As String
            ''' <summary>
            ''' When Used as an OutputIntent Context a time to live can be given 
            ''' after lifetime is reduced to 0 it is removed from the currentContext
            ''' </summary>
            Public Lifespan As Integer
            ''' <summary>
            ''' Phrase or Word used to activate intent
            ''' </summary>
            Public Triggers As New List(Of String)
            ''' <summary>
            ''' Responses for intent
            ''' </summary>
            Public Responses As New List(Of String)
            ''' <summary>
            ''' Each lists is a parameter If an enity in the named entity list is detected then 
            ''' The parameter is added to detected paramters; 
            ''' intents with multiple parameter can identify parameter by thier entity list name Which inturn 
            ''' Should have the parent parameter name
            ''' </summary>
            Public ReqEntitys As New List(Of iNamedEntitys)
            ''' <summary>
            ''' Parameters which have been detected by the intent
            ''' </summary>
            Public DetectedParameters As New List(Of iEntity)
            ''' <summary>
            ''' Number of required Parameters/Entitys
            ''' </summary>
            Public ReadOnly Property NoOfReqParameters As Integer
                Get
                    If ReqEntitys IsNot Nothing Then
                        Return ReqEntitys.Count
                    Else
                        Return 0

                    End If
                End Get
            End Property
            ''' <summary>
            ''' Number of Detected Parameters/Entity
            ''' </summary>
            Public ReadOnly Property NoOfDetectedParameters As Integer
                Get
                    If DetectedParameters IsNot Nothing Then
                        Return DetectedParameters.Count
                    Else
                        Return 0
                    End If
                End Get
            End Property
            ''' <summary>
            ''' Checks if Intent Requires Paramters
            ''' </summary>
            ''' <returns></returns>
            Public ReadOnly Property RequiresParameters As Boolean
                Get

                    If NoOfReqParameters > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Get
            End Property
            ''' <summary>
            ''' Checks if Intent Requires input Context
            ''' </summary>
            ''' <returns></returns>
            Public ReadOnly Property RequiresInputContext As Boolean
                Get
                    If InputContext IsNot Nothing Then


                        If InputContext.Count > 0 Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
                End Get
            End Property
            ''' <summary>
            ''' Internal Actions
            ''' </summary>
            Private IActions As New List(Of iAction)
            ''' <summary>
            ''' Currently Held Actions Actions must be added with the SUB ADDACTION
            ''' </summary>
            ''' <returns></returns>
            Public ReadOnly Property Actions As List(Of iAction)
                Get
                    Return IActions
                End Get
            End Property
            ''' <summary>
            ''' If Actions are populated then the intent is a Fulfilment entity
            ''' Therefore the response is contained within action response
            ''' </summary>
            ''' <returns></returns>
            Public ReadOnly Property IsFulfilment As Boolean
                Get
                    If IActions.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If

                End Get
            End Property
#End Region
#Region "ADD"
            ''' <summary>
            ''' Adds Action To Intent (ACTION SCRIPT)
            ''' </summary>
            ''' <param name="Name">Must Include: Name of fulfilment Action</param>
            ''' <param name="Code">Must Include: Code to be executed </param>
            ''' <param name="Desc">Description of the script </param>
            ''' <param name="Response">Must include: the Response to return to the user as executing the script</param>
            Public Sub AddAction(ByRef Name As String, ByRef Code As String, ByRef Desc As String, ByRef Response As String)
                Dim action As New iAction
                If Name IsNot vbNullString Or Code IsNot vbNullString Or Response IsNot vbNullString Then
                    action.ActionScript = Code
                    action.FulfilmentName = Name
                    action.Description = Desc
                    action.Response = Response
                    IActions.Add(action)
                Else
                End If
            End Sub
            ''' <summary>
            ''' Adds OutputContent to the Intent  : Used for Dynamic intent Generation 
            ''' the internal detectedParameters are added to the intent auto matically:
            ''' 
            ''' An output May need to be constructed on the Fly with the contents of the Current intent
            ''' 
            ''' 1) AS A RESPONSE  - Responses Can be created here to be passed to the current context in the dialog
            ''' 2) AS A PARAMETER_SET  - Parameters can be passed to the current context to be recieved by another intent 
            '''                                                requiring the input of this intent
            ''' </summary>
            ''' <param name="Name">Name of Response could be RESPONSE / OR PARAMETER Specific </param>
            ''' <param name="Response">The response could contain a text response or question to be posed to retrieve infomation</param>
            ''' <param name="Life">     LIFETIME OF PARAMETERS HELD COULD BE ISSUED HERE; 
            '''                                      Lifespans which are specified as 0 are often used to denote a RESPONSE;</param>
            Public Sub DynamicOutputContextBuilder(ByRef Name As String, ByRef Response As String,
                                        ByRef Life As Integer)
                Dim Intent As New iIntent With {
                .IntentName = Name,
                .Lifespan = Life,
                .DetectedParameters = Me.DetectedParameters
            }
                Intent.Responses.Add(Response)
                Me.OutputContext.Add(Intent)
            End Sub
            ''' <summary>
            ''' Adds OutputContent to the Intent  : Used for static intent Generation 
            ''' IE: Direct ANSWER with PARAMETER 
            ''' I LIKE YOUR CAT         OR 
            ''' WE HAVE CATS FOR SALE HERE IS A LIST
            ''' 
            ''' An output May need to be constructed on the Fly with the contents of the Current intent
            ''' 
            ''' 1) AS A RESPONSE  - Responses Can be created here to be passed to the current context in the dialog
            ''' 2) AS A PARAMETER_SET  - Parameters can be passed to the current context to be recieved by another intent 
            '''                                                requiring the input of this intent
            ''' </summary>
            ''' <param name="Name">Name of Response could be RESPONSE / OR PARAMETER Specific </param>
            ''' <param name="Response">The response could contain a text response or question to be posed to retrieve infomation</param>
            ''' <param name="Life">     LIFETIME OF PARAMETERS HELD COULD BE ISSUED HERE; 
            '''                                      Lifespans which are specified as 0 are often used to denote a RESPONSE;</param>
            '''    <param name="ReqParmeters"> Entitys to be added to output intent - 
            '''    It may be that individual parameters may be required for individual output intents   </param>                   
            Public Sub StaticOutputContextBuilder(ByRef Name As String, ByRef Response As String,
                                        ByRef Life As Integer, ByRef ReqParmeters As List(Of iEntity))
                Dim Intent As New iIntent With {
                .IntentName = Name,
                .Lifespan = Life,
                .DetectedParameters = ReqParmeters
            }
                Intent.Responses.Add(Response)
                Me.OutputContext.Add(Intent)
            End Sub
            ''' <summary>
            ''' Adds intent to input: Must have Name and LifeSpan:
            ''' </summary>
            ''' <param name="InputIntent"> intent to Add</param>
            Public Sub AddInputContext(ByRef InputIntent As iIntent)
                If InputIntent.IntentName IsNot vbNullString Or InputIntent.Lifespan < 1 Then
                Else
                    iInputContext.Add(InputIntent)
                End If
            End Sub
            ''' <summary>
            ''' Adds intent to Output: Must have Name and LifeSpan:
            ''' </summary>
            ''' <param name="OutputIntent"> intent to Add</param>
            Public Sub AddOutputContext(ByRef OutputIntent As iIntent)
                If OutputIntent.IntentName IsNot vbNullString Or OutputIntent.Lifespan < 1 Then
                Else
                    iOutputContext.Add(OutputIntent)
                End If
            End Sub
#End Region
#Region "REMOVE"
            ''' <summary>
            ''' Adds intent to input: Must have Name and LifeSpan:
            ''' </summary>
            ''' <param name="InputIntent">Intent to remove</param>
            Public Sub RemoveInputContext(ByRef InputIntent As iIntent)
                If InputContext.Count > 0 Then
                    If InputIntent.IntentName IsNot vbNullString Or InputIntent.Lifespan < 1 Then
                    Else
                        For Each item In iInputContext
                            If item.IntentName = InputIntent.IntentName Then
                                iInputContext.Remove(item)
                            Else
                            End If
                        Next
                    End If
                Else
                End If
            End Sub
            ''' <summary>
            ''' Adds intent to input: Must have Name and LifeSpan:
            ''' </summary>
            ''' <param name="OutputIntent">Intent to remove</param>
            Public Sub RemoveOutputContext(ByRef OutputIntent As iIntent)
                If OutputContext.Count > 0 Then
                    If OutputIntent.IntentName IsNot vbNullString Or OutputIntent.Lifespan < 1 Then
                    Else
                        For Each item In iInputContext
                            If item.IntentName = OutputIntent.IntentName Then
                                iOutputContext.Remove(item)
                            Else
                            End If
                        Next
                    End If
                Else
                End If
            End Sub
#End Region
#Region "Detect"
            ''' <summary>
            ''' Triggers allow for the detection of an Intent
            ''' Usage: A:
            ''' a trigger example - I would like to buy 
            ''' It can be combined with a Parameter from a list of products : 
            ''' by adding a named enity list with products to the paramters list ie: Products
            ''' 
            ''' </summary>
            ''' <param name="UserInput"></param>
            ''' <returns></returns>
            Private Function DetectTrigger(ByRef UserInput As String) As Boolean
                DetectTrigger = False
                For Each itemTrigger In Triggers
                    If UserInput.Contains(itemTrigger) Then
                        Return True
                    Else
                    End If
                Next
            End Function
            ''' <summary>
            ''' Each parameters list is checked if a paramter is detected then it is returned 
            ''' </summary>
            ''' <param name="UserInput"></param>
            ''' <returns>List of detected paramters</returns>
            Private Function DetectParameters(ByRef UserInput As String) As List(Of iEntity)
                Dim DetectedParameters As New List(Of iEntity)
                For Each itemParameterList In ReqEntitys
                    Dim DetectedEntity As iEntity = itemParameterList.DetectEntity(UserInput)
                    If DetectedEntity IsNot Nothing Then

                        DetectedParameters.Add(DetectedEntity)
                    Else
                    End If
                Next
                Return DetectedParameters
            End Function
            ''' <summary>
            ''' Context denotes Dialog state : 
            ''' Dialog state may be : new or currently in the process of collecting data.
            ''' 
            ''' The intent may not need all the items being held in the current state and 
            ''' only select the required input contexts required to fulfil the intent.
            ''' 
            ''' Populates Input context items with the items in the current context to be provided as input to the intent
            ''' as required by the intent ; 
            ''' 
            ''' If the intent does not require the true will also be returned;
            ''' If false is returned then it required input contexts and they were not fulfilled
            ''' </summary>
            ''' <param name="ProvidedContext">this is the current state of the dialog to be passed from the dialog controller</param>
            ''' <returns>If false is returned then it required input contexts and they were not fulfilled</returns>
            Private Function DetectInputContext(ByRef ProvidedContext As List(Of iIntent))
                Dim NumberOfRequired = InputContext.Count
                Dim Detected As Integer = 0
                Dim Required As Boolean = False




                'Check Context if Number of required is greater than 0 (Obviously TRUE)
                If NumberOfRequired >= 1 Then
                    Required = True
                    For Each itemContext In InputContext
                        For Each item In ProvidedContext
                            'Item Detected
                            If item.IntentName = itemContext.IntentName = True Then
                                Detected += 1
                            Else
                                'Item was not detected
                            End If
                        Next
                    Next
                Else
                End If
                'Since It may be true that there was parameters to be detected
                If Required = True Then
                    'Have the required be collected
                    If NumberOfRequired = Detected Then
                        'YES
                        Return True
                    Else
                        'If even 1 is missing then there will be false; 
                        'There may be a closer matching intent out there
                        Return False
                    End If
                Else
                    'Did not need to Check for input context
                    Return True
                End If

            End Function
            ''' <summary>
            ''' Detects if intent has been triggered; 
            ''' If parameters are enabled they are collected in DETECTEDPARAMETERS
            ''' </summary>
            ''' <param name="UserInput"></param>
            ''' <returns> If Parameters are required:
            ''' if 1 parameter is detected then the intent Returns True AND 
            ''' the populated entitys that have been discovered will be stored
            ''' if no parameters are detected then false is returned</returns>
            Public Function DetectIntent(ByRef UserInput As String, ByRef CurrentContext As List(Of iIntent)) As Boolean
                DetectIntent = False
                Dim iDetectedParameters As List(Of iEntity)
                'UsED TO DETECT IF THE PARAMETERS REQUIRED
                'BY THE INTENT HAVE BEEN CAPTURED
                Dim ParametersDetected = False
                'uSED TO DETECT IF THE INTENT WAS TRIGGERED
                Dim IntentDetected = False
                'Detect Intent(TRIGGER)
                If DetectTrigger(UserInput) = True Then
                    'REQUIRE PARAMETERS: 
                    If NoOfReqParameters > 0 Then
                        'DETECT PARAMETERS
                        iDetectedParameters = DetectParameters(UserInput)
                        If iDetectedParameters.Count = NoOfReqParameters Then
                            'ALL DETECTED
                            ParametersDetected = True
                            DetectedParameters.AddRange(iDetectedParameters)
                        Else
                            'ADD ANY DETECTED PARAMETERS 
                            If iDetectedParameters IsNot Nothing Then
                                'SOME or NONE DETECTED
                                DetectedParameters.AddRange(iDetectedParameters)
                            Else
                            End If

                        End If
                    Else
                        'PARAMETERS NOT REQUIRED:
                    End If
                    IntentDetected = True
                Else
                    'NOT DETECTED: FALSE
                End If
                'CHECKS IF IS INTENT
                '-Input CONTEXT REQUIREMENTS HAVE BEEN MET
                'IF INTENT IS NOT A CONTEXT ITEM TRUE IS ALSO RETURNED
                'fALSE IS RETRUNED IF - IS A CONTEXT ITEM AND IS NOT DETECTED
                If IntentDetected = True And DetectInputContext(CurrentContext) = True Then
                    'Check If Req PARAMETERS
                    If RequiresParameters = True Then
                        'WAS PARAMETERS DETECTED
                        If ParametersDetected = True Then
                            DetectIntent = True
                        Else
                            'REQUIRED PARAMETERS WERE NOT DETECTED
                        End If
                    Else
                        'PARAMETERS WERE NOT REQUIRED
                        'DetectIntent NOT AFFECTED  (SHOULD STILL BE FALSE)
                    End If
                Else
                    'INTENT DETECTED AND CONTEXT NOT DETECTED  
                    'DetectIntent NOT AFFECTED (SHOULD STILL BE FALSE)
                    'INTENT_DETECTED MAYBE TRUE / DETECT_INTENT_CONTEXT MAYBE FALSE
                    'INTENT_DETECTED MAYBE FALSE / DETECT_INTENT_CONTEXT MAYBE TRUE
                End If
                Return DetectIntent
            End Function
#End Region
#Region "Respond"
            ''' <summary>
            ''' Returns a Random Response from the response Collection object in current intent
            ''' </summary>
            ''' <returns>Returns a Random Response</returns>
            ''' 
            Public Function ReturnResponse() As String

                ' Initialize the random-number generator.
                Randomize()
                ' Generate random value between 1 and Responses.Count.
                Dim value As Integer = CInt(Int((Responses.Count * Rnd()) + 1))
                Dim response As String = Responses(value - 1)
                'Process Replacements
                Return ReplaceDetectedParameters(response)
            End Function
            ''' <summary>
            ''' Checks if Response Contains A Entity Marker to be replaced by a detected Entity
            ''' </summary>
            ''' <returns></returns>
            Public Function ReplaceDetectedParameters(ByRef Response As String) As String
                Dim Listname As String = ""

                Dim Str As String = Response
                If Me.NoOfDetectedParameters > 0 Then
                    For Each DetectedItem In DetectedParameters
                        '               Str = Str.Replace(DetectedItem.ReplacementParameterNameCharacter, DetectedItem.ParameterName)
                        '              Str = Str.Replace(DetectedItem.ReplacementTriggerCharacter, DetectedItem.Trigger)
                    Next
                Else
                End If
                Return Str
            End Function
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
            Public Shared Function FromJson(ByRef Str As String) As iIntent
                Try
                    Dim Converter As New JavaScriptSerializer
                    Dim diag As iIntent = Converter.Deserialize(Of iIntent)(Str)
                    Return diag
                Catch ex As Exception
                    Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                    MessageBox.Show(ex.Message, "ERROR", Buttons)
                End Try
                Return Nothing
            End Function
#End Region
#Region "ACTIONS"
            ''' <summary>
            ''' Executes Actions for Fulfilment of the Intent; 
            ''' DetectedParameters are passed to the Actions for use in the Scripts; 
            ''' Returns Response from Actions
            ''' </summary>
            ''' <returns>Returns Response from Actions: Chaining Responses for multiple actions</returns>
            Public Function ExecuteActions() As String
                Dim Resp As String = ""
                'If Actions are contained then execute them
                If Me.IsFulfilment = True Then
                    '' Execute All Actions
                    For Each item In IActions
                        item.ExecuteAction(DetectedParameters)
                        Resp &= item.Response & " "
                    Next
                    Return Resp
                Else
                    Return Resp
                End If
            End Function
#End Region
        End Class
        ''' <summary>
        ''' Used As Fulfilment for intents
        ''' </summary>
        <Serializable()>
        Public Class iAction
            ''' <summary>
            ''' Identifier For Action
            ''' </summary>
            Public FulfilmentName As String
            ''' <summary>
            ''' Visual Basic Code (SUB) Assume that a list of iEntity (detectedparameters) have been passed as its only parameter
            ''' This enables for customization of the fulfilment action
            ''' </summary>
            Public ActionScript As String
            Public Sub ExecuteAction(ByRef DetectedParameters As List(Of iEntity))
                Dim Code As String = "Public Parameters as List(of iEntity) = DetectedParameters
Public Function ExecuteActions(ByRef Params As List(Of iEntity)) As Object
" & ActionScript & " 
End Function"
                EvaluateFunction(Code, "ExecuteActions", DetectedParameters)
            End Sub
#Region "Fulfilment"
            ''' <summary>
            ''' Executes Function on the fly ; 
            ''' Entitys are used as variables which are made avalable to the script as 
            ''' Parameters = list(of iEntity) 
            ''' </summary>
            ''' <param name="Code">Function as String</param>
            ''' <param name="FunctName">Name of Function to be executed, </param>
            ''' <param name="Parameters">Included Entity Parameters</param>
            ''' <returns>OBJECT</returns>
            Public Shared Function EvaluateFunction(ByRef Code As String, ByRef FunctName As String, ByRef Parameters As List(Of iEntity)) As Object
                Dim sc As New ScriptControl With {
                .Language = "VBScript",
                .AllowUI = True
            }
                sc.AddCode(Code)
                sc.AddObject("DetectedParameters", Parameters)
                EvaluateFunction = sc.Run(FunctName)

            End Function
            ''' <summary>
            ''' Executes Function on the fly ; 
            ''' </summary>
            ''' <param name="Code">Function as String</param>
            ''' <param name="FunctName">Name of Function to be executed, </param>
            ''' <returns></returns>
            Public Shared Function EvaluateFunction(ByRef Code As String, ByRef FunctName As String) As Object
                Dim sc As New ScriptControl With {
                .Language = "VBScript",
                .AllowUI = True
            }
                sc.AddCode(Code)
                EvaluateFunction = sc.Run(FunctName)

            End Function
#End Region
            ''' <summary>
            ''' Desciption of Script Purpose
            ''' </summary>
            Public Description As String = ""
            ''' <summary>
            ''' Response For Action
            ''' </summary>
            Public Response As String = ""
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
            Public Shared Function FromJson(ByRef Str As String) As iAction
                Try
                    Dim Converter As New JavaScriptSerializer
                    Dim diag As iAction = Converter.Deserialize(Of iAction)(Str)
                    Return diag
                Catch ex As Exception
                    Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                    MessageBox.Show(ex.Message, "ERROR", Buttons)
                End Try
                Return Nothing
            End Function
        End Class
    End Namespace
End Namespace
