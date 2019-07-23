Imports System.Data.SqlClient

Namespace DB
    Public Class Database

        Public Conexao As String = ""

        Public Function Execute(sSQL As String, Optional ParametrosIN(,) As Object = Nothing) As DataSet

            Dim da As New SqlDataAdapter
            Dim ds As New DataSet

            Dim Parse As New AtlantaSistemas.Utils2.Class.Parse

            Using cn As New SqlConnection(Conexao)
                Using cmd As New SqlCommand("", cn)

                    With cmd
                        .Connection.Open()

                        If sSQL <> "" Then
                            .CommandText = sSQL
                        End If

                        If Not IsNothing(ParametrosIN) Then
                            For i As Integer = 0 To ParametrosIN.GetUpperBound(0)
                                .Parameters.AddWithValue(Convert.ToString(ParametrosIN(i, 0)), Parse.IsEmpty(ParametrosIN(i, 1))).SqlDbType = CType(ParametrosIN(i, 2), SqlDbType)
                            Next
                        End If

                        da = New SqlDataAdapter(cmd)
                        da.Fill(ds)

                        Return ds

                    End With
                End Using
            End Using

        End Function

    End Class
End Namespace