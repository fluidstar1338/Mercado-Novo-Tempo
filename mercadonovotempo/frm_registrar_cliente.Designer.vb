<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_cliente))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_criar_atualizar = New System.Windows.Forms.Button()
        Me.btn_deletar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_cep = New System.Windows.Forms.TextBox()
        Me.txt_data_pagamento = New System.Windows.Forms.TextBox()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.txt_numero_casa = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(40, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(40, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nome completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(40, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cep"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(251, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "data que vai ser pago"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(251, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(251, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "número(casa)"
        '
        'btn_criar_atualizar
        '
        Me.btn_criar_atualizar.BackColor = System.Drawing.Color.Red
        Me.btn_criar_atualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_criar_atualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar_atualizar.Location = New System.Drawing.Point(662, 60)
        Me.btn_criar_atualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_criar_atualizar.Name = "btn_criar_atualizar"
        Me.btn_criar_atualizar.Size = New System.Drawing.Size(125, 62)
        Me.btn_criar_atualizar.TabIndex = 11
        Me.btn_criar_atualizar.Text = "criar"
        Me.btn_criar_atualizar.UseVisualStyleBackColor = False
        '
        'btn_deletar
        '
        Me.btn_deletar.BackColor = System.Drawing.Color.Red
        Me.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletar.Location = New System.Drawing.Point(662, 191)
        Me.btn_deletar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_deletar.Name = "btn_deletar"
        Me.btn_deletar.Size = New System.Drawing.Size(125, 62)
        Me.btn_deletar.TabIndex = 12
        Me.btn_deletar.Text = "Deletar "
        Me.btn_deletar.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Red
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(662, 316)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(125, 62)
        Me.btn_voltar.TabIndex = 13
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_cpf.Location = New System.Drawing.Point(43, 174)
        Me.txt_cpf.Multiline = True
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(165, 30)
        Me.txt_cpf.TabIndex = 14
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_nome.Location = New System.Drawing.Point(43, 242)
        Me.txt_nome.Multiline = True
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(165, 30)
        Me.txt_nome.TabIndex = 15
        '
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_cep.Location = New System.Drawing.Point(43, 316)
        Me.txt_cep.Multiline = True
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(165, 31)
        Me.txt_cep.TabIndex = 16
        '
        'txt_data_pagamento
        '
        Me.txt_data_pagamento.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_data_pagamento.Location = New System.Drawing.Point(254, 174)
        Me.txt_data_pagamento.Multiline = True
        Me.txt_data_pagamento.Name = "txt_data_pagamento"
        Me.txt_data_pagamento.Size = New System.Drawing.Size(165, 30)
        Me.txt_data_pagamento.TabIndex = 17
        '
        'txt_telefone
        '
        Me.txt_telefone.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_telefone.Location = New System.Drawing.Point(254, 242)
        Me.txt_telefone.Multiline = True
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(165, 30)
        Me.txt_telefone.TabIndex = 18
        '
        'txt_numero_casa
        '
        Me.txt_numero_casa.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_numero_casa.Location = New System.Drawing.Point(254, 316)
        Me.txt_numero_casa.Multiline = True
        Me.txt_numero_casa.Name = "txt_numero_casa"
        Me.txt_numero_casa.Size = New System.Drawing.Size(165, 31)
        Me.txt_numero_casa.TabIndex = 19
        '
        'frm_registrar_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_numero_casa)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.txt_data_pagamento)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_deletar)
        Me.Controls.Add(Me.btn_criar_atualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_registrar_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_registrar_cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_criar_atualizar As Button
    Friend WithEvents btn_deletar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cep As TextBox
    Friend WithEvents txt_data_pagamento As TextBox
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents txt_numero_casa As TextBox
End Class
