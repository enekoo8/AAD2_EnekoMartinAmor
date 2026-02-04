<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoPeli
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
        PictureBox1 = New PictureBox()
        lblPelicula = New Label()
        lblDura = New Label()
        lblPrecio = New Label()
        Label2 = New Label()
        btVender = New Button()
        btVolver = New Button()
        lblDuracion = New Label()
        lblSipnosis = New Label()
        lblPrec = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(51, 62)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(264, 329)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblPelicula
        ' 
        lblPelicula.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPelicula.Location = New Point(361, 65)
        lblPelicula.Name = "lblPelicula"
        lblPelicula.Size = New Size(386, 80)
        lblPelicula.TabIndex = 1
        lblPelicula.Text = "Pelicula + Año Estreno"
        ' 
        ' lblDura
        ' 
        lblDura.AutoSize = True
        lblDura.Location = New Point(361, 152)
        lblDura.Name = "lblDura"
        lblDura.Size = New Size(72, 20)
        lblDura.TabIndex = 2
        lblDura.Text = "Duracion:"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New Point(70, 428)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(108, 20)
        lblPrecio.TabIndex = 3
        lblPrecio.Text = "Precio Entrada:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(390, 350)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 5
        ' 
        ' btVender
        ' 
        btVender.Location = New Point(407, 408)
        btVender.Name = "btVender"
        btVender.Size = New Size(180, 40)
        btVender.TabIndex = 6
        btVender.Text = "Vender Entradas"
        btVender.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(610, 408)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(137, 40)
        btVolver.TabIndex = 7
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' lblDuracion
        ' 
        lblDuracion.AutoSize = True
        lblDuracion.Location = New Point(452, 152)
        lblDuracion.Name = "lblDuracion"
        lblDuracion.Size = New Size(72, 20)
        lblDuracion.TabIndex = 8
        lblDuracion.Text = "Duracion:"
        ' 
        ' lblSipnosis
        ' 
        lblSipnosis.Location = New Point(361, 202)
        lblSipnosis.Name = "lblSipnosis"
        lblSipnosis.Size = New Size(416, 189)
        lblSipnosis.TabIndex = 9
        lblSipnosis.Text = "Sipnopsis:"
        ' 
        ' lblPrec
        ' 
        lblPrec.AutoSize = True
        lblPrec.Location = New Point(191, 428)
        lblPrec.Name = "lblPrec"
        lblPrec.Size = New Size(53, 20)
        lblPrec.TabIndex = 10
        lblPrec.Text = "Label1"
        ' 
        ' InfoPeli
        ' 
        AcceptButton = btVender
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btVolver
        ClientSize = New Size(817, 473)
        Controls.Add(lblPrec)
        Controls.Add(lblSipnosis)
        Controls.Add(lblDuracion)
        Controls.Add(btVolver)
        Controls.Add(btVender)
        Controls.Add(Label2)
        Controls.Add(lblPrecio)
        Controls.Add(lblDura)
        Controls.Add(lblPelicula)
        Controls.Add(PictureBox1)
        Name = "InfoPeli"
        Text = "InfoPeli"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPelicula As Label
    Friend WithEvents lblDura As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btVender As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblSipnosis As Label
    Friend WithEvents lblPrec As Label
End Class
