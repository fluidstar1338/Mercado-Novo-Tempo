Public Class frm_registrar_produto
    Private Sub frm_registrar_produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_gerente.Show()
        Me.Close()
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        sql = "SELECT * FROM tb_produtos WHERE codigo='" & txt_codigo_produto.Text & "'"
        rs = db.Execute(sql)
        If txt_codigo_produto.Text = "" Or txt_nome_produto.Text = "" Or txt_preco_produto.Text = "" Or txt_quantidade_produto.Text = "" Then
            MsgBox("Digite todos os campos corretamente!", MsgBoxStyle.Critical + vbOKOnly, "ATENÇÂO")

        Else
            If rs.EOF = True Then
                sql = "INSERT INTO tb_produtos VALUES('" & txt_codigo_produto.Text & "', '" & txt_nome_produto.Text & "', '" & txt_quantidade_produto.Text & "', '" & txt_preco_produto.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Produtos cadastrados corretamente!", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
                txt_codigo_produto.Text = ""
                txt_nome_produto.Text = ""
                txt_preco_produto.Text = ""
                txt_quantidade_produto.Text = ""
            Else
                MsgBox("Produto já cadastrado com sucesso!", MsgBoxStyle.Critical + vbOKOnly, "ATENÇÂO")
                txt_codigo_produto.Text = ""
                txt_nome_produto.Text = ""
                txt_preco_produto.Text = ""
                txt_quantidade_produto.Text = ""
            End If
        End If

    End Sub

    Private Sub btn_deletar_produtos_Click(sender As Object, e As EventArgs) Handles btn_deletar_produtos.Click

        If txt_codigo_produto.Text = "" Then
            MsgBox("Digite o codigo do produto corretamente!", MsgBoxStyle.Critical + vbOKOnly, "ATENÇÂO")
            txt_codigo_produto.Text = ""
            txt_nome_produto.Text = ""
            txt_preco_produto.Text = ""
            txt_quantidade_produto.Text = ""
            txt_codigo_produto.Focus()
        Else
            sql = "SELECT * FROM tb_produtos WHERE codigo='" & txt_codigo_produto.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "DELETE FROM tb_produtos WHERE codigo='" & txt_codigo_produto.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Produto deletado corretamente!", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
                txt_codigo_produto.Text = ""
                txt_nome_produto.Text = ""
                txt_preco_produto.Text = ""
                txt_quantidade_produto.Text = ""
            Else
                MsgBox("Produto não existe!", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
                txt_codigo_produto.Text = ""
                txt_nome_produto.Text = ""
                txt_preco_produto.Text = ""
                txt_quantidade_produto.Text = ""
            End If
        End If
    End Sub
End Class