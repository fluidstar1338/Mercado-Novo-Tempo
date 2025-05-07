<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_caixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_caixa))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_historico_pagamento = New System.Windows.Forms.Button()
        Me.btn_registrar_pedido = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btn_historico_pagamento
        '
        Me.btn_historico_pagamento.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btn_historico_pagamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_historico_pagamento.Location = New System.Drawing.Point(263, 228)
        Me.btn_historico_pagamento.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.btn_historico_pagamento.Name = "btn_historico_pagamento"
        Me.btn_historico_pagamento.Size = New System.Drawing.Size(250, 115)
        Me.btn_historico_pagamento.TabIndex = 5
        Me.btn_historico_pagamento.Text = "Historico de pagamentos"
        Me.btn_historico_pagamento.UseVisualStyleBackColor = False
        '
        'btn_registrar_pedido
        '
        Me.btn_registrar_pedido.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btn_registrar_pedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrar_pedido.Location = New System.Drawing.Point(658, 228)
        Me.btn_registrar_pedido.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.btn_registrar_pedido.Name = "btn_registrar_pedido"
        Me.btn_registrar_pedido.Size = New System.Drawing.Size(250, 115)
        Me.btn_registrar_pedido.TabIndex = 6
        Me.btn_registrar_pedido.Text = "Registrar pedido"
        Me.btn_registrar_pedido.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Red
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Location = New System.Drawing.Point(459, 359)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(250, 115)
        Me.btn_sair.TabIndex = 7
        Me.btn_sair.Text = "SAIR DA CONTA"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1150, 692)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_registrar_pedido)
        Me.Controls.Add(Me.btn_historico_pagamento)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_caixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAIXA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_historico_pagamento As Button
    Friend WithEvents btn_registrar_pedido As Button
    Friend WithEvents btn_sair As Button
End Class
