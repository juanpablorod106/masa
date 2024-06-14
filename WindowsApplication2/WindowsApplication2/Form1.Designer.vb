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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.N1 = New System.Windows.Forms.TextBox()
        Me.N2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Plox = New System.Windows.Forms.Button()
        Me.Equal = New System.Windows.Forms.Button()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(238, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chavales"
        '
        'N1
        '
        Me.N1.Location = New System.Drawing.Point(114, 119)
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(85, 20)
        Me.N1.TabIndex = 1
        Me.N1.Text = "Fkn Boton 1"
        '
        'N2
        '
        Me.N2.Location = New System.Drawing.Point(275, 119)
        Me.N2.Name = "N2"
        Me.N2.Size = New System.Drawing.Size(85, 20)
        Me.N2.TabIndex = 2
        Me.N2.Text = "Fkn Boton 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(304, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Soluciono vuestras sumas chavales"
        '
        'Plox
        '
        Me.Plox.Location = New System.Drawing.Point(217, 116)
        Me.Plox.Name = "Plox"
        Me.Plox.Size = New System.Drawing.Size(28, 23)
        Me.Plox.TabIndex = 4
        Me.Plox.Text = "+"
        Me.Plox.UseVisualStyleBackColor = True
        '
        'Equal
        '
        Me.Equal.Location = New System.Drawing.Point(380, 118)
        Me.Equal.Name = "Equal"
        Me.Equal.Size = New System.Drawing.Size(36, 23)
        Me.Equal.TabIndex = 5
        Me.Equal.Text = "="
        Me.Equal.UseVisualStyleBackColor = True
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Location = New System.Drawing.Point(438, 122)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(55, 13)
        Me.Resultado.TabIndex = 6
        Me.Resultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 261)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Equal)
        Me.Controls.Add(Me.Plox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.N2)
        Me.Controls.Add(Me.N1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pan Dulce "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents N1 As System.Windows.Forms.TextBox
    Friend WithEvents N2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Plox As System.Windows.Forms.Button
    Friend WithEvents Equal As System.Windows.Forms.Button
    Friend WithEvents Resultado As System.Windows.Forms.Label

End Class
