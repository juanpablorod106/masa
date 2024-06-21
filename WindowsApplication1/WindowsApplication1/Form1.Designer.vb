<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Zapaterìa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_c_z = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btt_calcular = New System.Windows.Forms.Button()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_t = New System.Windows.Forms.Label()
        Me.lbl_st = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(459, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Zapaterìa
        '
        Me.Zapaterìa.AutoSize = True
        Me.Zapaterìa.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zapaterìa.Location = New System.Drawing.Point(232, 9)
        Me.Zapaterìa.Name = "Zapaterìa"
        Me.Zapaterìa.Size = New System.Drawing.Size(186, 46)
        Me.Zapaterìa.TabIndex = 1
        Me.Zapaterìa.Text = "Zapateria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nro. de zapatos:"
        '
        'tbx_c_z
        '
        Me.tbx_c_z.Location = New System.Drawing.Point(100, 75)
        Me.tbx_c_z.Name = "tbx_c_z"
        Me.tbx_c_z.Size = New System.Drawing.Size(100, 20)
        Me.tbx_c_z.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descuento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sub-total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'btt_calcular
        '
        Me.btt_calcular.Location = New System.Drawing.Point(206, 73)
        Me.btt_calcular.Name = "btt_calcular"
        Me.btt_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btt_calcular.TabIndex = 7
        Me.btt_calcular.Text = "Calcular"
        Me.btt_calcular.UseVisualStyleBackColor = True
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Location = New System.Drawing.Point(80, 115)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(68, 13)
        Me.lbl_desc.TabIndex = 8
        Me.lbl_desc.Text = "Ndescuento:"
        '
        'lbl_t
        '
        Me.lbl_t.AutoSize = True
        Me.lbl_t.Location = New System.Drawing.Point(80, 170)
        Me.lbl_t.Name = "lbl_t"
        Me.lbl_t.Size = New System.Drawing.Size(27, 13)
        Me.lbl_t.TabIndex = 9
        Me.lbl_t.Text = "total"
        '
        'lbl_st
        '
        Me.lbl_st.AutoSize = True
        Me.lbl_st.Location = New System.Drawing.Point(80, 142)
        Me.lbl_st.Name = "lbl_st"
        Me.lbl_st.Size = New System.Drawing.Size(36, 13)
        Me.lbl_st.TabIndex = 10
        Me.lbl_st.Text = "sTotal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(857, 504)
        Me.Controls.Add(Me.lbl_st)
        Me.Controls.Add(Me.lbl_t)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.btt_calcular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbx_c_z)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Zapaterìa)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Zapaterìa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_c_z As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btt_calcular As System.Windows.Forms.Button
    Friend WithEvents lbl_desc As System.Windows.Forms.Label
    Friend WithEvents lbl_t As System.Windows.Forms.Label
    Friend WithEvents lbl_st As System.Windows.Forms.Label

End Class
