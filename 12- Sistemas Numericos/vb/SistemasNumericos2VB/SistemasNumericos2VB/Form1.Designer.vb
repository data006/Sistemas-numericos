<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistemasNumericosVB
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
        Me.btnTransformar = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.grpOut = New System.Windows.Forms.GroupBox()
        Me.radHexaOut = New System.Windows.Forms.RadioButton()
        Me.radDecimalOut = New System.Windows.Forms.RadioButton()
        Me.radOctalOut = New System.Windows.Forms.RadioButton()
        Me.radBinarioOut = New System.Windows.Forms.RadioButton()
        Me.grpIn = New System.Windows.Forms.GroupBox()
        Me.radHexa = New System.Windows.Forms.RadioButton()
        Me.radDecimal = New System.Windows.Forms.RadioButton()
        Me.radOctal = New System.Windows.Forms.RadioButton()
        Me.radBinario = New System.Windows.Forms.RadioButton()
        Me.grpOut.SuspendLayout()
        Me.grpIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTransformar
        '
        Me.btnTransformar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransformar.Location = New System.Drawing.Point(246, 211)
        Me.btnTransformar.Name = "btnTransformar"
        Me.btnTransformar.Size = New System.Drawing.Size(75, 23)
        Me.btnTransformar.TabIndex = 9
        Me.btnTransformar.Text = "Transformar"
        Me.btnTransformar.UseVisualStyleBackColor = True
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(330, 214)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(100, 20)
        Me.txtOut.TabIndex = 8
        '
        'txtIn
        '
        Me.txtIn.Location = New System.Drawing.Point(134, 214)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(100, 20)
        Me.txtIn.TabIndex = 7
        '
        'grpOut
        '
        Me.grpOut.Controls.Add(Me.radHexaOut)
        Me.grpOut.Controls.Add(Me.radDecimalOut)
        Me.grpOut.Controls.Add(Me.radOctalOut)
        Me.grpOut.Controls.Add(Me.radBinarioOut)
        Me.grpOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOut.Location = New System.Drawing.Point(308, 47)
        Me.grpOut.Name = "grpOut"
        Me.grpOut.Size = New System.Drawing.Size(130, 161)
        Me.grpOut.TabIndex = 6
        Me.grpOut.TabStop = False
        Me.grpOut.Text = "Sistema de salida"
        '
        'radHexaOut
        '
        Me.radHexaOut.AutoSize = True
        Me.radHexaOut.Location = New System.Drawing.Point(22, 100)
        Me.radHexaOut.Name = "radHexaOut"
        Me.radHexaOut.Size = New System.Drawing.Size(97, 17)
        Me.radHexaOut.TabIndex = 3
        Me.radHexaOut.TabStop = True
        Me.radHexaOut.Text = "Hexadecimal"
        Me.radHexaOut.UseVisualStyleBackColor = True
        '
        'radDecimalOut
        '
        Me.radDecimalOut.AutoSize = True
        Me.radDecimalOut.Location = New System.Drawing.Point(22, 77)
        Me.radDecimalOut.Name = "radDecimalOut"
        Me.radDecimalOut.Size = New System.Drawing.Size(70, 17)
        Me.radDecimalOut.TabIndex = 2
        Me.radDecimalOut.TabStop = True
        Me.radDecimalOut.Text = "Decimal"
        Me.radDecimalOut.UseVisualStyleBackColor = True
        '
        'radOctalOut
        '
        Me.radOctalOut.AutoSize = True
        Me.radOctalOut.Location = New System.Drawing.Point(22, 54)
        Me.radOctalOut.Name = "radOctalOut"
        Me.radOctalOut.Size = New System.Drawing.Size(55, 17)
        Me.radOctalOut.TabIndex = 1
        Me.radOctalOut.TabStop = True
        Me.radOctalOut.Text = "Octal"
        Me.radOctalOut.UseVisualStyleBackColor = True
        '
        'radBinarioOut
        '
        Me.radBinarioOut.AutoSize = True
        Me.radBinarioOut.Location = New System.Drawing.Point(22, 31)
        Me.radBinarioOut.Name = "radBinarioOut"
        Me.radBinarioOut.Size = New System.Drawing.Size(64, 17)
        Me.radBinarioOut.TabIndex = 0
        Me.radBinarioOut.TabStop = True
        Me.radBinarioOut.Text = "Binario"
        Me.radBinarioOut.UseVisualStyleBackColor = True
        '
        'grpIn
        '
        Me.grpIn.Controls.Add(Me.radHexa)
        Me.grpIn.Controls.Add(Me.radDecimal)
        Me.grpIn.Controls.Add(Me.radOctal)
        Me.grpIn.Controls.Add(Me.radBinario)
        Me.grpIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpIn.Location = New System.Drawing.Point(112, 47)
        Me.grpIn.Name = "grpIn"
        Me.grpIn.Size = New System.Drawing.Size(130, 161)
        Me.grpIn.TabIndex = 5
        Me.grpIn.TabStop = False
        Me.grpIn.Text = "Sistema de entrada"
        '
        'radHexa
        '
        Me.radHexa.AutoSize = True
        Me.radHexa.Location = New System.Drawing.Point(22, 100)
        Me.radHexa.Name = "radHexa"
        Me.radHexa.Size = New System.Drawing.Size(97, 17)
        Me.radHexa.TabIndex = 3
        Me.radHexa.TabStop = True
        Me.radHexa.Text = "Hexadecimal"
        Me.radHexa.UseVisualStyleBackColor = True
        '
        'radDecimal
        '
        Me.radDecimal.AutoSize = True
        Me.radDecimal.Location = New System.Drawing.Point(22, 77)
        Me.radDecimal.Name = "radDecimal"
        Me.radDecimal.Size = New System.Drawing.Size(70, 17)
        Me.radDecimal.TabIndex = 2
        Me.radDecimal.TabStop = True
        Me.radDecimal.Text = "Decimal"
        Me.radDecimal.UseVisualStyleBackColor = True
        '
        'radOctal
        '
        Me.radOctal.AutoSize = True
        Me.radOctal.Location = New System.Drawing.Point(22, 54)
        Me.radOctal.Name = "radOctal"
        Me.radOctal.Size = New System.Drawing.Size(55, 17)
        Me.radOctal.TabIndex = 1
        Me.radOctal.TabStop = True
        Me.radOctal.Text = "Octal"
        Me.radOctal.UseVisualStyleBackColor = True
        '
        'radBinario
        '
        Me.radBinario.AutoSize = True
        Me.radBinario.Location = New System.Drawing.Point(22, 31)
        Me.radBinario.Name = "radBinario"
        Me.radBinario.Size = New System.Drawing.Size(64, 17)
        Me.radBinario.TabIndex = 0
        Me.radBinario.TabStop = True
        Me.radBinario.Text = "Binario"
        Me.radBinario.UseVisualStyleBackColor = True
        '
        'frmSistemasNumericosVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(560, 286)
        Me.Controls.Add(Me.btnTransformar)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.grpOut)
        Me.Controls.Add(Me.grpIn)
        Me.Name = "frmSistemasNumericosVB"
        Me.Text = "Sistemas Numericos"
        Me.grpOut.ResumeLayout(False)
        Me.grpOut.PerformLayout()
        Me.grpIn.ResumeLayout(False)
        Me.grpIn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTransformar As Button
    Friend WithEvents txtOut As TextBox
    Friend WithEvents txtIn As TextBox
    Friend WithEvents grpOut As GroupBox
    Friend WithEvents radHexaOut As RadioButton
    Friend WithEvents radDecimalOut As RadioButton
    Friend WithEvents radOctalOut As RadioButton
    Friend WithEvents radBinarioOut As RadioButton
    Friend WithEvents grpIn As GroupBox
    Friend WithEvents radHexa As RadioButton
    Friend WithEvents radDecimal As RadioButton
    Friend WithEvents radOctal As RadioButton
    Friend WithEvents radBinario As RadioButton
End Class
