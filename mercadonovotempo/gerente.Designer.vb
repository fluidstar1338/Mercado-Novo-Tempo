<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerente))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_crud = New System.Windows.Forms.Button()
        Me.btn_historico_vendas = New System.Windows.Forms.Button()
        Me.controle_estoque = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_crud
        '
        Me.btn_crud.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btn_crud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_crud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crud.Location = New System.Drawing.Point(217, 159)
        Me.btn_crud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_crud.Name = "btn_crud"
        Me.btn_crud.Size = New System.Drawing.Size(150, 75)
        Me.btn_crud.TabIndex = 2
        Me.btn_crud.Text = "CRUD"
        Me.btn_crud.UseVisualStyleBackColor = False
        '
        'btn_historico_vendas
        '
        Me.btn_historico_vendas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btn_historico_vendas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_historico_vendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historico_vendas.Location = New System.Drawing.Point(217, 283)
        Me.btn_historico_vendas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_historico_vendas.Name = "btn_historico_vendas"
        Me.btn_historico_vendas.Size = New System.Drawing.Size(150, 75)
        Me.btn_historico_vendas.TabIndex = 3
        Me.btn_historico_vendas.Text = "HISTÓRICO DE VENDAS"
        Me.btn_historico_vendas.UseVisualStyleBackColor = False
        '
        'controle_estoque
        '
        Me.controle_estoque.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.controle_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.controle_estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controle_estoque.Location = New System.Drawing.Point(435, 159)
        Me.controle_estoque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.controle_estoque.Name = "controle_estoque"
        Me.controle_estoque.Size = New System.Drawing.Size(150, 75)
        Me.controle_estoque.TabIndex = 4
        Me.controle_estoque.Text = "CONTROLE DE ESTOQUE"
        Me.controle_estoque.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Red
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Location = New System.Drawing.Point(435, 283)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(150, 75)
        Me.btn_sair.TabIndex = 5
        Me.btn_sair.Text = "SAIR DA CONTA"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.controle_estoque)
        Me.Controls.Add(Me.btn_historico_vendas)
        Me.Controls.Add(Me.btn_crud)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_gerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERENTE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_crud As Button
    Friend WithEvents btn_historico_vendas As Button
    Friend WithEvents controle_estoque As Button
    Friend WithEvents btn_sair As Button
End Class
