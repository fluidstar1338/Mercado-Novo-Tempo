Public Class frm_caixa


    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        frm_login.Show()
        With frm_login
            limpar_registro_login()
        End With
        Me.Close()
    End Sub

    Private Sub btn_registrar_pedido_Click(sender As Object, e As EventArgs) Handles btn_registrar_pedido.Click
        frm_registrar_pedidos.Show()
        Me.Close()
    End Sub
End Class