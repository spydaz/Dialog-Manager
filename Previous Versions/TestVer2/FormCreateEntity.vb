Imports AI_SDK.DialogControl

Public Class FormCreateEntity
    Private CurrentEntity As New iEntity
    Public Event SAVE_ENTITY(ByRef Sender As FormCreateEntity, ByRef NewEntity As iEntity)

    Private Sub ButtonADD_Click(sender As Object, e As EventArgs) Handles ButtonADD.Click
        CurrentEntity.ParameterName = UCase(TextBoxParameterName.Text)
        CurrentEntity.Trigger = UCase(TextBoxParameterTrigger.Text)
        RaiseEvent SAVE_ENTITY(Me, CurrentEntity)
        Me.Close()
    End Sub

    Private Sub ButtonClearEntity_Click(sender As Object, e As EventArgs) Handles ButtonClearEntity.Click
        TextBoxParameterName.Text = ""
        TextBoxParameterTrigger.Text = ""
    End Sub
End Class
