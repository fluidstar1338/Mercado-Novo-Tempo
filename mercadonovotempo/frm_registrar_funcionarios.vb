Public Class frm_registrar_funcionarios
    Private Sub btn_criar_atualizar_Click(sender As Object, e As EventArgs) Handles btn_criar_atualizar.Click
        sql = "SELECT * FROM tb_login WHERE cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)

        If txt_cargo.Text = "" Or txt_cep.Text = "" Or txt_cpf.Text = "" Or txt_email.Text = "" Or txt_nome.Text = "" Or txt_numero_casa.Text = "" Or txt_senha.Text = "" Or txt_telefone.Text = "" Then
            MsgBox("Digite todas informações corretamente!", MsgBoxStyle.Critical + vbOKOnly, "ATENÇÃO")
        Else

            If rs.EOF = True Then
                ' Se não encontrou registros, insere no banco de dados
                sql = "INSERT INTO tb_login (cargo, cpf, nome, email, senha, telefone, cep, numero_casa) VALUES('" & txt_cargo.Text & "', '" & txt_cpf.Text & "', '" & txt_nome.Text & "', '" & txt_email.Text & "', '" & txt_senha.Text & "', '" & txt_telefone.Text & "', '" & txt_cep.Text & "', '" & txt_numero_casa.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Funcionário cadastrado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "ATENÇÃO")
            Else
                ' Caso o registro já exista
                MsgBox("Este funcionário já está cadastrado!", MsgBoxStyle.Critical + vbOKOnly, "ATENÇÃO")
            End If
        End If


    End Sub

    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click

        If rs.EOF = True Then
                MsgBox("Funcionario não existe!", MsgBoxStyle.Information + vbOKOnly, "ATENÇÃO")
            Else
                sql = "DELETE FROM tb_login WHERE cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Funcionario deletado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "ATENÇÃO")
            End If

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_crud.Show()
        Me.Close()
    End Sub
End Class