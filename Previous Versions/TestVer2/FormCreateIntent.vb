Imports AI_SDK.DialogControl



Public Class FormCreateIntent
    Private Dialog As iDialog
    Private CurrentIntent As New iIntent
    Public Event SAVE_INTENT(ByRef Sender As FormCreateIntent, ByRef NewIntent As iIntent)
    Public Event SAVE_DIALOG(ByRef Sender As FormCreateIntent, ByRef NewDialog As iDialog)
    Public Sub LOAD_DIALOG(ByRef CurrentDialog As iDialog)
        Dialog = CurrentDialog
        'ENITIY LISTS
        If Dialog.AvailableEntityLists IsNot Nothing Then
            For Each item In Dialog.AvailableEntityLists
                ListBoxAvailableEntitys.Items.Add(item.EntityListName)
            Next
        Else
        End If
        'INTENT LISTS
        If Dialog.AvailableIntents IsNot Nothing Then
            For Each item In Dialog.AvailableIntents
                ListBoxAvailableIntents.Items.Add(item.IntentName)
            Next
        Else
        End If
    End Sub
    Public Sub LOAD_INTENT(ByRef NewIntent As iIntent)
        CurrentIntent = NewIntent
        Me.TextBoxIntentName.Text = NewIntent.IntentName
        Me.TextBoxIntentDescription.Text = NewIntent.IntentDescription
        Me.NumericUpDownIntentLifeSpan.Value = NewIntent.Lifespan
        'Response LISTS
        For Each item In NewIntent.Responses
            ListBoxResponses.Items.Add(item)
        Next
        'Triggers LISTS
        For Each item In NewIntent.Triggers
            ListBoxTriggers.Items.Add(item)
        Next
        'Actions LISTS
        For Each item In NewIntent.Actions
            ListBoxActions.Items.Add(item.FulfilmentName)
        Next

        'Output LISTS (Output Context)
        For Each item In NewIntent.OutputContext
            ListBoxOutputContext.Items.Add(item.IntentName)
        Next
        'input LISTS (input Context)
        For Each item In NewIntent.InputContext
            ListBoxInputContext.Items.Add(item.IntentName)
        Next
        'ReqEntitys LISTS (ReqEntitys)
        For Each item In NewIntent.ReqEntitys
            ListBoxReqEntityLists.Items.Add(item.EntityListName)
        Next
    End Sub
    Private Sub ButtonSaveIntent_Click(sender As Object, e As EventArgs) Handles ButtonSaveIntent.Click
        Me.WindowState = FormWindowState.Minimized
        CurrentIntent.IntentName = TextBoxIntentName.Text
        CurrentIntent.IntentDescription = TextBoxIntentDescription.Text
        RaiseEvent SAVE_INTENT(Me, CurrentIntent)
        Me.Close()
    End Sub
    Private Sub FormCreateIntent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentIntent = New iIntent
    End Sub
#Region "Triggers"
    Private Sub ButtonADDTrigger_Click(sender As Object, e As EventArgs) Handles ButtonADDTrigger.Click
        If TextBoxTriggers.Text <> "" Then
            CurrentIntent.Triggers.Add(UCase(TextBoxTriggers.Text))
            ListBoxTriggers.Items.Add(UCase(TextBoxTriggers.Text))
            TextBoxTriggers.Clear()
        Else
        End If
    End Sub
    Private Sub ButtonRemoveTrigger_Click(sender As Object, e As EventArgs) Handles ButtonRemoveTrigger.Click
        Try
            If ListBoxTriggers.SelectedItem IsNot Nothing Then
                For Each item In CurrentIntent.Triggers
                    If ListBoxTriggers.SelectedItem = item Then
                        CurrentIntent.Triggers.Remove(item)
                        ListBoxTriggers.Items.Remove(item)
                    End If
                Next
            Else
            End If

        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub
    Private Sub ButtonClearTriggers_Click(sender As Object, e As EventArgs) Handles ButtonClearTriggers.Click
        ListBoxTriggers.Items.Clear()
        CurrentIntent.Triggers.Clear()
    End Sub
    Private Sub ButtonEditTrigger_Click(sender As Object, e As EventArgs) Handles ButtonEditTrigger.Click
        Try
            If ListBoxTriggers.SelectedItem IsNot Nothing Then
                For Each item In CurrentIntent.Triggers
                    If ListBoxTriggers.SelectedItem = item Then
                        TextBoxTriggers.Text = item
                        CurrentIntent.Triggers.Remove(item)
                    End If
                Next
            Else
            End If
        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub
#End Region
#Region "Responses"
    Private Sub ButtonAddResponse_Click(sender As Object, e As EventArgs) Handles ButtonAddResponse.Click
        If TextBoxResponse.Text <> "" Then
            CurrentIntent.Responses.Add(TextBoxResponse.Text)
            ListBoxResponses.Items.Add(TextBoxResponse.Text)
            TextBoxResponse.Clear()
        Else
        End If
    End Sub
    Private Sub ButtonRemoveResponse_Click(sender As Object, e As EventArgs) Handles ButtonRemoveResponse.Click
        Try
            If ListBoxResponses.SelectedItem IsNot Nothing Then
                For Each item In CurrentIntent.Responses
                    If ListBoxResponses.SelectedItem = item Then
                        CurrentIntent.Responses.Remove(item)
                        ListBoxResponses.Items.Remove(item)
                    End If
                Next
            Else
            End If

        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub
    Private Sub ButtonClearResponse_Click(sender As Object, e As EventArgs) Handles ButtonClearResponse.Click
        ListBoxResponses.Items.Clear()
        CurrentIntent.Responses.Clear()
    End Sub
    Private Sub ButtonEditResponse_Click(sender As Object, e As EventArgs) Handles ButtonEditResponse.Click
        Try
            If ListBoxResponses.SelectedItem IsNot Nothing Then
                For Each item In CurrentIntent.Responses
                    If ListBoxResponses.SelectedItem = item Then
                        CurrentIntent.Responses.Remove(item)
                        ListBoxResponses.Items.Remove(item)
                        TextBoxResponse.Text = item
                    End If
                Next
            Else
            End If

        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub

#End Region
#Region "Actions"
    Private WithEvents CreateAction As FormCreateAction
    Private Sub ButtonAddAction_Click(sender As Object, e As EventArgs) Handles ButtonAddAction.Click
        CreateAction = New FormCreateAction
        CreateAction.Show()
    End Sub
    Public Sub SAVE_ACTION(ByRef Sender As FormCreateAction, ByRef Act As iAction) Handles CreateAction.SAVE_ACTION
        CurrentIntent.Actions.Add(Act)
        ListBoxActions.Items.Add(Act.FulfilmentName)
    End Sub
    Private Sub ButtonRemoveAction_Click(sender As Object, e As EventArgs) Handles ButtonRemoveAction.Click
        Try
            If ListBoxActions.SelectedItem IsNot Nothing Then
                For Each item In CurrentIntent.Actions
                    If ListBoxActions.SelectedItem = item Then
                        CurrentIntent.Actions.Remove(item)
                        ListBoxActions.Items.Remove(item)
                    End If
                Next
            Else
            End If

        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub
    Private Sub ButtonClearActions_Click(sender As Object, e As EventArgs) Handles ButtonClearActions.Click
        ListBoxActions.Items.Clear()
        CurrentIntent.Actions.Clear()
    End Sub

    Private Sub ButtonExportJson_Click(sender As Object, e As EventArgs) Handles ButtonExportJson.Click
        CurrentIntent.IntentName = TextBoxIntentName.Text
        CurrentIntent.IntentDescription = TextBoxIntentDescription.Text
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\EntityLists\" & CurrentIntent.IntentName & ".Json", CurrentIntent.ToJson, True)
    End Sub
#End Region
End Class