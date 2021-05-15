Imports System.Windows.Forms

Public Class TFuncoes
    Shared Sub informa(cMsg As String)
        MessageBox.Show(cMsg, "Text", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Shared Sub ErrorBeep(cMsg As String)
        MessageBox.Show(cMsg, "Text", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
