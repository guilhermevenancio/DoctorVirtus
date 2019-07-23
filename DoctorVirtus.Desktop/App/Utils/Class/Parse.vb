Imports System.IO

Namespace AtlantaSistemas.Utils2.Class

    Public Class Parse

        Public Function IsEmpty(Value As String) As Object

            Try

                If Trim(Value) = "" Then
                    Return DBNull.Value
                Else
                    Return Trim(Value)
                End If

            Catch ex As Exception
                Return DBNull.Value
            End Try

        End Function

        Public Function IsEmpty(Value As Object) As Object

            Try

                If Trim(Convert.ToString(Value)) Is "" Then
                    Return DBNull.Value
                Else
                    Return Value
                End If

            Catch ex As Exception
                Return DBNull.Value
            End Try

        End Function

#Disable Warning BC40005 ' O membro sombreia um método substituível no tipo base
        Public Function ToString(Value As Object) As String
#Enable Warning BC40005 ' O membro sombreia um método substituível no tipo base

            Try

                If IsDBNull(Value) Then
                    Return Nothing
                Else
                    Return Trim(Convert.ToString(Value))
                End If

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function ToInt(Value As Object) As Integer?
            Try

                If Not IsNumeric(Value) Then
                    Return Nothing
                Else
                    Return Convert.ToInt32(Value)
                End If

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function ToBoolean(Value As Object) As Boolean

            Try

                If IsDBNull(Value) Then
                    Return False
                Else
                    Return Convert.ToBoolean(Value)
                End If

            Catch ex As Exception
                Return False
            End Try

        End Function

        Public Function ToDecimal(Value As Object, Optional CasasDecimais As Integer = 2) As Decimal

            Try

                If IsDBNull(Value) Then
                    Return 0
                Else
                    If Not IsNumeric(Value) Then
                        Return 0
                    End If

                    If IsNothing(CasasDecimais) Then
                        Return Convert.ToDecimal(Value)
                    End If

                    Return Math.Round(Value, CasasDecimais) 'String.Format("{0:N" & CasasDecimais & "}", Convert.ToDecimal(Value))

                End If

            Catch ex As Exception
                Return 0
            End Try

        End Function

        Public Function ToDateTime(Value As Object) As DateTime

            Try

                If IsDBNull(Value) Then
                    Return Nothing
                Else
                    Return Convert.ToDateTime(Value)
                End If

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function ToByte(Value As Object) As Byte()

            Try

                If IsDBNull(Value) Then
                    Return Nothing
                Else

                    Dim Arquivo As Byte() = Value

                    Return Arquivo
                End If

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

    End Class

End Namespace