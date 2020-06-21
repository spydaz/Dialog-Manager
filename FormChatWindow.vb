Imports DialogManager.AI_Controllers.DialogControl

''' <summary>
''' Basic Test Window; Test the dialogs after creation with manager
''' </summary>
Public Class FormChatWIndow


    Public DM As New DialogManager.AI_Controllers.DialogControl.DialogManager
    Public CurrentDialogs As List(Of iDialog)


    Public Sub Strt()
        DM.ImportDialogs()
        CurrentDialogs = DM.Dialogs
        LoadDialogs(CurrentDialogs)
    End Sub

    Private Sub ButtonSendQuery_Click(sender As Object, e As EventArgs) Handles ButtonSendQuery.Click
        If DM.GetResponse(TextBoxInput.Text, TextBoxOutput.Text) = True Then

        End If
    End Sub

    Public Sub LoadDialogs(ByRef Dialogs As List(Of iDialog))
        CurrentDialogs = Dialogs
        For Each ItemDialog In Dialogs

            TextBoxViewIntent.Text &= ItemDialog.DialogName & " < LOADED" & vbNewLine
        Next
    End Sub
End Class
