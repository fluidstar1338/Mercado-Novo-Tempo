Public Class frm_ver_clientes
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_crud.Show()
        Me.Close()

    End Sub

    Private Sub frm_ver_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados_clientes()
    End Sub
End Class