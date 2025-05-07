<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_pedidos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.View_lista_produtos = New System.Windows.Forms.DataGridView()
        Me.txt_codigo_produto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_quantidade = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_valor_pago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_troco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.btn_finalizar_compra = New System.Windows.Forms.Button()
        Me.btn_add_lista = New System.Windows.Forms.Button()
        Me.btn_remover_lista = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_lista_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'View_lista_produtos
        '
        Me.View_lista_produtos.AllowUserToAddRows = False
        Me.View_lista_produtos.AllowUserToDeleteRows = False
        Me.View_lista_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_lista_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.View_lista_produtos.Location = New System.Drawing.Point(327, 40)
        Me.View_lista_produtos.Name = "View_lista_produtos"
        Me.View_lista_produtos.ReadOnly = True
        Me.View_lista_produtos.Size = New System.Drawing.Size(443, 205)
        Me.View_lista_produtos.TabIndex = 6
        '
        'txt_codigo_produto
        '
        Me.txt_codigo_produto.Location = New System.Drawing.Point(37, 161)
        Me.txt_codigo_produto.Multiline = True
        Me.txt_codigo_produto.Name = "txt_codigo_produto"
        Me.txt_codigo_produto.Size = New System.Drawing.Size(150, 25)
        Me.txt_codigo_produto.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Codigo do produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Quantidade"
        '
        'txt_quantidade
        '
        Me.txt_quantidade.Location = New System.Drawing.Point(33, 230)
        Me.txt_quantidade.Multiline = True
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(150, 25)
        Me.txt_quantidade.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(355, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "valor pago"
        '
        'txt_valor_pago
        '
        Me.txt_valor_pago.Location = New System.Drawing.Point(359, 297)
        Me.txt_valor_pago.Multiline = True
        Me.txt_valor_pago.Name = "txt_valor_pago"
        Me.txt_valor_pago.Size = New System.Drawing.Size(88, 25)
        Me.txt_valor_pago.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(499, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Troco"
        '
        'txt_troco
        '
        Me.txt_troco.Location = New System.Drawing.Point(503, 297)
        Me.txt_troco.Multiline = True
        Me.txt_troco.Name = "txt_troco"
        Me.txt_troco.Size = New System.Drawing.Size(88, 25)
        Me.txt_troco.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(650, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Total"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(654, 297)
        Me.txt_total.Multiline = True
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(88, 25)
        Me.txt_total.TabIndex = 20
        '
        'btn_finalizar_compra
        '
        Me.btn_finalizar_compra.BackColor = System.Drawing.Color.Green
        Me.btn_finalizar_compra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalizar_compra.Location = New System.Drawing.Point(654, 365)
        Me.btn_finalizar_compra.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.btn_finalizar_compra.Name = "btn_finalizar_compra"
        Me.btn_finalizar_compra.Size = New System.Drawing.Size(99, 55)
        Me.btn_finalizar_compra.TabIndex = 21
        Me.btn_finalizar_compra.Text = "Finalizar compra"
        Me.btn_finalizar_compra.UseVisualStyleBackColor = False
        '
        'btn_add_lista
        '
        Me.btn_add_lista.BackColor = System.Drawing.Color.Green
        Me.btn_add_lista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_lista.Location = New System.Drawing.Point(33, 266)
        Me.btn_add_lista.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.btn_add_lista.Name = "btn_add_lista"
        Me.btn_add_lista.Size = New System.Drawing.Size(154, 39)
        Me.btn_add_lista.TabIndex = 22
        Me.btn_add_lista.Text = "Adicionar na lista"
        Me.btn_add_lista.UseVisualStyleBackColor = False
        '
        'btn_remover_lista
        '
        Me.btn_remover_lista.BackColor = System.Drawing.Color.Crimson
        Me.btn_remover_lista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_remover_lista.Location = New System.Drawing.Point(33, 321)
        Me.btn_remover_lista.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.btn_remover_lista.Name = "btn_remover_lista"
        Me.btn_remover_lista.Size = New System.Drawing.Size(154, 39)
        Me.btn_remover_lista.TabIndex = 23
        Me.btn_remover_lista.Text = "Remover da lista"
        Me.btn_remover_lista.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantidade"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Preço"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'frm_registrar_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_remover_lista)
        Me.Controls.Add(Me.btn_add_lista)
        Me.Controls.Add(Me.btn_finalizar_compra)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_troco)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_valor_pago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_quantidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_codigo_produto)
        Me.Controls.Add(Me.View_lista_produtos)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.Name = "frm_registrar_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_registrar_pedidos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_lista_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents View_lista_produtos As DataGridView
    Friend WithEvents txt_codigo_produto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_valor_pago As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_troco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents btn_finalizar_compra As Button
    Friend WithEvents btn_add_lista As Button
    Friend WithEvents btn_remover_lista As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
