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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.codPost = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fechaTxt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.names = New System.Windows.Forms.TextBox()
        Me.lastname_1 = New System.Windows.Forms.TextBox()
        Me.phone_number = New System.Windows.Forms.TextBox()
        Me.lastname_2 = New System.Windows.Forms.TextBox()
        Me.email_confirm = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.municipality = New System.Windows.Forms.TextBox()
        Me.state = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.colonia = New System.Windows.Forms.TextBox()
        Me.asentamiento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(513, 317)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar codigo postal >"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'codPost
        '
        Me.codPost.Location = New System.Drawing.Point(316, 324)
        Me.codPost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.codPost.Name = "codPost"
        Me.codPost.Size = New System.Drawing.Size(153, 20)
        Me.codPost.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.fechaTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(897, 54)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'fechaTxt
        '
        Me.fechaTxt.AutoSize = True
        Me.fechaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fechaTxt.Location = New System.Drawing.Point(527, 21)
        Me.fechaTxt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fechaTxt.Name = "fechaTxt"
        Me.fechaTxt.Size = New System.Drawing.Size(99, 20)
        Me.fechaTxt.TabIndex = 3
        Me.fechaTxt.Text = "_________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(314, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "La Fecha de hoy es"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 498)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "_________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(364, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "La Fecha de hoy es"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(313, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CODIGO POSTAL (CP):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(311, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DATOS DE CONTACTO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(313, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "NOMBRE(S): *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(605, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "APELLIDO 1:*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(315, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "APELLIDO 2:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(603, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "TELEFONO:*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(605, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "CONFIRMAR EMAIL:*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(317, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "EMAIL:*"
        '
        'names
        '
        Me.names.Location = New System.Drawing.Point(316, 109)
        Me.names.Margin = New System.Windows.Forms.Padding(2)
        Me.names.Name = "names"
        Me.names.Size = New System.Drawing.Size(153, 20)
        Me.names.TabIndex = 14
        '
        'lastname_1
        '
        Me.lastname_1.Location = New System.Drawing.Point(606, 109)
        Me.lastname_1.Margin = New System.Windows.Forms.Padding(2)
        Me.lastname_1.Name = "lastname_1"
        Me.lastname_1.Size = New System.Drawing.Size(153, 20)
        Me.lastname_1.TabIndex = 15
        '
        'phone_number
        '
        Me.phone_number.Location = New System.Drawing.Point(606, 173)
        Me.phone_number.Margin = New System.Windows.Forms.Padding(2)
        Me.phone_number.Name = "phone_number"
        Me.phone_number.Size = New System.Drawing.Size(153, 20)
        Me.phone_number.TabIndex = 17
        '
        'lastname_2
        '
        Me.lastname_2.Location = New System.Drawing.Point(316, 173)
        Me.lastname_2.Margin = New System.Windows.Forms.Padding(2)
        Me.lastname_2.Name = "lastname_2"
        Me.lastname_2.Size = New System.Drawing.Size(153, 20)
        Me.lastname_2.TabIndex = 16
        '
        'email_confirm
        '
        Me.email_confirm.Location = New System.Drawing.Point(606, 255)
        Me.email_confirm.Margin = New System.Windows.Forms.Padding(2)
        Me.email_confirm.Name = "email_confirm"
        Me.email_confirm.Size = New System.Drawing.Size(153, 20)
        Me.email_confirm.TabIndex = 19
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(316, 255)
        Me.email.Margin = New System.Windows.Forms.Padding(2)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(153, 20)
        Me.email.TabIndex = 18
        '
        'municipality
        '
        Me.municipality.Location = New System.Drawing.Point(608, 379)
        Me.municipality.Margin = New System.Windows.Forms.Padding(2)
        Me.municipality.Name = "municipality"
        Me.municipality.Size = New System.Drawing.Size(153, 20)
        Me.municipality.TabIndex = 23
        '
        'state
        '
        Me.state.Location = New System.Drawing.Point(318, 379)
        Me.state.Margin = New System.Windows.Forms.Padding(2)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(153, 20)
        Me.state.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(607, 364)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "MUNICIPIO:*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(319, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "ESTADO:*"
        '
        'colonia
        '
        Me.colonia.Location = New System.Drawing.Point(606, 439)
        Me.colonia.Margin = New System.Windows.Forms.Padding(2)
        Me.colonia.Name = "colonia"
        Me.colonia.Size = New System.Drawing.Size(153, 20)
        Me.colonia.TabIndex = 27
        '
        'asentamiento
        '
        Me.asentamiento.Location = New System.Drawing.Point(316, 439)
        Me.asentamiento.Margin = New System.Windows.Forms.Padding(2)
        Me.asentamiento.Name = "asentamiento"
        Me.asentamiento.Size = New System.Drawing.Size(153, 20)
        Me.asentamiento.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(605, 424)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "COLONIA:*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(317, 424)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "ASENTAMINETO:*"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox1.Image = Global.codigoPostalApp.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = Global.codigoPostalApp.My.Resources.Resources.bc
        Me.Button2.Location = New System.Drawing.Point(859, 3)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 38)
        Me.Button2.TabIndex = 28
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(893, 493)
        Me.Controls.Add(Me.colonia)
        Me.Controls.Add(Me.asentamiento)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.municipality)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.email_confirm)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.phone_number)
        Me.Controls.Add(Me.lastname_2)
        Me.Controls.Add(Me.lastname_1)
        Me.Controls.Add(Me.names)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.codPost)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Codigo Postal App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents codPost As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fechaTxt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents names As TextBox
    Friend WithEvents lastname_1 As TextBox
    Friend WithEvents phone_number As TextBox
    Friend WithEvents lastname_2 As TextBox
    Friend WithEvents email_confirm As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents municipality As TextBox
    Friend WithEvents state As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents colonia As TextBox
    Friend WithEvents asentamiento As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button2 As Button
End Class
