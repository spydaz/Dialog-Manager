﻿Imports AI_SDK.DialogControl



Public Class FormManageDialogs
    ''' <summary>
    ''' Currently Held Dialogs
    ''' </summary>
    Private AvailableDialogs As New List(Of iDialog)
    Public Event SAVE_DIALOGS(ByRef Sender As FormManageDialogs, ByRef Dialogs As List(Of iDialog))
    ''' <summary>
    ''' Create New Dialog (FORM)
    ''' </summary>
    Private WithEvents CreateDialog As FormCreateDialog
    Private Sub FormManageDialogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AvailableDialogs = New List(Of iDialog)
    End Sub
    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        If TextBoxDialogName.Text IsNot "" Then
            CreateDialog = New FormCreateDialog
            CreateDialog.Show()
            CreateDialog.CREATE_DIALOG(TextBoxDialogName.Text)
            TextBoxDialogName.Clear()
        Else
        End If
    End Sub
    Private Sub SAVE_DIALOG(ByRef Sender As FormCreateDialog, ByRef NewDialog As iDialog) Handles CreateDialog.SAVE_DIALOG
        AvailableDialogs.Add(NewDialog)
        ListBoxDialogs.Items.Add(NewDialog.DialogName)
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ListBoxDialogs.Items.Clear()
        AvailableDialogs = New List(Of iDialog)
    End Sub
    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        For Each item In AvailableDialogs
            If item.DialogName = ListBoxDialogs.SelectedItem Then
                AvailableDialogs.Remove(item)
                CreateDialog = New FormCreateDialog
                CreateDialog.Show()
                CreateDialog.LOAD_DIALOG(item)
                ListBoxDialogs.Items.Remove(item.DialogName)
                Return
            Else
            End If
        Next
    End Sub
    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If ListBoxDialogs.SelectedItem IsNot Nothing Then
            Try
                For Each item In AvailableDialogs
                    If item.DialogName = ListBoxDialogs.SelectedItem Then
                        AvailableDialogs.Remove(item)
                        ListBoxDialogs.Items.Remove(item.DialogName)
                        Return
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
    Private Sub ButtonExportJson_Click(sender As Object, e As EventArgs) Handles ButtonExportJson.Click
        Try
            For Each item In AvailableDialogs
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Dialogs\" & item.DialogName & ".Json", item.ToJson(), True)
            Next
        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub
    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Try
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Dialogs\", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.Json")
                Dim Str = My.Computer.FileSystem.ReadAllText(foundFile)
                Dim diag As iDialog = iDialog.FromJson(Str)
                AvailableDialogs.Add(diag)
                ListBoxDialogs.Items.Add(diag.DialogName)
            Next
        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub

End Class