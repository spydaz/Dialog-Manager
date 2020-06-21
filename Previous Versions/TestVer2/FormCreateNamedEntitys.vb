Imports AI_SDK.DialogControl

Public Class FormCreatedNamedEntitys
    Private NamedEntitys As New iNamedEntitys
    Public WithEvents CreateEntity As New FormCreateEntity
    Private iListname As String = ""
    Public ReadOnly Property ListName As String
        Get
            Return iListname
        End Get
    End Property
    Public Event SAVE_NAMED_ENTITYLIST(ByRef SENDER As FormCreatedNamedEntitys, ByRef NewNamedEntitys As iNamedEntitys)
    Public Sub SAVE_ENTITY(ByRef Sender As FormCreateEntity, ByRef NewEntity As iEntity) Handles CreateEntity.SAVE_ENTITY
        NewEntity.EntityListName = ListName
        NamedEntitys.Entitys.Add(NewEntity)
        ListBoxEntitys.Items.Add(NewEntity.ParameterName & " : " & NewEntity.Trigger)
    End Sub
    Public Function SPLITSTR(ByRef Str As String, ByRef Param As String, ByRef TriGG As String) As Boolean
        Dim lst() As String = Str.Split(":")
        Param = lst(0)
        TriGG = lst(1)
        Return True
    End Function
    Private Sub SET_LIST_NAME(ByRef iName As String)
        iListname = iName
        TextBoxListName.Text = iName
        NamedEntitys.EntityListName = iName
    End Sub
    Public Sub LOAD_LIST(ByRef mNamedEntitys As iNamedEntitys)
        NamedEntitys = mNamedEntitys
        SET_LIST_NAME(mNamedEntitys.EntityListName)
        TextBoxListPrompt.Text = mNamedEntitys.ParameterPrompt
        TextBoxListReplacementChar.Text = mNamedEntitys.REPLACEMENT_SYMBOL
        TextBoxReplacementParameterCharacter.Text = mNamedEntitys.ReplacementParameterNameCharacter
        TextBoxReplacementTriggerCharacter.Text = mNamedEntitys.ReplacementTriggerCharacter
        For Each item In mNamedEntitys.Entitys
            ListBoxEntitys.Items.Add(item.ParameterName & " : " & item.Trigger)
        Next
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ListBoxEntitys.Items.Clear()
        TextBoxListName.Clear()
        NamedEntitys = New iNamedEntitys
    End Sub
    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If ListBoxEntitys.SelectedItem IsNot Nothing Then
            Try
                Dim Param As String = ""
                Dim Trigg As String = ""
                SPLITSTR(ListBoxEntitys.SelectedItem, Param, Trigg)
                For Each item In NamedEntitys.Entitys
                    If item.ParameterName = Param Then
                        NamedEntitys.Entitys.Remove(item)
                        ListBoxEntitys.Items.Remove(ListBoxEntitys.SelectedItem)
                    Else
                    End If
                Next
            Catch ex As Exception
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                MessageBox.Show(ex.Message, "ERROR", Buttons)
            End Try
        Else
        End If
    End Sub
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        NamedEntitys.ParameterPrompt = TextBoxListPrompt.Text
        NamedEntitys.ReplacementParameterNameCharacter = TextBoxReplacementParameterCharacter.Text
        NamedEntitys.ReplacementTriggerCharacter = TextBoxReplacementTriggerCharacter.Text
        NamedEntitys.REPLACEMENT_SYMBOL = TextBoxListReplacementChar.Text

        RaiseEvent SAVE_NAMED_ENTITYLIST(Me, NamedEntitys)

        Me.Close()
    End Sub
    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        CreateEntity = New FormCreateEntity
        CreateEntity.Show()
    End Sub
    Public Sub CREATE_LIST(ByRef EntityListname As String)
        NamedEntitys = New iNamedEntitys
        SET_LIST_NAME(EntityListname)
    End Sub

    Private Sub ButtonExportJson_Click(sender As Object, e As EventArgs) Handles ButtonExportJson.Click
        NamedEntitys.ParameterPrompt = TextBoxListPrompt.Text
        NamedEntitys.ReplacementParameterNameCharacter = TextBoxReplacementParameterCharacter.Text
        NamedEntitys.ReplacementTriggerCharacter = TextBoxReplacementTriggerCharacter.Text
        NamedEntitys.REPLACEMENT_SYMBOL = TextBoxListReplacementChar.Text
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\EntityLists\" & NamedEntitys.EntityListName & ".Json", NamedEntitys.ToJson, True)
    End Sub
End Class