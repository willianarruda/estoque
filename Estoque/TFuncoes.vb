Public Class TFuncoes
    Shared Property xnomefir As String = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)

    Shared Function Conf(cMsg As String) As Boolean
        If MessageBox.Show(cMsg, "Text", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Shared Sub info(cMsg As String)
        MessageBox.Show(cMsg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Shared Sub informa(cMsg As String)
        MessageBox.Show(cMsg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Shared Sub ErrorBeep(cMsg As String)
        MessageBox.Show(cMsg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
