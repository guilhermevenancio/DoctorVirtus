Imports System.Data.SqlClient
Imports System.Threading

Public Class FrmReconectando

    Private Sub FrmReconectando_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\carregando.gif")

            Dim t1 As New Thread(New ThreadStart(AddressOf Reconectar))
            t1.Start()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnDetalhes_Click(sender As Object, e As EventArgs) Handles BtnDetalhes.Click

        Me.Close()

    End Sub

    Private Sub Reconectar()

        'UsuarioLogado.Reconectando = False

TentaNovamente:

        Try

            Using cn As New SqlConnection(Database.Conexao)
                Using cmd As New SqlCommand("", cn)
                    Try
                        With cmd
                            .Connection.Open()
                            .CommandText = "SELECT 1;"
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        GoTo TentaNovamente
                    End Try
                End Using
            End Using

            'UsuarioLogado.Reconectando = True

            Me.Invoke(New MethodInvoker(AddressOf Fechar))

        Catch ex As Exception
            GoTo TentaNovamente
        End Try

    End Sub

    Private Sub Fechar()
        Me.Close()
    End Sub

End Class