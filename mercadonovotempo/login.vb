Public Class frm_login

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try

            If db Is Nothing OrElse db.State = 0 Then
                conectar_banco()
            End If

            ' Verificar o Recordset
            If rs Is Nothing Then
                rs = New ADODB.Recordset()
            End If

            If String.IsNullOrWhiteSpace(txt_email.Text) OrElse String.IsNullOrWhiteSpace(txt_senha.Text) Then
                MsgBox("Digite todos os campos corretamente!", MsgBoxStyle.Information + vbOKOnly, "ATENÇÃO")
                Exit Sub
            End If

            'sql = "select * from tb_login"
            'rs = db.Execute(sql)

            logar_gerente()

            logar_caixa()
            erro_logar()











        Catch ex As Exception
        MsgBox("Erro ao tentar Logar na conta! " & vbCrLf & "Detalhes: " & ex.Message, MsgBoxStyle.Critical + vbOKOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Close()
    End Sub

    Private Sub txt_email_DoubleClick(sender As Object, e As EventArgs) Handles txt_email.DoubleClick
        limpar_registro_login()
    End Sub


End Class