Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class BuscarCEP
    Public Shared Function Buscar(CEP As String) As Object

        Dim oWebRequest As WebRequest = WebRequest.Create("https://viacep.com.br/ws/" & CEP & "/json/")
        Dim oWebResponse As WebResponse = oWebRequest.GetResponse()

        Using objSR As New StreamReader(oWebResponse.GetResponseStream)
            Dim strBuffer As String = objSR.ReadToEnd
            Return JsonConvert.DeserializeObject(strBuffer)
        End Using

    End Function
End Class
