Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Xml.Serialization
Imports MSScriptControl


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
    ''' <summary>
    ''' Intent Entities are used to Capture or Detect Specfic Entities. They are Stored as Named
    ''' Pairs Each intent parameter has a type, called the entity , which dictates exactly how
    ''' the string from an end-user expression is extracted.
    ''' </summary>
    <Serializable()>
    Public Class iEntity
        Public Shared Function SPLITSTR(ByRef Str As String, ByRef Param As String, ByRef TriGG As String) As Boolean
            Dim lst() As String = Str.Split(":")
            Param = lst(0)
            TriGG = lst(1)
            Return True
        End Function
#Region "Parameters"
        ''' <summary>
        ''' Parameters to detect : Slots Which need to be filled from UserInput : Data Collected
        ''' is Stored Here You can also define your intent to extract useful information from
        ''' the end-user expression, by using parameters and named entity lists, like a time or
        ''' location for the desired weather forecast. This extracted data is important for your
        ''' system to perform a weather query for the end-user.
        '''
        ''' Named Entity List Which this Parameter is a part of: it's best to define your
        ''' entities List prior to adding the training phrases to your intents. This will ensure
        ''' the correct words are annotated when the training phrases are supplied. You can
        ''' create entities afterwards,
        ''' </summary>
        Public EntityListName As String
        ''' <summary>
        ''' Named Entity Parameter (City)(New York) As Specified in the list
        ''' </summary>
        Public ParameterName As String
        ''' <summary>
        ''' Data Collected(NewYork)(Big Apple) As in List (Blank in Intent)
        ''' </summary>
        Public Trigger As String

#End Region
#Region "DETECT"
        ''' <summary>
        ''' detects if entity is detected
        ''' </summary>
        ''' <param name="UserInput"></param>
        ''' <returns></returns>
        Public Function DetectEntity(ByRef UserInput As String) As Boolean
            If UserInput.Contains(Trigger) = True Then
                Return True
            Else
            End If
            Return False
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
        Public Shared Function FromJson(ByRef Str As String) As iEntity
            Try
                Dim Converter As New JavaScriptSerializer
                Dim diag As iEntity = Converter.Deserialize(Of iEntity)(Str)
                Return diag
            Catch ex As Exception
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                MessageBox.Show(ex.Message, "ERROR", Buttons)
            End Try
            Return Nothing
        End Function
#End Region
    End Class
    ''' <summary>
    ''' List of named entities ; Parameters
    ''' When setting up your agent, it's best to define your entities prior to adding the training
    ''' phrases to your intents. This will ensure the correct words are annotated when the training
    ''' phrases are supplied. You can create entities afterwards, ''' but you'll need to manually
    ''' annotate the training phrases in each intent.
    ''' 
    ''' For example, you could define a vegetable entity list that can match the types of vegetables
    ''' available for purchase with a grocery store agent.
    ''' List of NamedEntitys / Parameters to be detected _ STATIC
    ''' IE: ANIMALS - Parent parameter name
    '''  - Child paramters Individual parameters may have many different triggers
    '''  - The Child parameter name may have the significant data as the parameter name
    ''' - CAT/CATS, DOG/DOGS , 
    ''' - CAT/CAT, DOG/DOGS, 
    ''' - FOX/FOXES, DOG/PUPPY, 
    ''' - CAT/KITTEN
    ''' -The combination of Parent and children Parameters can be used for fulfilment
    ''' Dynamic EntityLists may contain ParentName as the identifier such as CUSTOMER_DESTINATION
    ''' The list may have no parameters - 
    ''' Questions Posed by the Intent Which may be triggered as an inputContext "BOOK A TICKET"
    ''' Question "WHICH DESTINATION AIRPORT" = ChildParameterName = Destination /  ChidTrigger = LGW
    ''' </summary>
    ''' <remarks>To retrieve a single parameter such as customer name; A list for customer name would be required, Then an empty parameter created for the list item called name: the trigger would be the detected data;</remarks>
    <Serializable()>
    Public Class iNamedEntitys
#Region "Parameters"
        ''' <summary>
        ''' Character to be used as a replacement symbol or character ie @PETTYPE@ 
        ''' When response is chosen from Collection of Responses  : "We dont have @PET@ in our store"
        ''' @PET@ is used to denote the variable detected from the used . 
        ''' This could be from a named list or detected infomation
        ''' Replaces The Character with the Word Related by the user 
        ''' (DATA COLLECTED) (Named Entity Item / PRODUCT)
        ''' Held DATA TARGET = customername = parameter = Trigger (collected Parameter)
        ''' </summary>
        Public ReplacementTriggerCharacter As String = ""
        ''' <summary>
        ''' Character to be used as a replacement symbol or character ie @PET@ 
        ''' When response is chosen from Collection of Responses  : "We have got many of @PET@ in our store"
        ''' @PET@ is used to denote the variable detected from the used . 
        ''' This could be from a named list or detected infomation
        ''' Replaces The Actual Trigger Word Related by the user with the Parameter name
        ''' Held DATA TARGET = CAT/Cats, CAT/Siamese, CAT/Persian (PARMETER NAME: CAT)
        ''' </summary>
        Public ReplacementParameterNameCharacter As String = ""
        ''' <summary>
        ''' List of held entitys
        ''' </summary>
        Public ReadOnly Property Entitys As List(Of iEntity)
            Get
                Return iEntitys
            End Get
        End Property
        ''' <summary>
        '''  Name of list (Collection Name)
        ''' </summary>
        Public EntityListName As String = ""
        ''' <summary>
        ''' Here a Prompt can be provided to ask the User for the parameter Specifically
        ''' ie: which country is you destination
        ''' </summary>
        Public ParameterPrompt As String = ""
        ''' <summary>
        ''' Used for creating Responses which include the parameter 
        ''' IE: UserRequest BUYPET (PARAMETERLIST = PETS - PARAMETER = CAT - TRIGGER - KITTEN)
        ''' 
        ''' We have many types of *PET* for sale / = 
        ''' will return the detected PET from the PETS list.
        ''' </summary>
        Public REPLACEMENT_SYMBOL As String = ""
        Private iEntitys As List(Of iEntity)
#End Region
        Public Sub New()
            iEntitys = New List(Of iEntity)
        End Sub
#Region "Detect"
        ''' <summary>
        ''' Detects Entitys in List
        ''' </summary>
        ''' <param name="UserInput"></param>
        ''' <returns></returns>
        Public Function DetectEntity(ByRef UserInput As String) As iEntity

            For Each itemEntity In Entitys

                If itemEntity.DetectEntity(UserInput) = True Then
                    Return itemEntity
                Else
                End If

            Next
            Return Nothing
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
        Public Shared Function FromJson(ByRef Str As String) As iNamedEntitys
            Try
                Dim Converter As New JavaScriptSerializer
                Dim diag As iNamedEntitys = Converter.Deserialize(Of iNamedEntitys)(Str)
                Return diag
            Catch ex As Exception
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                MessageBox.Show(ex.Message, "ERROR", Buttons)
            End Try
            Return Nothing
        End Function


#End Region
#Region "Replace"
        Public Function ReplaceStr(ByRef Str As String) As String
            Str = Str.Replace(Me.REPLACEMENT_SYMBOL, Me.EntityListName)
            For Each item In iEntitys
                Str = Str.Replace(Me.ReplacementParameterNameCharacter, item.ParameterName)
                Str = Str.Replace(Me.ReplacementTriggerCharacter, item.Trigger)
            Next
            Return Str
        End Function
#End Region
        ''' <summary>
        ''' Adds An Entity to the list
        ''' </summary>
        ''' <param name="NewEntity"></param>
        Public Sub AddEntity(ByRef NewEntity As iEntity)
            If NewEntity.ParameterName IsNot vbNullString Then
                iEntitys.Add(NewEntity)
            Else
            End If
        End Sub
        ''' <summary>
        ''' Removes an Entity from the list
        ''' </summary>
        ''' <param name="OldEntity"></param>
        Public Sub RemoveEntity(ByRef OldEntity As iEntity)
            If iEntitys.Count > 0 Then
                For Each item In iEntitys
                    If item.ParameterName = OldEntity.ParameterName Then
                        iEntitys.Remove(item)
                    Else
                    End If
                Next
            Else
            End If
        End Sub
    End Class
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
        ''' Returns Response from Dialog (individual dialogs cn be processed here)
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

