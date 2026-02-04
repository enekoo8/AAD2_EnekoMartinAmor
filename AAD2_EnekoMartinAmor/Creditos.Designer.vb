<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creditos
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
        btVolver = New Button()
        lblDuracionlblDuracion = New Label()
        lblUsuNom = New Label()
        PictureBox1 = New PictureBox()
        lblCantRepos = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(284, 195)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(168, 40)
        btVolver.TabIndex = 11
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' lblDuracionlblDuracion
        ' 
        lblDuracionlblDuracion.AutoSize = True
        lblDuracionlblDuracion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDuracionlblDuracion.Location = New Point(284, 107)
        lblDuracionlblDuracion.Name = "lblDuracionlblDuracion"
        lblDuracionlblDuracion.Size = New Size(147, 28)
        lblDuracionlblDuracion.TabIndex = 10
        lblDuracionlblDuracion.Text = "Repos Publicos:"
        ' 
        ' lblUsuNom
        ' 
        lblUsuNom.AutoSize = True
        lblUsuNom.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsuNom.Location = New Point(284, 55)
        lblUsuNom.Name = "lblUsuNom"
        lblUsuNom.Size = New Size(123, 34)
        lblUsuNom.TabIndex = 9
        lblUsuNom.Text = "UsuNom"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(46, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(184, 197)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' lblCantRepos
        ' 
        lblCantRepos.AutoSize = True
        lblCantRepos.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCantRepos.Location = New Point(332, 153)
        lblCantRepos.Name = "lblCantRepos"
        lblCantRepos.Size = New Size(48, 25)
        lblCantRepos.TabIndex = 12
        lblCantRepos.Text = "Cant"
        ' 
        ' Creditos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btVolver
        ClientSize = New Size(490, 270)
        Controls.Add(lblCantRepos)
        Controls.Add(btVolver)
        Controls.Add(lblDuracionlblDuracion)
        Controls.Add(lblUsuNom)
        Controls.Add(PictureBox1)
        Name = "Creditos"
        Text = "Creditos"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btVolver As Button
    Friend WithEvents lblDuracionlblDuracion As Label
    Friend WithEvents lblUsuNom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCantRepos As Label
End Class
