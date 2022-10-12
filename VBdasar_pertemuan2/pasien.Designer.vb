<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pasien
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
        Me.pictfoto = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNik = New System.Windows.Forms.Label()
        Me.keluhan_list = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.alamatlabel = New System.Windows.Forms.Label()
        Me.tgllabel = New System.Windows.Forms.Label()
        Me.kelaminlabel = New System.Windows.Forms.Label()
        Me.namalabel = New System.Windows.Forms.Label()
        Me.niklabel = New System.Windows.Forms.Label()
        CType(Me.pictfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictfoto
        '
        Me.pictfoto.BackgroundImage = Global.VBdasar_pertemuan2.My.Resources.Resources.iroro
        Me.pictfoto.Location = New System.Drawing.Point(31, 35)
        Me.pictfoto.Name = "pictfoto"
        Me.pictfoto.Size = New System.Drawing.Size(120, 134)
        Me.pictfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictfoto.TabIndex = 40
        Me.pictfoto.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(176, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Tanggal Lahir"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(176, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(176, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nama"
        '
        'LblNik
        '
        Me.LblNik.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNik.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNik.Location = New System.Drawing.Point(176, 35)
        Me.LblNik.Name = "LblNik"
        Me.LblNik.Size = New System.Drawing.Size(89, 17)
        Me.LblNik.TabIndex = 43
        Me.LblNik.Text = "Nik"
        '
        'keluhan_list
        '
        Me.keluhan_list.FormattingEnabled = True
        Me.keluhan_list.ItemHeight = 15
        Me.keluhan_list.Location = New System.Drawing.Point(178, 210)
        Me.keluhan_list.Name = "keluhan_list"
        Me.keluhan_list.Size = New System.Drawing.Size(386, 94)
        Me.keluhan_list.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(178, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(178, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Keluhan"
        '
        'alamatlabel
        '
        Me.alamatlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.alamatlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.alamatlabel.Location = New System.Drawing.Point(301, 165)
        Me.alamatlabel.Name = "alamatlabel"
        Me.alamatlabel.Size = New System.Drawing.Size(263, 17)
        Me.alamatlabel.TabIndex = 54
        Me.alamatlabel.Text = "Alamat"
        '
        'tgllabel
        '
        Me.tgllabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tgllabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tgllabel.Location = New System.Drawing.Point(299, 132)
        Me.tgllabel.Name = "tgllabel"
        Me.tgllabel.Size = New System.Drawing.Size(263, 17)
        Me.tgllabel.TabIndex = 53
        Me.tgllabel.Text = "Tanggal Lahir"
        '
        'kelaminlabel
        '
        Me.kelaminlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.kelaminlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.kelaminlabel.Location = New System.Drawing.Point(299, 97)
        Me.kelaminlabel.Name = "kelaminlabel"
        Me.kelaminlabel.Size = New System.Drawing.Size(263, 17)
        Me.kelaminlabel.TabIndex = 52
        Me.kelaminlabel.Text = "Jenis Kelamin"
        '
        'namalabel
        '
        Me.namalabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.namalabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.namalabel.Location = New System.Drawing.Point(299, 67)
        Me.namalabel.Name = "namalabel"
        Me.namalabel.Size = New System.Drawing.Size(263, 17)
        Me.namalabel.TabIndex = 50
        Me.namalabel.Text = "Nama"
        '
        'niklabel
        '
        Me.niklabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.niklabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.niklabel.Location = New System.Drawing.Point(299, 36)
        Me.niklabel.Name = "niklabel"
        Me.niklabel.Size = New System.Drawing.Size(263, 17)
        Me.niklabel.TabIndex = 51
        Me.niklabel.Text = "Nik"
        '
        'pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 450)
        Me.Controls.Add(Me.alamatlabel)
        Me.Controls.Add(Me.tgllabel)
        Me.Controls.Add(Me.kelaminlabel)
        Me.Controls.Add(Me.namalabel)
        Me.Controls.Add(Me.niklabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.keluhan_list)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNik)
        Me.Controls.Add(Me.pictfoto)
        Me.Name = "pasien"
        Me.Text = "pasien"
        CType(Me.pictfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pictfoto As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNik As Label
    Friend WithEvents keluhan_list As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents alamatlabel As Label
    Friend WithEvents tgllabel As Label
    Friend WithEvents kelaminlabel As Label
    Friend WithEvents namalabel As Label
    Friend WithEvents niklabel As Label
End Class
