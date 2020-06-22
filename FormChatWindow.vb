Imports System.Web.UI.WebControls
Imports DialogManager.AI_Controllers.DialogControl

''' <summary>
''' Basic Test Window; Test the dialogs after creation with manager
''' </summary>
Public Class FormChatWIndow


    Public DM As DialogManager.AI_Controllers.DialogControl.DialogManager
    Public CurrentDialogs As List(Of iDialog)






    Private Sub ButtonSendQuery_Click(sender As Object, e As EventArgs) Handles ButtonSendQuery.Click
        If DM.MasterList.Count > 0 Then


            DM.SendQuery(UCase(TextBoxInput.Text))
            TextBoxOutput.Text &= TextBoxInput.Text & vbNewLine & DM.Response & vbNewLine
            ListBoxIntentHistory.Items.Clear()
            For Each item In DM.History
                ListBoxIntentHistory.Items.Add(item.IntentName)
            Next
            ListBoxCurrentIntents.Items.Clear()
            For Each item In DM.CurrentTopicList
                ListBoxCurrentIntents.Items.Add(item.IntentName)
            Next
            TextBoxDetectedIntent.Text = DM.DetectedIntent.IntentName
            TextBoxPreviousIntent.Text = DM.History(DM.History.Count - 1).IntentName
            ListBoxParameters.Items.Clear()
            For Each item In DM.CollectedParameters
                ListBoxParameters.Items.Add(item.ParameterName)
            Next
            TextBoxInput.Text = ""


        Else
            TextBoxOutput.Text = "Please create Intent Dialog items First"
            TextBoxInput.Text = ""
        End If
    End Sub

    Private Sub FormChatWIndow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DM = New AI_Controllers.DialogControl.DialogManager

        DM.ImportDialogs()
        CurrentDialogs = DM.Dialogs

        For Each item In CurrentDialogs
            For Each SubItem In item.AvailableIntents
                TextBoxViewIntent.Text = SubItem.ToJson
                DM.MasterList.Add(SubItem)
            Next
        Next
    End Sub

End Class
