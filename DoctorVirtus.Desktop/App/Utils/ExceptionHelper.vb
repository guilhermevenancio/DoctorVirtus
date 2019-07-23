Public Module ExceptionHelper
    <Runtime.CompilerServices.Extension>
    Public Function LineNumber(e As Exception) As Integer
        Dim linenum As Integer = 0
        Try
            Dim stack As String = e.StackTrace
            Dim lineIndex As Integer = stack.LastIndexOf(":linha")
            Dim lineStr As String = stack.Substring(lineIndex)
            lineStr = Split(lineStr, " ")(1)
            linenum = Integer.Parse(lineStr)
        Catch
        End Try
        Return linenum
    End Function
End Module