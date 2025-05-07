Public Class frm_crud


    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_gerente.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_registrar_cliente.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_registrar_funcionarios.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_ver_funcionarios.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_ver_clientes.Show()
        Me.Close()

    End Sub

    Private Sub btn_registrar_produto_Click(sender As Object, e As EventArgs) Handles btn_registrar_produto.Click
        frm_registrar_produto.Show()
        Me.Close()
    End Sub
End Class