Imports System.ComponentModel
Imports DialogManager.AI_Controllers

Public Class FormCreateEntity
    Public Event SaveList(ByRef EntityList As NamedEntitys)
    Private EntityList As NamedEntitys
    Private NewEntity As Entity

    Public Sub SetList(ByRef nEntityList As NamedEntitys)
        EntityList = nEntityList
        For Each item In nEntityList.Entitys
            ListBoxEntitys.Items.Add(item.ParameterName)
        Next
        TextBoxAddPrompt.Text = nEntityList.ParameterPrompt
        TextBoxEntityListName.Text = nEntityList.EntityListName
        NewEntity = New Entity With {
            .EntityListName = nEntityList.EntityListName
        }
    End Sub

    Private Sub FormCreateEntity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewEntity = New Entity
        EntityList = New NamedEntitys
    End Sub


    Private Sub ButtonAddEntity_Click(sender As Object, e As EventArgs) Handles ButtonAddEntity.Click
        NewEntity.EntityListName = EntityList.EntityListName
        NewEntity.ParameterName = UCase(TextBoxAddParameter.Text)
        NewEntity.Trigger = UCase(TextBoxAddTrigger.Text)
        EntityList.Entitys.Add(NewEntity)
        ListBoxEntitys.Items.Add(NewEntity.ParameterName)

        NewEntity = New Entity With {
            .EntityListName = EntityList.EntityListName
        }

        TextBoxAddParameter.Text = ""
        TextBoxAddTrigger.Text = ""

    End Sub

    Private Sub ButtonClearEntity_Click(sender As Object, e As EventArgs) Handles ButtonClearEntity.Click
        TextBoxAddParameter.Text = ""
        TextBoxAddTrigger.Text = ""
    End Sub

    Private Sub Buttonclose_Click(sender As Object, e As EventArgs) Handles Buttonclose.Click
        Me.Close()
    End Sub

    Private Sub FormCreateEntity_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        RaiseEvent SaveList(EntityList)
    End Sub

    Private Sub ButtonClearList_Click(sender As Object, e As EventArgs) Handles ButtonClearList.Click
        EntityList = New NamedEntitys
        ListBoxEntitys.Items.Clear()
        TextBoxEntityListName.Text = ""
        TextBoxAddPrompt.Text = ""

    End Sub

    Private Sub ButtonRemoveEntity_Click(sender As Object, e As EventArgs) Handles ButtonRemoveEntity.Click
        For Each item In EntityList.Entitys
            If item.ParameterName = ListBoxEntitys.SelectedItem Then
                EntityList.Entitys.Remove(item)
                ListBoxEntitys.Items.Remove(ListBoxEntitys.SelectedItem)
                Return
            End If
        Next
    End Sub

    Private Sub ButtonEditEntity_Click(sender As Object, e As EventArgs) Handles ButtonEditEntity.Click
        For Each item In EntityList.Entitys
            If item.EntityListName = UCase(ListBoxEntitys.SelectedItem) Then
                NewEntity = item
                TextBoxAddParameter.Text = NewEntity.ParameterName
                TextBoxAddTrigger.Text = NewEntity.Trigger
                EntityList.Entitys.Remove(item)
                Return
            End If
        Next
    End Sub

    Private Sub ButtonExportJson_Click(sender As Object, e As EventArgs) Handles ButtonExportJson.Click
        Dim Str As String = ""
        For Each item In EntityList.Entitys
            Str &= item.ToJson
            SaveJsonFile(Str)
        Next
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        EntityList.EntityListName = UCase(TextBoxEntityListName.Text)
        EntityList.ParameterPrompt = UCase(TextBoxAddPrompt.Text)

    End Sub
End Class