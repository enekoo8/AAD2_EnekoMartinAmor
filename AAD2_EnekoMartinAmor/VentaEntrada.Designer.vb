<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaEntrada
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
        Label1 = New Label()
        cantEntradas = New NumericUpDown()
        Button1 = New Button()
        Button2 = New Button()
        CType(cantEntradas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 20)
        Label1.TabIndex = 0
        Label1.Text = "Introduzca la cantidad de entradas a comprar:"
        ' 
        ' cantEntradas
        ' 
        cantEntradas.Location = New Point(58, 87)
        cantEntradas.Name = "cantEntradas"
        cantEntradas.Size = New Size(150, 27)
        cantEntradas.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(226, 77)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 39)
        Button1.TabIndex = 2
        Button1.Text = "Confirmar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(-100, -100)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 3
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' VentaEntrada
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Button2
        ClientSize = New Size(407, 163)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(cantEntradas)
        Controls.Add(Label1)
        Name = "VentaEntrada"
        Text = "VentaEntrada"
        CType(cantEntradas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cantEntradas As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
