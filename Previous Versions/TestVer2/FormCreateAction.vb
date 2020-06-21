Imports AI_SDK.DialogControl

Public Class FormCreateAction
    Public Event SAVE_ACTION(ByRef Sender As FormCreateAction, ByRef Act As iAction)

    Public Act As iAction

    Private Sub ButtonSaveGeneratedOutputParamter_Click(sender As Object, e As EventArgs) Handles ButtonSaveGeneratedOutputParamter.Click
        Act = New iAction
        Try
            If TextBoxActionName.Text <> "" Then
                Act.Response = TextBoxResponse.Text
                Act.ActionScript = TextBoxActionScript.Text
                Act.FulfilmentName = TextBoxActionName.Text
                RaiseEvent SAVE_ACTION(Me, Act)
                Me.Close()
            End If
        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
    End Sub
    Private Sub ButtonActionScriptClear_Click(sender As Object, e As EventArgs) Handles ButtonActionScriptClear.Click
        TextBoxActionScript.Clear()
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class