Imports System.ComponentModel
Imports DialogManager.AI_Controllers


Public Class FormDialogMangement
    Private DM As New AI_Controllers.DialogManager
    Private WithEvents CreateNewEntityList As FormCreateEntity
    Private WithEvents CreateNewIntent As FormCreateIntent
#Region "Form"
    Private Sub FormDialogMangement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.FirstLoad = True
        DM = New AI_Controllers.DialogManager
        FirstLoad()
        Reload()
    End Sub
    Public Sub Reset()
        ListBoxMasterList.Items.Clear()
        ListBoxNamedEntitys.Items.Clear()
        ListBoxEntitys.Items.Clear()
        TextBoxViewIntent.Text = ""
        ListBoxIntentHistory.Items.Clear()
        ListBoxParameters.Items.Clear()
        TextBoxDetectedIntent.Text = ""
        TextBoxPreviousIntent.Text = ""
    End Sub

    Public Sub Reload()
        TextBoxViewIntent.Text = ""
        ListBoxMasterList.Items.Clear()

        For Each item In DM.MasterList
            ListBoxMasterList.Items.Add(item.IntentName)
        Next
        For Each item In DM.EntityLists
            ListBoxNamedEntitys.Items.Add(item.EntityListName)
        Next
    End Sub
    Public Sub FirstLoad()
        If My.Settings.FirstLoad = True Then
            My.Settings.ENTITYS = New List(Of NamedEntitys)
            My.Settings.MASTERLIST = New List(Of Intent)
            If My.Settings.ENTITYS Is Nothing Then My.Settings.ENTITYS = New List(Of NamedEntitys)
            If My.Settings.MASTERLIST Is Nothing Then My.Settings.MASTERLIST = New List(Of Intent)
            My.Settings.FirstLoad = False
        Else
            If My.Settings.ENTITYS Is Nothing Then My.Settings.ENTITYS = New List(Of NamedEntitys)
            If My.Settings.MASTERLIST Is Nothing Then My.Settings.MASTERLIST = New List(Of Intent)
            DM.EntityLists = My.Settings.ENTITYS
            DM.MasterList = My.Settings.MASTERLIST
        End If
    End Sub


#End Region
#Region "Buttons"
#Region "Main"
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
#End Region
    Private Sub ButtonAddEntityList_Click(sender As Object, e As EventArgs) Handles ButtonAddEntityList.Click
        CreateNewEntityList = New FormCreateEntity
        CreateNewEntityList.Show()
        Dim NewEnt As New NamedEntitys With {
            .EntityListName = "NewList"
        }
        CreateNewEntityList.SetList(NewEnt)

    End Sub
    Private Sub ButtonAddIntent_Click(sender As Object, e As EventArgs) Handles ButtonAddIntent.Click
        CreateNewIntent = New FormCreateIntent
        CreateNewIntent.Show()
        CreateNewIntent.SetMasterLst(DM.MasterList)
        CreateNewIntent.SetEntitys(DM.EntityLists)
    End Sub
    Private Sub ButtonEditEntityList_Click(sender As Object, e As EventArgs) Handles ButtonEditEntityList.Click
        Dim str As String = ListBoxNamedEntitys.SelectedItem

        For Each item In DM.EntityLists
            If item.EntityListName = str Then
                CreateNewEntityList = New FormCreateEntity
                CreateNewEntityList.Show()
                CreateNewEntityList.SetList(item)
                DM.EntityLists.Remove(item)
                ListBoxNamedEntitys.Items.Remove(item.EntityListName)
                ListBoxEntitys.Items.Clear()
                Return
            Else
            End If
        Next
    End Sub
    Private Sub ButtonEditIntent_Click(sender As Object, e As EventArgs) Handles ButtonEditIntent.Click
        Dim Intention As String = ListBoxMasterList.SelectedItem
        For Each item In DM.MasterList
            If item.IntentName = ListBoxMasterList.SelectedItem = True Then
                CreateNewIntent = New FormCreateIntent
                CreateNewIntent.Show()
                CreateNewIntent.SetMasterLst(DM.MasterList)
                CreateNewIntent.SetEntitys(DM.EntityLists)
                CreateNewIntent.SetIntent(item)
                DM.MasterList.Remove(item)
                Return
            Else
            End If
        Next
    End Sub
    Private Sub SaveList(ByRef Masterlist As List(Of Intent)) Handles CreateNewIntent.SaveList
        DM.MasterList = Masterlist
        ListBoxMasterList.Items.Clear()
        For Each item In DM.MasterList
            ListBoxMasterList.Items.Add(item.IntentName)
        Next
    End Sub
    Private Sub SaveList(ByRef EntityList As NamedEntitys) Handles CreateNewEntityList.SaveList
        If EntityList.EntityListName IsNot Nothing Then
            DM.EntityLists.Add(EntityList)
            ListBoxNamedEntitys.Items.Clear()
            For Each item In DM.EntityLists
                ListBoxNamedEntitys.Items.Add(item.EntityListName)
                ListBoxEntitys.Items.Clear()
            Next
        End If
    End Sub
    Private Sub ButtonClearEntityList_Click(sender As Object, e As EventArgs) Handles ButtonClearEntityList.Click
        ListBoxNamedEntitys.Items.Clear()
        DM.EntityLists = New List(Of NamedEntitys)
    End Sub
    Private Sub ButtonClearIntents_Click(sender As Object, e As EventArgs) Handles ButtonClearIntents.Click
        ListBoxMasterList.Items.Clear()
        DM.MasterList = New List(Of Intent)
        My.Settings.MASTERLIST = New List(Of Intent)
    End Sub
    Private Sub ButtonRemoveIntent_Click(sender As Object, e As EventArgs) Handles ButtonRemoveIntent.Click
        Dim Str As String = ListBoxMasterList.SelectedItem
        For Each item In DM.MasterList
            If item.IntentName = Str Then
                DM.MasterList.Remove(item)
                ListBoxMasterList.Items.Remove(Str)
                Return
            Else
            End If
        Next
    End Sub
    Private Sub ButtonRemoveEntityList_Click(sender As Object, e As EventArgs) Handles ButtonRemoveEntityList.Click
        Dim Str As String = ListBoxNamedEntitys.SelectedItem
        For Each item In DM.EntityLists
            If item.EntityListName = Str Then
                ListBoxNamedEntitys.Items.Remove(Str)
                DM.EntityLists.Remove(item)
                Return
            Else
            End If
        Next
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
    Private Sub ButtonSaveMemory_Click(sender As Object, e As EventArgs) Handles ButtonSaveMemory.Click
        My.Settings.SaveDialogManager = DM
        Reset()
    End Sub
    Private Sub ButtonLoadMemory_Click(sender As Object, e As EventArgs) Handles ButtonLoadMemory.Click
        DM = My.Settings.SaveDialogManager
        'wipe memory/reset
        My.Settings.FirstLoad = True
        FirstLoad()
        Reload()
    End Sub
    Private Sub ButtonAddEntity_Click(sender As Object, e As EventArgs) Handles ButtonAddEntity.Click
        If ListBoxNamedEntitys.SelectedItem IsNot Nothing Then
            Dim str As String = ListBoxNamedEntitys.SelectedItem
            For Each item In DM.EntityLists
                If item.EntityListName = str Then
                    CreateNewEntityList = New FormCreateEntity
                    CreateNewEntityList.Show()
                    CreateNewEntityList.SetList(item)
                    DM.EntityLists.Remove(item)
                    ListBoxNamedEntitys.Items.Remove(item.EntityListName)
                    ListBoxEntitys.Items.Clear()
                    Return
                Else
                End If
            Next
        Else
        End If
    End Sub
    Private Sub ButtonRemoveEntity_Click(sender As Object, e As EventArgs) Handles ButtonRemoveEntity.Click
        If ListBoxNamedEntitys.SelectedItem IsNot Nothing Then
            Dim str As String = ListBoxNamedEntitys.SelectedItem
            'get list
            For Each lst In DM.EntityLists
                If lst.EntityListName = str Then
                    ''get parameter
                    For Each item In lst.Entitys
                        If item.ParameterName = ListBoxEntitys.SelectedItem Then
                            lst.Entitys.Remove(item)
                            ListBoxEntitys.Items.Remove(ListBoxEntitys.SelectedItem)
                            Return
                        Else
                        End If
                    Next
                End If
            Next
        Else
        End If

    End Sub
    Private Sub ButtonClearEntitys_Click(sender As Object, e As EventArgs) Handles ButtonClearEntitys.Click
        If ListBoxNamedEntitys.SelectedItem IsNot Nothing Then
            Dim str As String = ListBoxNamedEntitys.SelectedItem
            'get list
            For Each lst In DM.EntityLists
                If lst.EntityListName = str Then
                    lst.Entitys = New List(Of Entity)
                End If
            Next
        Else
        End If
    End Sub
#End Region
#Region "View Data"
    Private Sub ListBoxMasterList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMasterList.SelectedIndexChanged
        Try
            TextBoxViewIntent.Text = ""
            For Each item In DM.MasterList
                If item.IntentName = ListBoxMasterList.SelectedItem Then
                    TextBoxViewIntent.Text &= vbNewLine & item.ToJson()
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListBoxNamedEntitys_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNamedEntitys.SelectedIndexChanged
        Dim str As String = ListBoxNamedEntitys.SelectedItem
        ListBoxEntitys.Items.Clear()
        TextBoxViewIntent.Text = ""
        For Each item In DM.EntityLists
            If item.EntityListName = str Then
                For Each SubItem In item.Entitys
                    ListBoxEntitys.Items.Add(SubItem.ParameterName)
                    TextBoxViewIntent.Text &= SubItem.ToJson & vbNewLine
                Next
            End If
        Next
    End Sub
    Private Sub ListBoxIntentHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxIntentHistory.SelectedIndexChanged
        Try
            TextBoxViewIntent.Text = ""
            For Each item In DM.History
                If item.IntentName = ListBoxIntentHistory.SelectedItem Then
                    TextBoxViewIntent.Text = vbNewLine & item.ToJson()
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListBoxCurrentIntents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCurrentIntents.SelectedIndexChanged
        Try
            TextBoxViewIntent.Text = ""
            For Each item In DM.CurrentTopicList
                If ListBoxCurrentIntents.SelectedItem = item.IntentName Then
                    TextBoxViewIntent.Text = vbNewLine & item.ToJson
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListBoxParameters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxParameters.SelectedIndexChanged
        Try

            For Each item In DM.CollectedParameters
                If item.EntityListName = ListBoxParameters.SelectedItem Then
                    TextBoxViewIntent.Text &= vbNewLine & item.ToJson()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ListBoxEntitys_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEntitys.SelectedIndexChanged
        If ListBoxNamedEntitys.SelectedItem IsNot Nothing Then
            Dim str As String = ListBoxNamedEntitys.SelectedItem
            'get list
            For Each lst In DM.EntityLists
                If lst.EntityListName = str Then
                    ''get parameter
                    For Each item In lst.Entitys
                        If item.ParameterName = ListBoxEntitys.SelectedItem Then
                            TextBoxViewIntent.Text = item.ToJson
                            Return
                        Else
                        End If
                    Next
                End If
            Next
        Else
        End If
    End Sub
#End Region
End Class
