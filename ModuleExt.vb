Imports DialogManager.AI_Controllers.DialogControl

Module ModuleExt
    ''' <summary>
    ''' Get random Intent from the list
    ''' </summary>
    ''' <param name="Intents"> </param>
    ''' <returns> </returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetRandomIntent(ByRef Intents As List(Of iIntent)) As iIntent
        GetRandomIntent = New iIntent
        Dim Count As Integer = Intents.Count
        If Count > 0 Then
            If Count = 1 Then
                GetRandomIntent = Intents(0)
            Else
                GetRandomIntent = Intents(Rnd(Count - 1))
            End If
        Else
        End If
    End Function
End Module
