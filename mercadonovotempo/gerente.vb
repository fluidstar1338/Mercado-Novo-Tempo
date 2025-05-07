Public Class frm_gerente
    Private Sub btn_crud_Click(sender As Object, e As EventArgs) Handles btn_crud.Click
        frm_crud.Show()
        Me.Close()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        frm_login.Show()
        Me.Close()

        With frm_login
            limpar_registro_login()
        End With


    End Sub


End Class