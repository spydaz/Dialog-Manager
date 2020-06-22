Imports DialogManager.AI_Controllers.DialogControl

''' <summary>
''' Basic Test Window; Test the dialogs after creation with manager
''' </summary>
Public Class FormChatWIndow


    Public DM As New DialogManager.AI_Controllers.DialogControl.DialogManager
    Public CurrentDialogs As List(Of iDialog)


    Public Sub Strt()
        CurrentDialogs = New List(Of iDialog)
        DM.ImportDialogs()
        CurrentDialogs = DM.Dialogs
        LoadDialogs(CurrentDialogs)

        For Each Item In CurrentDialogs
            TextBoxViewIntent.Text &= Item.ToJson
        Next

    End Sub

    Private Sub ButtonSendQuery_Click(sender As Object, e As EventArgs) Handles ButtonSendQuery.Click
        Dim Response As String = ""
        Dim UserIn As String = UCase(TextBoxInput.Text)
        If DM.GetResponse(UserIn, Response) = True Then
            TextBoxInput.Text = ""
            TextBoxOutput.Text = Response
        Else
        End If
    End Sub

    Public Sub LoadDialogs(ByRef Dialogs As List(Of iDialog))
        CurrentDialogs = Dialogs
        For Each ItemDialog In Dialogs

            TextBoxViewIntent.Text &= ItemDialog.DialogName & " < LOADED" & vbNewLine
        Next
    End Sub

    Private Sub FormChatWIndow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Strt()
    End Sub
End Class
