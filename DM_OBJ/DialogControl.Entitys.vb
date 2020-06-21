Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Xml.Serialization

Namespace AI_Controllers
    Namespace DialogControl
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

#Region "Import"

            ''' <summary>
            '''  Imports iNamedEntitys From Json Files to class from Folder App.Path\Entitys
            ''' </summary>
            Public Shared Function ImportNamedEntitys() As List(Of iNamedEntitys)
                Dim Entitys As New List(Of iNamedEntitys)
                On Error Resume Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Entitys\", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.Json")
                    Dim Str = My.Computer.FileSystem.ReadAllText(foundFile)
                    Dim diag As iNamedEntitys = iNamedEntitys.FromJson(Str)
                    Entitys.Add(diag)
                Next
            End Function
            ''' <summary>
            ''' Imports Named entitys list  From Json Files to class from Given FilePath (Files Must have Ext *.Json) 
            ''' searches for json and attempts to retrive Lists
            ''' </summary>
            ''' <param name="Pathname"></param>
            ''' <returns></returns>
            Public Shared Function ImportNamedEntitys(ByRef Pathname As String) As List(Of iNamedEntitys)
                Dim AvailableDialogs As New List(Of iNamedEntitys)
                On Error Resume Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Pathname, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.Json")
                    Dim Str = My.Computer.FileSystem.ReadAllText(foundFile)
                    Dim diag As iNamedEntitys = iNamedEntitys.FromJson(Str)
                    AvailableDialogs.Add(diag)
                Next
                Return AvailableDialogs
            End Function
            ''' <summary>
            '''  Imports single named entitylist From Json Files to class from text
            ''' </summary>
            ''' <param name="JsonFileText"></param>
            ''' <returns></returns>       
            Public Shared Function ImportNamedEntity(ByRef JsonFileText As String) As iNamedEntitys
                Try
                    Dim Str As String = JsonFileText
                    Dim iNamedEntitys As iNamedEntitys = iNamedEntitys.FromJson(Str)
                    Return iNamedEntitys
                Catch ex As Exception
                    Return Nothing
                End Try
            End Function

#End Region

        End Class
    End Namespace
End Namespace
