Public Class frm_registrar_pedidos


    Private Sub frm_registrar_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_add_lista_Click(sender As Object, e As EventArgs) Handles btn_add_lista.Click

        If txt_codigo_produto.Text = "" Then
            MsgBox("Digite o codigo do produto corretamente", MsgBoxStyle.Critical + vbOKOnly, "Atenção")
        ElseIf rs.EOF = True Then
            sql = "select * from tb_produtos where codigo='" & txt_codigo_produto.Text & "'"
            rs = db.Execute(sql)
            MsgBox("Digite o codigo do produto corretamente", MsgBoxStyle.Critical + vbOKOnly, "Atenção")
        End If


        ' banco de dados pedidos
        ' povoar o banco de dados pelo coidigo e quantidade
        ' add lista povoar novo banco de dados com o dados que precisa

    End Sub
End Class