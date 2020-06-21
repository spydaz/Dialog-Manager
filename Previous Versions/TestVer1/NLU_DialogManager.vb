Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Xml.Serialization

Namespace AI_Controllers
#Region "Named Entitys"
    ''' <summary>
    ''' List of named entities ; Parameters
    '''
    ''' When setting up your agent, it's best to define your entities prior to adding the training
    ''' phrases to your intents. This will ensure the correct words are annotated when the training
    ''' phrases are supplied. You can create entities afterwards, ''' but you'll need to manually
    ''' annotate the training phrases in each intent.
    '''
    ''' For example, you could define a vegetable entity list that can match the types of vegetables
    ''' available for purchase with a grocery store agent.
    ''' </summary>
    Public Class NamedEntitys
        Public Entitys As List(Of Entity)
        Public EntityListName As String
        ''' <summary>
        ''' Here a Prompt can be provided to ask the User for the parameter Specifically
        ''' </summary>
        Public ParameterPrompt As String
        ''' <summary>
        ''' second get the parameter
        ''' </summary>
        ''' <param name="UserInput"></param>
        ''' <returns></returns>
        Public Function GetParameter(ByRef UserInput As String) As Entity

            For Each item In Entitys
                If UserInput.Contains(item.Trigger) Then
                    Return item
                End If
            Next
            Return Nothing
        End Function
        ''' <summary>
        ''' First detect if parameter is present in list
        ''' </summary>
        ''' <param name="UserInput"></param>
        ''' <returns></returns>
        Public Function DetectParameter(ByRef UserInput As String) As Boolean

            For Each item In Entitys
                If UserInput.Contains(item.Trigger) Then
                    Return True
                End If
            Next
            Return False
        End Function
        Public Sub New()
            Entitys = New List(Of Entity)
        End Sub
    End Class
    ''' <summary>
    ''' Intent Entities are used to Capture or Detect Specfic Entities. They are Stored as Named
    ''' Pairs Each intent parameter has a type, called the entity , which dictates exactly how
    ''' the string from an end-user expression is extracted.
    ''' </summary>
    Public Class Entity
#Region "XML"
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
        ''' Deserializes object to XML
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <returns></returns>
        Public Function FromXML(ByRef FileName As String) As Entity
            Dim ni As New Entity
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(ni.GetType)
            Dim readStream As FileStream = New FileStream(FileName, FileMode.Open)
            ni = CType(xmlSerializer.Deserialize(readStream), Entity)
            readStream.Close()
            Return ni
        End Function
#End Region
        ''' <summary>
        ''' Serializes object to json
        ''' </summary>
        ''' <returns> </returns>
        Public Function ToJson() As String
            Dim Converter As New JavaScriptSerializer
            Return Converter.Serialize(Me)
        End Function

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
        '''
        ''' LocationsCity
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

    End Class
#End Region
#Region "Intents"
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
    ''' </summary>
    Public Class Intent
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
        ''' </summary>
        Public Lifespan As Integer
        ''' <summary>
        ''' Context for intent: Using contexts, you can control the flow of a conversation. You can
        ''' configure contexts for an intent by setting input and output contexts, which are
        ''' identified by string names.
        ''' </summary>
        Public Context As IntentContext
        ''' <summary>
        ''' Response pool to be Select from
        ''' </summary>
        Public Responses As List(Of IntentResponse)
        ''' <summary>
        ''' Check to see if there is any context items created
        ''' </summary>
        ''' <returns> </returns>
        Public ReadOnly Property HasContext As Boolean
            Get
                If Context.InputContext.Count > 0 = True Or Context.OutputContext.Count > 0 = True Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        ''' <summary>
        ''' Phrase or Word used to activate intent
        ''' </summary>
        Public Triggers As List(Of String)
        ''' <summary>
        ''' Named entity list of Entitys : 
        ''' Each List is a ParameterListName => PET
        ''' ie: ParmaetersNames : "CAT", "DOG" 
        ''' 
        ''' </summary>
        Public ParameterLists As List(Of NamedEntitys)
        ''' <summary>
        ''' Parmeters To be detected by the Intent
        ''' </summary>
        Public Parameters As List(Of Entity)
        ''' <summary>
        ''' Internal Record
        ''' </summary>
        Public UserInput As String = ""
        ''' <summary>
        ''' Internal Record
        ''' </summary>
        Public TextResponse As String = ""
        ''' <summary>
        ''' Serializes object to json
        ''' </summary>
        ''' <returns> </returns>
        Public Function ToJson() As String
            Dim Converter As New JavaScriptSerializer
            Return Converter.Serialize(Me)
        End Function
        ''' <summary>
        ''' All Lists are initialized
        ''' </summary>
        Public Sub New()
            Triggers = New List(Of String)
            Responses = New List(Of IntentResponse)
            Context = New IntentContext
            ParameterLists = New List(Of NamedEntitys)
            Parameters = New List(Of Entity)
            Lifespan = 0
        End Sub
        ''' <summary>
        ''' Returns a random intent From the Given List
        ''' 
        ''' NOTE: Maybe used to produce conversation StarterIntents
        ''' </summary>
        ''' <param name="Intents"></param>
        ''' <returns></returns>
        Public Shared Function GetRandomIntent(ByRef Intents As List(Of Intent)) As Intent
            GetRandomIntent = New Intent
            Dim Count As Integer = Intents.Count
            If Count > 0 Then
                If Count = 1 Then
                    GetRandomIntent = Intents(0)
                Else
                    GetRandomIntent = Intents(Rnd(Count - 1))
                End If
            Else
            End If
        End Function
#Region "RESPONSE"
        ''' <summary>
        ''' Returns Response from Intent
        ''' </summary>
        ''' <returns> </returns>
        Public Function ReturnResponse() As String
            Dim mResponse As IntentResponse
            If Responses.Count > 0 Then
                Dim Count As Integer = Responses.Count
                Dim MyValue As Integer
                MyValue = Int((Count))   ' Generate random value between 0 and Count.
                mResponse = Responses(MyValue - 1)
                Me.TextResponse = mResponse.TextResponse
                Return mResponse.TextResponse
            Else
                Return ""
            End If
        End Function
        ''' <summary>
        ''' Creates a New IntentResponse and Adds it to Internal Responses
        ''' </summary>
        ''' <param name="NewResponse"> </param>
        Public Sub AddTextResponse(ByRef NewResponse As String)
            Dim NewResp As New IntentResponse With {
                .TextResponse = NewResponse
            }
            Responses.Add(NewResp)
        End Sub
#End Region
#Region "DETECT"
        ''' <summary>
        ''' Is Intent Triggered by UserInput; If a Trigger is found in the user sentence then the
        ''' intent is activated; If the Intent has PreRequsites Such as Input Intents they will need
        ''' to be checked seperately;
        '''
        ''' This function may also prove useful when assessing which intents are fired during the
        ''' search process for probablistic Learning;
        ''' 
        ''' NOTE : THIS FUNCTION ONLY DETECTS TRUE BY USERINPUT : (TRIGGERS ONLY)
        ''' Regardless of contexts or parameters
        ''' </summary>
        ''' <param name="UserInput"> </param>
        ''' <returns> </returns>
        Private Function DetectIntentTriggers(ByRef UserInput As String) As Boolean
            DetectIntentTriggers = False
            'Detect
            For Each item In Triggers
                If UCase(UserInput).Contains(UCase(item)) = True Then
                    'Found
                    Return True
                Else
                End If
            Next
        End Function
        ''' <summary>
        ''' Detects if Previous Requirements For this Intent have been met this maybe used
        ''' individually : for loose activation of this intent;
        '''
        ''' For Instance: Diagnostic or probablisic uses: If all Intents have been detected then
        ''' this intent may stay available in a pool of potential responses - This would be a
        ''' Probablistic response being generated from the Intent Manager System
        ''' 
        ''' NOTE: INPUT-INTENTS ARE THE CURRENT TOPICS BEING HELD IN MANAGER
        '''         THE CONTEXT OF THIS INTENT NEED TO BE HELD BEFORE BECOMING TRUE
        '''         THIS IS AN INTERNAL CHECK!
        '''         
        ''' (BY TRIGGERS + INPUT CONTEXT)
        ''' </summary>
        ''' <param name="InputIntents"> Current_Running_Intents </param>
        ''' <returns> True If Preqs Intents Have Been Met </returns>
        Private Function DetectInputIntents(ByRef InputIntents As List(Of Intent)) As Boolean
            DetectInputIntents = False
            Dim Count As Integer = Context.InputContext.Count
            Dim Detected As Integer = 0
            'Are there Input intents
            If Count > 0 Then
                'Yes InputIntents Required
                For Each item In InputIntents
                    'Check Each Intent in the Given Intents to see if they occur in internal Input Intent set
                    If Context.CheckContext(item, IntentContext.Context.input) = True Then
                        'Increment Count detected intents
                        Detected += 1
                    Else
                    End If
                Next
                'Compare Detected ITems With number inputs Required by the Intent
                If Count = Detected Then
                    'Parameters  met
                    Return True
                Else
                    'PreRequesites Intents were not Met
                End If
            Else
                'No Inputs are Required for this intent
                Return True
            End If
        End Function
        ''' <summary>
        ''' Intents Also Contain PreRequisites ; Input Intents are used to provide extra context to
        ''' the intent.
        '''
        ''' Here All Triggers and PreRequsites need to be fulfilled before returning True:
        ''' </summary>
        ''' <param name="UserInput">           Current UserInput </param>
        ''' <param name="CurrentInputIntents"> Current intents active </param>
        ''' <returns> true if all Input Intents and Triggers have been sucessfull </returns>
        Public Function DetectIntent(ByRef UserInput As String, ByRef CurrentInputIntents As List(Of Intent)) As Boolean
            Me.UserInput = UCase(UserInput)
            DetectIntent = False
            If DetectIntentTriggers(UCase(UserInput)) = True And
                DetectInputIntents(CurrentInputIntents) = True Then
                'Check Parameters
                If Me.Parameters.Count > 0 Then
                    UpdateParameters(UCase(UserInput))
                    Return True
                Else
                    Return True
                End If
            Else
            End If
        End Function
        ''' <summary>
        ''' If parameters are present then they are checked and updated
        ''' </summary>
        ''' <param name="UserInput"></param>
        Private Sub UpdateParameters(ByRef UserInput As String)


            For Each Parameter In Parameters
                'Check if Input contains trigger
                If UCase(UserInput.Contains(Parameter.Trigger)) Then
                    'Now GET ParameterNAME from list
                    Dim Listname As String = Parameter.EntityListName
                    For Each item In ParameterLists
                        'Find List
                        If item.EntityListName = Listname Then
                            'Search Items
                            For Each SubItem In item.Entitys
                                'Find Item
                                If SubItem.Trigger = Parameter.Trigger Then
                                    'Update Parameter
                                    Parameter.ParameterName = SubItem.ParameterName
                                Else
                                    'no Trigger Match Does not exist in list
                                End If
                                'No Parameter Found (Check Next)
                            Next
                        Else
                            'No List Match
                        End If
                        'Check next List
                    Next
                Else
                    'Does not contain Parameter
                End If
                'Check Next Parameter
            Next
        End Sub


#End Region
#Region "XML"
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
        ''' Deserializes object to XML
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <returns></returns>
        Public Function FromXML(ByRef FileName As String) As Intent
            Dim ni As New Intent
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(ni.GetType)
            Dim readStream As FileStream = New FileStream(FileName, FileMode.Open)
            ni = CType(xmlSerializer.Deserialize(readStream), Intent)
            readStream.Close()
            Return ni
        End Function
#End Region
        ''' <summary>
        ''' Adds Intent To Context
        ''' </summary>
        ''' <param name="NewIntent">   Intent to be Added </param>
        ''' <param name="ContextType"> Input/Output </param>
        Public Sub AddContext(ByRef NewIntent As Intent, ByRef ContextType As IntentContext.Context)
            Context.AddContext(NewIntent, ContextType)
        End Sub
    End Class
    ''' <summary>
    ''' Intent Extensions
    ''' </summary>
    Public Module Ext
#Region "INTENTS EXTENSIONS"
        ''' <summary>
        ''' Get random Intent from the list
        ''' </summary>
        ''' <param name="Intents"> </param>
        ''' <returns> </returns>
        <System.Runtime.CompilerServices.Extension()>
        Public Function GetRandomIntent(ByRef Intents As List(Of Intent)) As Intent
            GetRandomIntent = New Intent
            Dim Count As Integer = Intents.Count
            If Count > 0 Then
                If Count = 1 Then
                    GetRandomIntent = Intents(0)
                Else
                    GetRandomIntent = Intents(Rnd(Count - 1))
                End If
            Else
            End If
        End Function
#End Region
#Region "JSON"
#Region "Load JSON"
        ''' <summary>
        ''' Opens File with json returning the string
        ''' </summary>
        ''' <param name="Filename"> </param>
        ''' <returns> </returns>
        Public Function LoadJsonFile(ByRef Filename As String) As String
            If Filename IsNot Nothing Then
                LoadJsonFile = File.ReadAllText(Filename)
            Else
                LoadJsonFile = LoadJsonFile()
            End If
        End Function

        ''' <summary>
        ''' Loads json File With open file dialog returning the json String
        ''' </summary>
        ''' <returns> </returns>
        Public Function LoadJsonFile() As String
            LoadJsonFile = ""
            Dim OpenFileDialog1 As New OpenFileDialog With {
                .Filter = "Json Files (*.Json*)|*.Json"
            }
            If OpenFileDialog1.ShowDialog = DialogResult.OK _
             Then
                Dim Filename As String = OpenFileDialog1.FileName
                LoadJsonFile = LoadJsonFile(Filename)
            Else

            End If
        End Function
#End Region
#Region " Save Json"
        ''' <summary>
        ''' Saves Json File
        ''' </summary>
        ''' <param name="Json">     </param>
        ''' <param name="Filename"> </param>
        <System.Runtime.CompilerServices.Extension()>
        Public Sub SaveJsonFile(ByRef Json As String, ByRef Filename As String)

            My.Computer.FileSystem.WriteAllText _
                (Filename, Json, True)
        End Sub
        ''' <summary>
        ''' Saves Json File With Savefile Dialog
        ''' </summary>
        ''' <param name="JsonString"> </param>
        <System.Runtime.CompilerServices.Extension()>
        Public Sub SaveJsonFile(ByRef JsonString As String)
            Dim SaveFileDialog1 As New SaveFileDialog With {
                .Filter = "Json Files (*.Json*)|*.Json"
            }
            If SaveFileDialog1.ShowDialog = DialogResult.OK _
             Then
                Dim Filename As String = SaveFileDialog1.FileName
                SaveJsonFile(JsonString, Filename)
            End If
        End Sub
#End Region
#End Region
#Region "JSON LISTS"
        ''' <summary>
        ''' Serializes List to json (Useful for Lists)
        ''' </summary>
        ''' <param name="Item"> </param>
        ''' <returns> </returns>
        <System.Runtime.CompilerServices.Extension()>
        Public Function ToJson(ByRef Item As List(Of Intent)) As String
            Dim Converter As New JavaScriptSerializer
            Return Converter.Serialize(Item)
        End Function

        ''' <summary>
        ''' Serializes List to json (Useful for Lists)
        ''' </summary>
        ''' <param name="Item"> </param>
        ''' <returns> </returns>
        <System.Runtime.CompilerServices.Extension()>
        Public Function ToJson(ByRef Item As List(Of NamedEntitys)) As String
            Dim Converter As New JavaScriptSerializer
            Return Converter.Serialize(Item)
        End Function

#End Region
    End Module
#End Region
#Region "IntentParameters"
    ''' <summary>
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
    Public Class IntentContext
#Region "XML"
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
        ''' Deserializes object to XML
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <returns></returns>
        Public Function FromXML(ByRef FileName As String) As IntentContext
            Dim ni As New IntentContext
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(ni.GetType)
            Dim readStream As FileStream = New FileStream(FileName, FileMode.Open)
            ni = CType(xmlSerializer.Deserialize(readStream), IntentContext)
            readStream.Close()
            Return ni
        End Function
#End Region
        ''' <summary>
        ''' Serializes object to json
        ''' </summary>
        ''' <returns> </returns>
        Public Function ToJson() As String
            Dim Converter As New JavaScriptSerializer
            Return Converter.Serialize(Me)
        End Function

        ''' <summary>
        ''' Enumerator for Context type
        ''' </summary>
        Enum Context
            input
            output
        End Enum

        Public Sub New()
            InputContext = New List(Of Intent)
            OutputContext = New List(Of Intent)

        End Sub

        ''' <summary>
        ''' Checks for presence of Intent: When an intent is matched, any configured output
        ''' contexts for that intent become active. While any contexts are active, The System
        ''' Should only match, intents that are configured with input contexts that match the
        ''' currently active intent.
        ''' </summary>
        ''' <param name="FindIntent"> Intent To be found </param>
        ''' <param name="iContext">   Input/Output </param>
        ''' <returns> True if found </returns>
        Public Function CheckContext(ByRef FindIntent As Intent, iContext As Context) As Boolean
            Select Case iContext
                Case Context.input
                    For Each item In InputContext
                        If item.IntentName = FindIntent.IntentName = True Then Return True

                    Next
                Case Context.output
                    For Each item In OutputContext
                        If item.IntentName = FindIntent.IntentName = True Then Return True
                    Next
            End Select
            Return False
        End Function

        ''' <summary>
        ''' Adds Intent To Context
        ''' </summary>
        ''' <param name="NewIntent">   </param>
        ''' <param name="ContextType"> </param>
        Public Sub AddContext(ByRef NewIntent As Intent, ByRef ContextType As IntentContext.Context)
            Select Case ContextType
                Case IntentContext.Context.input
                    If InputContext Is Nothing Then
                        InputContext = New List(Of Intent)
                    End If
                    InputContext.Add(NewIntent)
                Case IntentContext.Context.output
                    If OutputContext Is Nothing Then
                        OutputContext = New List(Of Intent)
                    End If
                    OutputContext.Add(NewIntent)
            End Select
        End Sub

        ''' <summary>
        ''' Checks if there are input intents stored
        ''' </summary>
        ''' <returns> </returns>
        Public ReadOnly Property HasInputRequirements As Boolean
            Get
                If InputContext.Count < 1 Then
                    Return False
                Else
                    Return True
                End If
            End Get
        End Property

        ''' <summary>
        ''' Check if there are output intents stored
        ''' </summary>
        ''' <returns> </returns>
        Public ReadOnly Property HasOutputRequirements As Boolean
            Get
                If OutputContext.Count < 1 Then
                    Return False
                Else
                    Return True
                End If
            End Get
        End Property

        ''' <summary>
        ''' Used to match intent from current intent: the system will match simular intents with
        ''' simular triggers, To further reduce the error or Match to the correct intent, the
        ''' system matches the current intent held by the system : if this list of inputs
        ''' intents does not contain the current intent then it will not match
        '''
        ''' Additionlly: If intents have contexts defined multiple intents may have the same
        ''' trigger world ie : yes being the answer to a question But which question? this can
        ''' be tracked by its input context: as the intents are fired; The input Context is
        ''' Checked first : If the input context Is movies Then the movies PlayIT will be
        ''' priority vice versa If the input context Is Songs Then the songs PlayIT will be
        ''' priority vice versa
        ''' </summary>
        Public InputContext As List(Of Intent)

        ''' <summary>
        ''' When applied to an intent, an output context tells the system to activate a context
        ''' if it's not already active or to maintain the context after the intent is matched.
        '''
        ''' Additionally: The output context is used to group potential branches to the
        ''' conversation aswell as Preserve the lifespan of the Topic/Intent An output Intent
        ''' can be passed to be set in the intent manager, This could also be used to Carry
        ''' variables learned in the current Conversation Tree the lifespan Function Enables for
        ''' a Turn Based Counter to maintain the lifespan of the intent object
        ''' </summary>
        Public OutputContext As List(Of Intent)

    End Class
    ''' <summary>
    ''' Responses Can be Various Formats, Hence Using a Structure
    ''' </summary>
    Public Class IntentResponse
        ''' <summary>
        ''' Creates a New IntentResponse and Returns It
        ''' </summary>
        ''' <param name="NewResponse"> </param>
        Public Shared Function CreateTextIntentResponse(ByRef NewResponse As String) As IntentResponse
            Dim NewResp As New IntentResponse With {
                .TextResponse = NewResponse
            }
            Return NewResp
        End Function
        ''' <summary>
        ''' Serializes object to json
        ''' </summary>
        ''' <returns> </returns>
        Public Function ToJson() As String
            Dim Converter As New JavaScriptSerializer
            Return Converter.Serialize(Me)
        End Function
        ''' <summary>
        ''' Text Response
        ''' </summary>
        Public TextResponse As String
#Region "XML"
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
        ''' Deserializes object to XML
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <returns></returns>
        Public Function FromXML(ByRef FileName As String) As IntentResponse
            Dim ni As New IntentResponse
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(ni.GetType)
            Dim readStream As FileStream = New FileStream(FileName, FileMode.Open)
            ni = CType(xmlSerializer.Deserialize(readStream), IntentResponse)
            readStream.Close()
            Return ni
        End Function
#End Region
    End Class
    ''' <summary>
    ''' Actions can be Events or Comands Or Scripts
    ''' </summary>
    Public Class IntentAction
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
        ''' Deserializes object to XML
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <returns></returns>
        Public Function FromXML(ByRef FileName As String) As IntentAction
            Dim ni As New IntentAction
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(ni.GetType)
            Dim readStream As FileStream = New FileStream(FileName, FileMode.Open)
            ni = CType(xmlSerializer.Deserialize(readStream), IntentAction)
            readStream.Close()
            Return ni
        End Function
        ''' <summary>
        ''' Serializes object to json
        ''' </summary>
        ''' <returns> </returns>
        Public Function ToJson() As String
            Dim Converter As New JavaScriptSerializer
            Return Converter.Serialize(Me)
        End Function
        Public ActionName As String
    End Class
#End Region
#Region "Dialog Manager"
    Public Class DialogManager
        ''' <summary>
        ''' Topics that are set into current focus :
        ''' </summary>
        Public CurrentTopicList As List(Of Intent)
        ''' <summary>
        ''' History of intents and turns : 
        ''' </summary>
        Public History As List(Of Intent)
        ''' <summary>
        ''' Previous Intent : 
        ''' </summary>
        Public PrevIntent As Intent
        ''' <summary>
        ''' Current Detected Intent: 
        ''' </summary>
        Public DetectedIntent As Intent
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
        Public MasterList As List(Of Intent)
        ''' <summary>
        ''' Lists of Named Entitys (used as Parameters to be discovered)
        ''' </summary>
        Public EntityLists As List(Of NamedEntitys)
        ''' <summary>
        ''' Parameters collected 
        ''' </summary>
        Public CollectedParameters As List(Of Entity)
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
            Dim Detetcted As New List(Of Intent)
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
        Private Function GetDetectedIntents(ByRef mUserInput As String) As List(Of Intent)
            Dim Detected As New List(Of Intent)
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
                Dim DetectedIntents As List(Of Intent) = GetDetectedIntents(Userinput)
                'Which intent is correct?
                'Update Current;
                Dim DetectedIntent As Intent = DetectedIntents.GetRandomIntent()
                Me.DetectedIntent = DetectedIntent
                'update history
                History.Add(DetectedIntent)
                'Update Current topics  (output Topics)
                For Each itm In DetectedIntent.Context.OutputContext
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
                DetectedIntent = New Intent With {
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
            If DetectedIntent.Parameters.Count > 0 Then
                For Each Param In DetectedIntent.Parameters
                    If Param.ParameterName IsNot "" Then
                        CollectedParameters.Add(Param)
                    Else
                        'If the parameter is unpopulated then Add a Prompt to the response
                        'And Add the Intent to the Current intents 
                        For Each lst In EntityLists
                            If lst.EntityListName = Param.EntityListName Then
                                'Nothing was detected "FallbackIntent"
                                Response = lst.ParameterPrompt
                                DetectedIntent = New Intent With {
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
            CurrentTopicList = New List(Of Intent)
            History = New List(Of Intent)
            MasterList = New List(Of Intent)
            EntityLists = New List(Of NamedEntitys)
            CollectedParameters = New List(Of Entity)
        End Sub
    End Class
#End Region
End Namespace