Public Class TAmbiente
    Property xnomefir As String
    Property xsystemname As String
    Property xsystemversao As String
    Property xcabec As String
    Shared Property path As String = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)

    Public Sub New()
        xnomefir = "MACROSOFT SISTEMAS DE INFORMATICA LTDA"
        xsystemname = "Macrosoft SCI for Windows"
        xsystemversao = "v1.0"
        xcabec = xsystemname
    End Sub
End Class
