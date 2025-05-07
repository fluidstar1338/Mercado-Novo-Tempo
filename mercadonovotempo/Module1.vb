Imports ADODB
Imports System.Data.SqlClient

Module Module1
    Public db As ADODB.Connection 'variavel do banco de dados 
    Public rs As ADODB.Recordset 'variavel da tabela
    Public sql, diretorio, cont As String 'variavel do query(gravar, excluir, alterar, consultar)
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB; Data Source=LAPTOP-HBL77MP8; initial catalog=mercado_novo_tempo;trusted_connection=yes;")
            MsgBox("Conexão ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro na conexão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub limpar_cadastro()
        With frm_registrar_cliente
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_cpf.Focus()
        End With
    End Sub

    Sub limpar_registro_login()
        With frm_login
            .txt_email.Text = ""
            .txt_senha.Text = ""
        End With
    End Sub

    Sub logar_gerente()
        Try
            With frm_login
                sql = "SELECT * FROM tb_login WHERE email='" & .txt_email.Text & "' AND senha='" & .txt_senha.Text & "'and cargo='gerente'"
                rs = db.Execute(sql)
                If rs.EOF = False Then

                    MsgBox("Usuário encontrado, abrindo o formulário...", MsgBoxStyle.Information)
                    frm_gerente.Show()
                    frm_login.Hide()
                End If
            End With

        Catch ex As Exception
            MsgBox("Email ou senha invalido!", MsgBoxStyle.Critical + vbOKOnly, "ATENÇÃO")
        End Try

    End Sub

    Sub logar_caixa()
        Try
            With frm_login
                sql = "SELECT * FROM tb_login WHERE email='" & .txt_email.Text & "' AND senha='" & .txt_senha.Text & "'AND cargo='caixa'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Usuário encontrado, abrindo o formulário...", MsgBoxStyle.Information)
                    frm_caixa.Show()
                    frm_login.Hide()
                End If
            End With

        Catch ex As Exception
            MsgBox("Email ou senha invalido!", MsgBoxStyle.Critical + vbOKOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub erro_logar()
        With frm_login
            sql = "Select * FROM tb_login WHERE email = '" & .txt_email.Text & "' And senha = '" & .txt_senha.Text & "' And (cargo ='repositor' OR cargo ='gerente' OR cargo='caixa')"

            'revisar esse codigo sql, acredito que esteja com ERRO!
            'parei aqui tentando fazer se os txt escrito estiverem errado, ent vai aparecer uma mensagem de erro
            'já resolvi :)
            rs = db.Execute(sql)
            If rs.EOF Then
                MsgBox("Email ou senha invalido!", MsgBoxStyle.Critical + vbOKOnly, "ATENÇÃO")
            End If
        End With
    End Sub

    Sub carregar_dados_funcionarios()
        With frm_ver_funcionarios.DataGridView1

            sql = "select * from tb_login order by nome asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value)

                rs.MoveNext()

            Loop
        End With
    End Sub

    Sub carregar_dados_clientes()
        With frm_ver_clientes.DataGridView1

            sql = "select * from tb_clientes order by nome asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()

            Loop
        End With
    End Sub
End Module


