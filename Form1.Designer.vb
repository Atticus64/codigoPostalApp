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
        Me.CodPost = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fechaTxt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.estadoBox = New System.Windows.Forms.ComboBox()
        Me.MunicipioBox = New System.Windows.Forms.ComboBox()
        Me.TipAsentaBox = New System.Windows.Forms.ComboBox()
        Me.AsentamientoBox = New System.Windows.Forms.ComboBox()
        Me.CiudadBox = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodPost
        '
        Me.CodPost.Location = New System.Drawing.Point(421, 399)
        Me.CodPost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CodPost.MaxLength = 5
        Me.CodPost.Name = "CodPost"
        Me.CodPost.Size = New System.Drawing.Size(203, 22)
        Me.CodPost.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.fechaTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1196, 66)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = Global.codigoPostalApp.My.Resources.Resources.bc
        Me.Button2.Location = New System.Drawing.Point(1145, 4)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 47)
        Me.Button2.TabIndex = 28
        Me.Button2.UseVisualStyleBackColor = False
        '
        'fechaTxt
        '
        Me.fechaTxt.AutoSize = True
        Me.fechaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fechaTxt.Location = New System.Drawing.Point(682, 20)
        Me.fechaTxt.Name = "fechaTxt"
        Me.fechaTxt.Size = New System.Drawing.Size(120, 25)
        Me.fechaTxt.TabIndex = 3
        Me.fechaTxt.Text = "_________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(419, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 29)
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
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(223, 613)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PictureBox1.Image = Global.codigoPostalApp.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(629, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "_________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(485, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "La Fecha de hoy es"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(417, 362)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CODIGO POSTAL (CP):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(415, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DATOS DE CONTACTO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(417, 116)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "NOMBRE(S): *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(807, 116)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "APELLIDO 1:*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(420, 194)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "APELLIDO 2:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(804, 194)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "TELEFONO:*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(807, 295)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "CONFIRMAR EMAIL:*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(423, 295)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "EMAIL:*"
        '
        'names
        '
        Me.names.Location = New System.Drawing.Point(421, 134)
        Me.names.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.names.Name = "names"
        Me.names.Size = New System.Drawing.Size(203, 22)
        Me.names.TabIndex = 14
        '
        'lastname_1
        '
        Me.lastname_1.Location = New System.Drawing.Point(808, 134)
        Me.lastname_1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lastname_1.Name = "lastname_1"
        Me.lastname_1.Size = New System.Drawing.Size(203, 22)
        Me.lastname_1.TabIndex = 15
        '
        'phone_number
        '
        Me.phone_number.Location = New System.Drawing.Point(808, 213)
        Me.phone_number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.phone_number.Name = "phone_number"
        Me.phone_number.Size = New System.Drawing.Size(203, 22)
        Me.phone_number.TabIndex = 17
        '
        'lastname_2
        '
        Me.lastname_2.Location = New System.Drawing.Point(421, 213)
        Me.lastname_2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lastname_2.Name = "lastname_2"
        Me.lastname_2.Size = New System.Drawing.Size(203, 22)
        Me.lastname_2.TabIndex = 16
        '
        'email_confirm
        '
        Me.email_confirm.Location = New System.Drawing.Point(808, 314)
        Me.email_confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.email_confirm.Name = "email_confirm"
        Me.email_confirm.Size = New System.Drawing.Size(203, 22)
        Me.email_confirm.TabIndex = 19
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(421, 314)
        Me.email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(203, 22)
        Me.email.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(809, 448)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "MUNICIPIO:*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(425, 448)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "ESTADO:*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(807, 522)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(178, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "TIPO DE ASENTAMIENTO:*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(423, 522)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "ASENTAMINETO:*"
        '
        'estadoBox
        '
        Me.estadoBox.FormattingEnabled = True
        Me.estadoBox.Location = New System.Drawing.Point(420, 469)
        Me.estadoBox.Name = "estadoBox"
        Me.estadoBox.Size = New System.Drawing.Size(204, 24)
        Me.estadoBox.TabIndex = 28
        '
        'MunicipioBox
        '
        Me.MunicipioBox.FormattingEnabled = True
        Me.MunicipioBox.Location = New System.Drawing.Point(807, 469)
        Me.MunicipioBox.Name = "MunicipioBox"
        Me.MunicipioBox.Size = New System.Drawing.Size(204, 24)
        Me.MunicipioBox.TabIndex = 29
        '
        'TipAsentaBox
        '
        Me.TipAsentaBox.FormattingEnabled = True
        Me.TipAsentaBox.Location = New System.Drawing.Point(807, 541)
        Me.TipAsentaBox.Name = "TipAsentaBox"
        Me.TipAsentaBox.Size = New System.Drawing.Size(204, 24)
        Me.TipAsentaBox.TabIndex = 30
        '
        'AsentamientoBox
        '
        Me.AsentamientoBox.FormattingEnabled = True
        Me.AsentamientoBox.Location = New System.Drawing.Point(420, 541)
        Me.AsentamientoBox.Name = "AsentamientoBox"
        Me.AsentamientoBox.Size = New System.Drawing.Size(204, 24)
        Me.AsentamientoBox.TabIndex = 31
        '
        'CiudadBox
        '
        Me.CiudadBox.FormattingEnabled = True
        Me.CiudadBox.Location = New System.Drawing.Point(808, 397)
        Me.CiudadBox.Name = "CiudadBox"
        Me.CiudadBox.Size = New System.Drawing.Size(204, 24)
        Me.CiudadBox.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(809, 378)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 16)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = " CIUDAD*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1191, 607)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CiudadBox)
        Me.Controls.Add(Me.AsentamientoBox)
        Me.Controls.Add(Me.TipAsentaBox)
        Me.Controls.Add(Me.MunicipioBox)
        Me.Controls.Add(Me.estadoBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
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
        Me.Controls.Add(Me.CodPost)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents CodPost As TextBox
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
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents estadoBox As ComboBox
    Friend WithEvents MunicipioBox As ComboBox
    Friend WithEvents TipAsentaBox As ComboBox
    Friend WithEvents AsentamientoBox As ComboBox
    Friend WithEvents CiudadBox As ComboBox
    Friend WithEvents Label16 As Label
End Class
