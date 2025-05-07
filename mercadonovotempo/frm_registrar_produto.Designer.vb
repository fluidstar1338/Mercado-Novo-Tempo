<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_produto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_produto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_codigo_produto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome_produto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_quantidade_produto = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txt_preco_produto = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.btn_deletar_produtos = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Codigo do produto"
        '
        'txt_codigo_produto
        '
        Me.txt_codigo_produto.Location = New System.Drawing.Point(26, 226)
        Me.txt_codigo_produto.Multiline = True
        Me.txt_codigo_produto.Name = "txt_codigo_produto"
        Me.txt_codigo_produto.Size = New System.Drawing.Size(150, 25)
        Me.txt_codigo_produto.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nome do produto"
        '
        'txt_nome_produto
        '
        Me.txt_nome_produto.Location = New System.Drawing.Point(29, 306)
        Me.txt_nome_produto.Multiline = True
        Me.txt_nome_produto.Name = "txt_nome_produto"
        Me.txt_nome_produto.Size = New System.Drawing.Size(150, 25)
        Me.txt_nome_produto.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Quantidade"
        '
        'txt_quantidade_produto
        '
        Me.txt_quantidade_produto.Location = New System.Drawing.Point(221, 237)
        Me.txt_quantidade_produto.Multiline = True
        Me.txt_quantidade_produto.Name = "txt_quantidade_produto"
        Me.txt_quantidade_produto.Size = New System.Drawing.Size(150, 25)
        Me.txt_quantidade_produto.TabIndex = 13
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(217, 282)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(147, 20)
        Me.label.TabIndex = 16
        Me.label.Text = "Preço do produto"
        '
        'txt_preco_produto
        '
        Me.txt_preco_produto.Location = New System.Drawing.Point(221, 315)
        Me.txt_preco_produto.Multiline = True
        Me.txt_preco_produto.Name = "txt_preco_produto"
        Me.txt_preco_produto.Size = New System.Drawing.Size(150, 25)
        Me.txt_preco_produto.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Red
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(440, 338)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(125, 62)
        Me.btn_voltar.TabIndex = 18
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_criar
        '
        Me.btn_criar.BackColor = System.Drawing.Color.Green
        Me.btn_criar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_criar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar.Location = New System.Drawing.Point(440, 154)
        Me.btn_criar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(125, 62)
        Me.btn_criar.TabIndex = 19
        Me.btn_criar.Text = "Criar"
        Me.btn_criar.UseVisualStyleBackColor = False
        '
        'btn_deletar_produtos
        '
        Me.btn_deletar_produtos.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_deletar_produtos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deletar_produtos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletar_produtos.Location = New System.Drawing.Point(440, 244)
        Me.btn_deletar_produtos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_deletar_produtos.Name = "btn_deletar_produtos"
        Me.btn_deletar_produtos.Size = New System.Drawing.Size(125, 62)
        Me.btn_deletar_produtos.TabIndex = 20
        Me.btn_deletar_produtos.Text = "Deletar"
        Me.btn_deletar_produtos.UseVisualStyleBackColor = False
        '
        'frm_registrar_produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(592, 450)
        Me.Controls.Add(Me.btn_deletar_produtos)
        Me.Controls.Add(Me.btn_criar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txt_preco_produto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_quantidade_produto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome_produto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_codigo_produto)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_registrar_produto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_registrar_produto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_codigo_produto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome_produto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_quantidade_produto As TextBox
    Friend WithEvents label As Label
    Friend WithEvents txt_preco_produto As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_criar As Button
    Friend WithEvents btn_deletar_produtos As Button
End Class
