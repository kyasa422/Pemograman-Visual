Public Class pasien
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not String.IsNullOrEmpty(lbkeluhan.foto_pasien) Then
            pictfoto.Load(lbkeluhan.foto_pasien)

            pictfoto.SizeMode = PictureBoxSizeMode.StretchImage

        End If


        namalabel.Text = lbkeluhan.nama_pasien
        niklabel.Text = lbkeluhan.nik_pasien
        kelaminlabel.Text = lbkeluhan.jenis_kelamin_
        tgllabel.Text = lbkeluhan.tanggal_lahir
        kelaminlabel.Text = lbkeluhan.layanan_value
        alamatlabel.Text = lbkeluhan.alamat

        listboxkeluhan.Items.Clear()

        For Each kel In lbkeluhan.keluhan_list
            listboxkeluhan.Items.Add(kel)
        Next

        lbkeluhan.keluhan_list.Clear()

        lblcatatan.Text = lbkeluhan.catatatn_dokter


    End Sub
    Private Sub pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load







    End Sub

    Private Sub niklabel_Click(sender As Object, e As EventArgs) Handles niklabel.Click

    End Sub
End Class