Imports System.ComponentModel
Imports DialogManager.AI_Controllers

Public Class FormCreateIntent
    Public Event SaveList(ByRef Masterlist As List(Of Intent))
    Private MasterList As New List(Of Intent)
    Private nIntent As Intent
    Private MasterEntityLists As New List(Of NamedEntitys)
    ''' <summary>
    ''' Resets Form only Intent NOT Lists
    ''' </summary>
    Public Sub ResetForm()
        TextBoxAddDescription.Text = ""
        ListBoxInputIntents.Items.Clear()
        ListBoxOutputIntents.Items.Clear()
        ListBoxResponses.Items.Clear()
        ListBoxTriggers.Items.Clear()
        TextBoxLifespan.Text = 1
        ListBoxPreReqEntitys.Items.Clear()
        nIntent = New Intent
    End Sub
    Public Sub SetMasterLst(ByRef Lst As List(Of Intent))
        MasterList = Lst
        If MasterList.Count > 0 Then
            For Each item In MasterList
                ListBoxMasterList.Items.Add(item.IntentName)
            Next
        Else
        End If
    End Sub
    Public Sub SetIntent(ByRef mIntent As Intent)
        nIntent = mIntent
        Me.TextBoxAddName.Text = nIntent.IntentName
        Me.TextBoxAddDescription.Text = nIntent.IntentDescription
        Me.TextBoxLifespan.Text = mIntent.Lifespan
        For Each item In mIntent.ParameterLists
            ListBoxPreReqEntitys.Items.Add(item.EntityListName)
        Next
        For Each item In mIntent.Responses
            ListBoxResponses.Items.Add(item.TextResponse)
        Next
        For Each item In mIntent.Context.InputContext
            ListBoxInputIntents.Items.Add(item.IntentName)
        Next
        For Each item In mIntent.Context.OutputContext
            ListBoxOutputIntents.Items.Add(item.IntentName)
        Next
        For Each item In mIntent.Triggers
            ListBoxTriggers.Items.Add(item)
        Next

    End Sub
    Public Function GetIntentFromForm() As Intent

        nIntent.IntentName = UCase(TextBoxAddName.Text)
        nIntent.IntentDescription = TextBoxAddDescription.Text
        nIntent.Lifespan = TextBoxLifespan.Text

        'Section Controlled when Adding items to the box!
        ' ListBoxInputIntents.Items.Clear()
        ' ListBoxOutputIntents.Items.Clear()
        ' ListBoxResponses.Items.Clear()
        ' ListBoxTriggers.Items.Clear()
        ' ListBoxPreReqEntitys.Items.Clear()

        Return nIntent
    End Function
    Public Sub SetEntitys(ByRef Ents As List(Of NamedEntitys))
        If Ents IsNot Nothing Then
            MasterEntityLists = Ents
            ListBoxEntityLists.Items.Clear()
            ListBoxEntitys.Items.Clear()

            For Each item In Ents

                ListBoxEntityLists.Items.Add(item.EntityListName)

            Next
        Else
        End If
    End Sub
#Region "Form"
    Private Sub FormCreateIntent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
        nIntent = New Intent
        MasterList = New List(Of Intent)
        ListBoxMasterList.Items.Clear()
        ListBoxEntityLists.Items.Clear()
        ListBoxEntitys.Items.Clear()
        MasterEntityLists = New List(Of NamedEntitys)
    End Sub
#End Region
#Region "Buttons"
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
    Private Sub FormCreateIntent_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        RaiseEvent SaveList(MasterList)
    End Sub
    Private Sub ButtonClearForm_Click(sender As Object, e As EventArgs) Handles ButtonClearForm.Click
        ResetForm()
    End Sub
    Private Sub ButtonAddIntent_Click(sender As Object, e As EventArgs) Handles ButtonAddIntent.Click
        If TextBoxAddName.Text = "" Then
        Else
            MasterList.Add(GetIntentFromForm)
            ListBoxMasterList.Items.Add(GetIntentFromForm.IntentName)
        End If


    End Sub
    Private Sub ButtonEditIntent_Click(sender As Object, e As EventArgs) Handles ButtonEditIntent.Click
        Dim NewIntent As New Intent
        Dim Str As String = ListBoxMasterList.SelectedItem
        If Str <> "" Then
            For Each item In MasterList
                If item.IntentName = Str Then
                    SetIntent(item)
                    MasterList.Remove(item)
                    ListBoxMasterList.Items.Remove(Str)
                    Return
                Else
                End If

            Next
        End If
    End Sub
    Private Sub ButtonRemoveIntent_Click(sender As Object, e As EventArgs) Handles ButtonRemoveIntent.Click
        Dim NewIntent As New Intent
        Dim Str As String = ListBoxMasterList.SelectedItem
        If Str <> "" Then
            For Each item In MasterList
                If item.IntentName = Str Then
                    MasterList.Remove(item)
                    ListBoxMasterList.Items.Remove(Str)
                    Return
                Else
                End If
            Next
        End If
    End Sub
    Private Sub ButtonClearIntents_Click(sender As Object, e As EventArgs) Handles ButtonClearIntents.Click
        MasterList = New List(Of Intent)
        ListBoxMasterList.Items.Clear()
    End Sub
    Private Sub ButtonAddTrigger_Click(sender As Object, e As EventArgs) Handles ButtonAddTrigger.Click
        If TextBoxAddTrigger.Text <> "" Then nIntent.Triggers.Add(UCase(TextBoxAddTrigger.Text))
        ListBoxTriggers.Items.Add(UCase(TextBoxAddTrigger.Text))
    End Sub
    Private Sub ButtonRemoveTrigger_Click(sender As Object, e As EventArgs) Handles ButtonRemoveTrigger.Click
        Dim Str As String = ListBoxTriggers.SelectedItem
        nIntent.Triggers.Remove(Str)
        ListBoxTriggers.Items.Remove(Str)
    End Sub
    Private Sub ButtonEditTrigger_Click(sender As Object, e As EventArgs) Handles ButtonEditTrigger.Click
        Dim Str As String = ListBoxTriggers.SelectedItem
        nIntent.Triggers.Remove(Str)
        ListBoxTriggers.Items.Remove(Str)
        TextBoxAddTrigger.Text = Str
    End Sub
    Private Sub ButtonClearTriggers_Click(sender As Object, e As EventArgs) Handles ButtonClearTriggers.Click
        ListBoxTriggers.Items.Clear()
        nIntent.Triggers.Clear()
    End Sub
    Private Sub ButtonAddResponse_Click(sender As Object, e As EventArgs) Handles ButtonAddResponse.Click
        If TextBoxAddResponse.Text <> "" Then
            Dim Resp As New IntentResponse With {
                .TextResponse = TextBoxAddResponse.Text
            }
            ListBoxResponses.Items.Add(TextBoxAddResponse.Text)
            Me.nIntent.AddTextResponse(TextBoxAddResponse.Text)
        Else
        End If
    End Sub
    Private Sub ButtonEditResponse_Click(sender As Object, e As EventArgs) Handles ButtonEditResponse.Click
        If ListBoxResponses.SelectedItem <> "" Then
            Dim str As String = ListBoxResponses.SelectedItem
            For Each item In nIntent.Responses
                If item.TextResponse = str Then
                    ListBoxResponses.Items.Remove(str)
                    TextBoxAddResponse.Text = str
                    nIntent.Responses.Remove(item)
                    Return
                Else

                End If
            Next
        Else
        End If
    End Sub
    Private Sub ButtonRemoveResponse_Click(sender As Object, e As EventArgs) Handles ButtonRemoveResponse.Click
        If ListBoxResponses.SelectedItem <> "" Then
            Dim str As String = ListBoxResponses.SelectedItem
            For Each item In nIntent.Responses
                If item.TextResponse = str Then
                    ListBoxResponses.Items.Remove(str)

                    nIntent.Responses.Remove(item)
                    Return
                Else
                End If
            Next
        Else
        End If
    End Sub
    Private Sub ButtonClearResponse_Click(sender As Object, e As EventArgs) Handles ButtonClearResponse.Click
        nIntent.Responses.Clear()
        ListBoxResponses.Items.Clear()
    End Sub
    Private Sub ButtonClearParameters_Click(sender As Object, e As EventArgs) Handles ButtonClearParameters.Click
        ListBoxPreReqEntitys.Items.Clear()
        nIntent.Parameters.Clear()
    End Sub
    Private Sub ButtonRemoveParameter_Click(sender As Object, e As EventArgs) Handles ButtonRemoveParameter.Click
        Dim str As String = ListBoxPreReqEntitys.SelectedItem
        If str <> "" Then
            For Each item In nIntent.Parameters
                If item.EntityListName = str Then
                    ListBoxPreReqEntitys.Items.Remove(str)
                    nIntent.Parameters.Remove(item)
                    Return
                Else
                End If
            Next
        Else
        End If
    End Sub
    Private Sub ButtonAddParameter_Click(sender As Object, e As EventArgs) Handles ButtonAddParameter.Click
        If ListBoxEntityLists.SelectedItem <> "" Then
            Dim str As String = ListBoxEntityLists.SelectedItem
            For Each item In MasterEntityLists
                If item.EntityListName = str Then
                    nIntent.ParameterLists.Add(item)
                    Dim NewEntity As New Entity With {
                        .EntityListName = item.EntityListName
                    }
                    nIntent.Parameters.Add(NewEntity)
                    ListBoxPreReqEntitys.Items.Add(item.EntityListName)
                Else
                End If
            Next
        Else
        End If
    End Sub
    Private Sub ButtonRemoveOutputIntent_Click(sender As Object, e As EventArgs) Handles ButtonRemoveOutputIntent.Click
        If ListBoxOutputIntents.SelectedItem <> "" Then
            Dim str As String = ListBoxOutputIntents.SelectedItem
            For Each item In nIntent.Context.OutputContext
                If item.IntentName = str Then
                    ListBoxOutputIntents.Items.Remove(str)
                    nIntent.Context.OutputContext.Remove(item)
                    Return
                Else
                End If
            Next
        End If
    End Sub
    Private Sub ButtonRemoveInputIntent_Click(sender As Object, e As EventArgs) Handles ButtonRemoveInputIntent.Click
        If ListBoxOutputIntents.SelectedItem <> "" Then
            Dim str As String = ListBoxInputIntents.SelectedItem
            For Each item In nIntent.Context.InputContext
                If item.IntentName = str Then
                    ListBoxInputIntents.Items.Remove(str)
                    nIntent.Context.InputContext.Remove(item)
                    Return
                Else
                End If
            Next
        End If
    End Sub
    Private Sub ButtonAddInputIntent_Click(sender As Object, e As EventArgs) Handles ButtonAddInputIntent.Click
        Dim str As String = ListBoxMasterList.SelectedItem
        If str <> "" Then
            For Each item In MasterList
                If item.IntentName = str Then
                    nIntent.Context.AddContext(item, IntentContext.Context.input)
                    ListBoxInputIntents.Items.Add(item.IntentName)
                Else
                End If
            Next
        Else
        End If
    End Sub
    Private Sub ButtonAddOutputIntent_Click(sender As Object, e As EventArgs) Handles ButtonAddOutputIntent.Click
        Dim str As String = ListBoxMasterList.SelectedItem
        If str <> "" Then
            For Each item In MasterList
                If item.IntentName = str Then
                    nIntent.Context.AddContext(item, IntentContext.Context.output)
                    ListBoxOutputIntents.Items.Add(item.IntentName)
                Else
                End If
            Next
        Else
        End If
    End Sub
    Private Sub ButtonSaveMasterList_Click(sender As Object, e As EventArgs) Handles ButtonSaveMasterList.Click
        Dim str As String = ""
        If MasterList.Count > 0 Then
            For Each item In MasterList
                str &= vbNewLine & item.ToJson

            Next
            SaveJsonFile(str)
        Else
        End If
    End Sub
    Private Sub ButtonExportJsonIntent_Click(sender As Object, e As EventArgs) Handles ButtonExportJsonIntent.Click
        If ListBoxMasterList.SelectedItem <> "" Then

            For Each item In MasterList
                If item.IntentName = ListBoxMasterList.SelectedItem Then
                    SaveJsonFile(item.ToJson)
                Else
                End If
            Next

        Else

        End If
    End Sub
#End Region
#Region "Listboxes"
    Private Sub ListBoxEntityLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEntityLists.SelectedIndexChanged
        Dim str As String = ListBoxEntityLists.SelectedItem
        If str <> "" Then
            For Each item In MasterEntityLists
                If item.EntityListName = str Then
                    ListBoxEntitys.Items.Clear()
                    For Each SubItem In item.Entitys
                        ListBoxEntitys.Items.Add(SubItem.ParameterName)
                    Next
                Else
                End If
            Next
        Else
        End If
    End Sub
    Private Sub ListBoxTriggers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTriggers.SelectedIndexChanged
        Dim str As String = ListBoxTriggers.SelectedItem
        TextBoxAddTrigger.Text = str
    End Sub
    Private Sub ListBoxResponses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxResponses.SelectedIndexChanged
        Dim str As String = ListBoxResponses.SelectedItem
        TextBoxAddResponse.Text = str
    End Sub


#End Region


End Class