Public Class frm_registrar_cliente

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_crud.Show()
        Me.Close()

    End Sub

    Private Sub btn_criar_atualizar_Click(sender As Object, e As EventArgs) Handles btn_criar_atualizar.Click
        sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF Then
            If txt_cpf.Text = "" Or txt_nome.Text = "" Or txt_cep.Text = "" Or txt_data_pagamento.Text = "" Or txt_telefone.Text = "" Or txt_numero_casa.Text = "" Then
                MsgBox("Digite totas as opções para salvar corretamente!", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
            Else

                sql = "INSERT INTO tb_clientes (cpf, nome, data_pagamento, cep, numero_casa, telefone) VALUES ('" & txt_cpf.Text & "','" & txt_nome.Text & "', '" & txt_data_pagamento.Text & "','" & txt_cep.Text & "', '" & txt_numero_casa.Text & "',  '" & txt_telefone.Text & "');"
                rs = db.Execute(sql)

                MsgBox("Dados gravados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso!")

            End If
        Else
            MsgBox("Conta já existe!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso!")
        End If
    End Sub

    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click
        sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF Then
            If txt_cpf.Text = "" Or txt_nome.Text = "" Or txt_cep.Text = "" Or txt_data_pagamento.Text = "" Or txt_telefone.Text = "" Or txt_numero_casa.Text = "" Then
                MsgBox("Digite totas as opções para salvar corretamente!", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
            Else

                MsgBox("Conta não existe!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso!")
            End If
        End If
        If rs.EOF = False Then

            sql = "DELETE from tb_clientes WHERE cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            MsgBox("Dados apagados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso!")

        End If

    End Sub
End Class