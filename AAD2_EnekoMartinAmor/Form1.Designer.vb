Imports System.Reflection.Emit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTtit = New System.Windows.Forms.Label()
        imgPeli1 = New PictureBox()
        imgPeli2 = New PictureBox()
        imgPeli5 = New PictureBox()
        imgPeli4 = New PictureBox()
        lblPel1 = New System.Windows.Forms.Label()
        imgPeli3 = New PictureBox()
        lblPel2 = New System.Windows.Forms.Label()
        lblPeli3 = New System.Windows.Forms.Label()
        lblPeli4 = New System.Windows.Forms.Label()
        lblPeli5 = New System.Windows.Forms.Label()
        Timer1 = New Timer(components)
        lblFecha = New System.Windows.Forms.Label()
        lblHora = New System.Windows.Forms.Label()
        Button1 = New Button()
        CType(imgPeli1, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPeli2, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPeli5, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPeli4, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPeli3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTtit
        ' 
        lblTtit.AutoSize = True
        lblTtit.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTtit.Location = New Point(63, 42)
        lblTtit.Name = "lblTtit"
        lblTtit.Size = New Size(533, 35)
        lblTtit.TabIndex = 0
        lblTtit.Text = "CARTELERA - Cine SOMORROSTRO"
        ' 
        ' imgPeli1
        ' 
        imgPeli1.Location = New Point(68, 114)
        imgPeli1.Name = "imgPeli1"
        imgPeli1.Size = New Size(181, 237)
        imgPeli1.SizeMode = PictureBoxSizeMode.StretchImage
        imgPeli1.TabIndex = 1
        imgPeli1.TabStop = False
        ' 
        ' imgPeli2
        ' 
        imgPeli2.Location = New Point(291, 114)
        imgPeli2.Name = "imgPeli2"
        imgPeli2.Size = New Size(186, 237)
        imgPeli2.SizeMode = PictureBoxSizeMode.StretchImage
        imgPeli2.TabIndex = 2
        imgPeli2.TabStop = False
        ' 
        ' imgPeli5
        ' 
        imgPeli5.Location = New Point(986, 114)
        imgPeli5.Name = "imgPeli5"
        imgPeli5.Size = New Size(181, 237)
        imgPeli5.SizeMode = PictureBoxSizeMode.StretchImage
        imgPeli5.TabIndex = 3
        imgPeli5.TabStop = False
        ' 
        ' imgPeli4
        ' 
        imgPeli4.Location = New Point(753, 114)
        imgPeli4.Name = "imgPeli4"
        imgPeli4.Size = New Size(181, 237)
        imgPeli4.SizeMode = PictureBoxSizeMode.StretchImage
        imgPeli4.TabIndex = 5
        imgPeli4.TabStop = False
        ' 
        ' lblPel1
        ' 
        lblPel1.Font = New Font("Palatino Linotype", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPel1.Location = New Point(68, 370)
        lblPel1.Name = "lblPel1"
        lblPel1.Size = New Size(181, 89)
        lblPel1.TabIndex = 6
        lblPel1.Text = "Peli1"
        lblPel1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' imgPeli3
        ' 
        imgPeli3.Location = New Point(522, 114)
        imgPeli3.Name = "imgPeli3"
        imgPeli3.Size = New Size(186, 237)
        imgPeli3.SizeMode = PictureBoxSizeMode.StretchImage
        imgPeli3.TabIndex = 4
        imgPeli3.TabStop = False
        ' 
        ' lblPel2
        ' 
        lblPel2.Font = New Font("Palatino Linotype", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPel2.Location = New Point(291, 370)
        lblPel2.Name = "lblPel2"
        lblPel2.Size = New Size(186, 89)
        lblPel2.TabIndex = 7
        lblPel2.Text = "Peli1"
        lblPel2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeli3
        ' 
        lblPeli3.Font = New Font("Palatino Linotype", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPeli3.Location = New Point(522, 370)
        lblPeli3.Name = "lblPeli3"
        lblPeli3.Size = New Size(186, 89)
        lblPeli3.TabIndex = 8
        lblPeli3.Text = "Peli1"
        lblPeli3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeli4
        ' 
        lblPeli4.Font = New Font("Palatino Linotype", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPeli4.Location = New Point(753, 370)
        lblPeli4.Name = "lblPeli4"
        lblPeli4.Size = New Size(181, 89)
        lblPeli4.TabIndex = 9
        lblPeli4.Text = "Peli1"
        lblPeli4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPeli5
        ' 
        lblPeli5.Font = New Font("Palatino Linotype", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPeli5.Location = New Point(986, 370)
        lblPeli5.Name = "lblPeli5"
        lblPeli5.Size = New Size(181, 89)
        lblPeli5.TabIndex = 10
        lblPeli5.Text = "Peli1"
        lblPeli5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFecha.Location = New Point(1084, 22)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(57, 25)
        lblFecha.TabIndex = 11
        lblFecha.Text = "Fecha"
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHora.Location = New Point(1084, 52)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(51, 25)
        lblHora.TabIndex = 12
        lblHora.Text = "Hora"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(844, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 47)
        Button1.TabIndex = 13
        Button1.Text = "Creditos"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1229, 479)
        Controls.Add(Button1)
        Controls.Add(lblHora)
        Controls.Add(lblFecha)
        Controls.Add(lblPeli5)
        Controls.Add(lblPeli4)
        Controls.Add(lblPeli3)
        Controls.Add(lblPel2)
        Controls.Add(lblPel1)
        Controls.Add(imgPeli4)
        Controls.Add(imgPeli3)
        Controls.Add(imgPeli5)
        Controls.Add(imgPeli2)
        Controls.Add(imgPeli1)
        Controls.Add(lblTtit)
        Name = "Form1"
        Text = "Form1"
        CType(imgPeli1, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPeli2, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPeli5, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPeli4, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPeli3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTtit As System.Windows.Forms.Label
    Friend WithEvents imgPeli1 As PictureBox
    Friend WithEvents imgPeli2 As PictureBox
    Friend WithEvents imgPeli5 As PictureBox
    Friend WithEvents imgPeli4 As PictureBox
    Friend WithEvents lblPel1 As System.Windows.Forms.Label
    Friend WithEvents imgPeli3 As PictureBox
    Friend WithEvents lblPel2 As System.Windows.Forms.Label
    Friend WithEvents lblPeli3 As System.Windows.Forms.Label
    Friend WithEvents lblPeli4 As System.Windows.Forms.Label
    Friend WithEvents lblPeli5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button

End Class
