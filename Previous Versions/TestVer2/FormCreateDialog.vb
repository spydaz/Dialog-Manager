Imports AI_SDK.DialogControl


Public Class FormCreateDialog
    Public Dialog As New  iDialog
#Region "Intents"
    Private WithEvents CreateIntent As FormCreateIntent
    Private Sub ButtonADDIntent_Click(sender As Object, e As EventArgs) Handles ButtonADDIntent.Click
        CreateIntent = New FormCreateIntent
        CreateIntent.Show()
        CreateIntent.LOAD_DIALOG(Dialog)
    End Sub
    Private Sub SAVE_INTENT(ByRef Sender As FormCreateIntent, ByRef NewIntent As iIntent) Handles CreateIntent.SAVE_INTENT
        Dialog.AvailableIntents.Add(NewIntent)
        ListBoxIntentsList.Items.Add(NewIntent.IntentName)
    End Sub
    Private Sub ButtonClearIntents_Click(sender As Object, e As EventArgs) Handles ButtonClearIntents.Click
        Dialog.AvailableIntents = New List(Of iIntent)
        ListBoxIntentsList.Items.Clear()
    End Sub
    Private Sub ButtonRemoveIntent_Click(sender As Object, e As EventArgs) Handles ButtonRemoveIntent.Click
        If ListBoxIntentsList.SelectedItem IsNot Nothing Then
            Try
                For Each item In Dialog.AvailableIntents
                    If item.IntentName = ListBoxIntentsList.SelectedItem Then
                        Dialog.AvailableIntents.Remove(item)
                        ListBoxIntentsList.Items.Remove(ListBoxIntentsList.SelectedItem)
                        Return
                    Else
                    End If
                Next
            Catch ex As Exception
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                MessageBox.Show(ex.Message, "ERROR", Buttons)
            End Try
        End If
    End Sub
    Private Sub ButtonEditIntent_Click(sender As Object, e As EventArgs) Handles ButtonEditIntent.Click
        If ListBoxIntentsList.SelectedItem IsNot Nothing Then
            Dim OldIntent As iIntent
            For Each item In Dialog.AvailableIntents
                If item.IntentName = ListBoxIntentsList.SelectedItem Then
                    OldIntent = item
                    Dialog.AvailableIntents.Remove(OldIntent)
                    CreateIntent = New FormCreateIntent
                    CreateIntent.Show()
                    CreateIntent.LOAD_DIALOG(Dialog)
                    CreateIntent.LOAD_INTENT(OldIntent)
                    ListBoxIntentsList.SelectedItems.Remove(OldIntent.IntentName)
                    Return
                Else
                End If
            Next
        Else
        End If
    End Sub
#End Region
#Region "EntityList"
    Public WithEvents CreateEntityList As FormCreatedNamedEntitys
    Public Sub SAVE_ENTITYLIST(ByRef Sender As FormCreatedNamedEntitys, ByRef NewEntities As iNamedEntitys) Handles CreateEntityList.SAVE_NAMED_ENTITYLIST
        CreateEntityList = New FormCreatedNamedEntitys
        Dialog.AvailableEntityLists.Add(NewEntities)
        ListBoxEntityLists.Items.Add(NewEntities.EntityListName)
    End Sub
    Private Sub ButtonADDEntityList_Click(sender As Object, e As EventArgs) Handles ButtonADDEntityList.Click
        If TextBoxEntityListName.Text IsNot "" Then
            CreateEntityList = New FormCreatedNamedEntitys
            CreateEntityList.Show()
            CreateEntityList.CREATE_LIST(TextBoxEntityListName.Text)
            TextBoxEntityListName.Clear()
        Else
        End If
    End Sub
    Private Sub ButtonClearEntityLists_Click(sender As Object, e As EventArgs) Handles ButtonClearEntityLists.Click
        'Is Dialog created
        If Dialog IsNot Nothing Then
            'Is List created
            If Dialog.AvailableEntityLists IsNot Nothing Then
                ListBoxEntityLists.Items.Clear()
                Dialog.AvailableEntityLists.Clear()
            Else
            End If
        Else
        End If
    End Sub
    Private Sub ButtonRemoveEntityList_Click(sender As Object, e As EventArgs) Handles ButtonRemoveEntityList.Click
        Try
            If ListBoxEntityLists.SelectedItem IsNot Nothing Then
                For Each item In Dialog.AvailableEntityLists
                    If ListBoxEntityLists.SelectedItem = item Then
                        Dialog.AvailableEntityLists.Remove(item)
                        ListBoxEntityLists.Items.Remove(item)
                    Else
                    End If
                Next
            Else
            End If
        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub
    Private Sub ButtonEditEntityList_Click(sender As Object, e As EventArgs) Handles ButtonEditEntityList.Click
        If ListBoxEntityLists.SelectedItem IsNot Nothing Then
            Try
                For Each item In Dialog.AvailableEntityLists
                    If item.EntityListName = ListBoxEntityLists.SelectedItem Then
                        CreateEntityList = New FormCreatedNamedEntitys
                        CreateEntityList.Show()
                        CreateEntityList.LOAD_LIST(item)
                        Dialog.AvailableEntityLists.Remove(item)
                        Return
                    Else
                    End If

                Next
            Catch ex As Exception
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
                MessageBox.Show(ex.Message, "ERROR", Buttons)
            End Try
        End If
    End Sub
#End Region
#Region "Dialog"
    Private Sub ButtonSaveDialog_Click(sender As Object, e As EventArgs) Handles ButtonSaveDialog.Click
        Try
            Dialog.DialogName = TextBoxDialogName.Text


            RaiseEvent SAVE_DIALOG(Me, Dialog)
            Me.WindowState = FormWindowState.Minimized
            Me.Close()
        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub
    ''' <summary>
    ''' Used to pass the dialog held to the calling object
    ''' </summary>
    ''' <param name="Sender">creator Form</param>
    ''' <param name="NewDialog">current dialog held</param>
    Public Event SAVE_DIALOG(ByRef Sender As FormCreateDialog, ByRef NewDialog As iDialog)
    Public Sub LOAD_DIALOG(ByRef NewDialog As iDialog)
        'SET DIALOG
        Me.Dialog = NewDialog
        'NAME
        Me.TextBoxDialogName.Text = NewDialog.DialogName

        'Available EntityLists
        If NewDialog.AvailableEntityLists IsNot Nothing Then
            For Each ItemList In NewDialog.AvailableEntityLists
                ListBoxEntityLists.Items.Add(ItemList.EntityListName)
            Next
        End If

        'Available Intents
        If NewDialog.AvailableIntents IsNot Nothing Then
            For Each item In NewDialog.AvailableIntents
                Me.ListBoxIntentsList.Items.Add(item.IntentName)
            Next
        End If


    End Sub
    Private Sub ButtonClearDialog_Click(sender As Object, e As EventArgs) Handles ButtonClearDialog.Click
        Me.Dialog = New iDialog(TextBoxDialogName.Text)
        Me.ListBoxEntityLists.Items.Clear()
        Me.ListBoxIntentsList.Items.Clear()
        Me.ListBoxPreviousResponses.Items.Clear()
        Me.ListBoxCurrentContext.Items.Clear()

    End Sub
    Public Sub CREATE_DIALOG(ByRef DialogName As String)
        Dialog = New iDialog(DialogName)
        TextBoxDialogName.Text = DialogName
    End Sub


#End Region
End Class