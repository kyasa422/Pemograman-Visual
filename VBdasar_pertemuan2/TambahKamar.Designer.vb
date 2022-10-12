<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKamar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtValueKamar = New System.Windows.Forms.TextBox()
        Me.BtnAddkamar = New System.Windows.Forms.Button()
        Me.BtnTambahkamar = New System.Windows.Forms.Button()
        Me.JumlahKamar = New System.Windows.Forms.Label()
        Me.BtnRemovekamar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(104, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kamar tersedia saat ini"
        '
        'TxtValueKamar
        '
        Me.TxtValueKamar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TxtValueKamar.Location = New System.Drawing.Point(54, 106)
        Me.TxtValueKamar.Name = "TxtValueKamar"
        Me.TxtValueKamar.Size = New System.Drawing.Size(236, 23)
        Me.TxtValueKamar.TabIndex = 6
        '
        'BtnAddkamar
        '
        Me.BtnAddkamar.Location = New System.Drawing.Point(296, 106)
        Me.BtnAddkamar.Name = "BtnAddkamar"
        Me.BtnAddkamar.Size = New System.Drawing.Size(30, 23)
        Me.BtnAddkamar.TabIndex = 8
        Me.BtnAddkamar.Text = "+"
        Me.BtnAddkamar.UseVisualStyleBackColor = True
        '
        'BtnTambahkamar
        '
        Me.BtnTambahkamar.Location = New System.Drawing.Point(13, 139)
        Me.BtnTambahkamar.Name = "BtnTambahkamar"
        Me.BtnTambahkamar.Size = New System.Drawing.Size(313, 23)
        Me.BtnTambahkamar.TabIndex = 9
        Me.BtnTambahkamar.Text = "Tambah"
        Me.BtnTambahkamar.UseVisualStyleBackColor = True
        '
        'JumlahKamar
        '
        Me.JumlahKamar.AutoSize = True
        Me.JumlahKamar.Location = New System.Drawing.Point(155, 57)
        Me.JumlahKamar.Name = "JumlahKamar"
        Me.JumlahKamar.Size = New System.Drawing.Size(19, 15)
        Me.JumlahKamar.TabIndex = 10
        Me.JumlahKamar.Text = "10"
        '
        'BtnRemovekamar
        '
        Me.BtnRemovekamar.Location = New System.Drawing.Point(13, 106)
        Me.BtnRemovekamar.Name = "BtnRemovekamar"
        Me.BtnRemovekamar.Size = New System.Drawing.Size(30, 23)
        Me.BtnRemovekamar.TabIndex = 7
        Me.BtnRemovekamar.Text = "-"
        Me.BtnRemovekamar.UseVisualStyleBackColor = True
        '
        'TambahKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 177)
        Me.Controls.Add(Me.JumlahKamar)
        Me.Controls.Add(Me.BtnTambahkamar)
        Me.Controls.Add(Me.BtnAddkamar)
        Me.Controls.Add(Me.BtnRemovekamar)
        Me.Controls.Add(Me.TxtValueKamar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahKamar"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValueKamar As TextBox
    Friend WithEvents BtnAddkamar As Button
    Friend WithEvents BtnTambahkamar As Button
    Friend WithEvents JumlahKamar As Label
    Friend WithEvents BtnRemovekamar As Button
End Class
