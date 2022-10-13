Public Class lbkeluhan
    Public Shared Kamar As Integer = 100

    Dim nik As String
    Dim Nama As String
    Dim janis_kelamin As String
    Dim max_char_alamat = 50
    Dim tempMaxCharAlamat = max_char_alamat
    Dim keluhan As String = ""
    Dim keluhan_arrlist As New List(Of String)
    Dim keluhan_arrlist_id As New List(Of String)
    Dim layanan As New List(Of String) From {"Inap", "Poliklinik", "Spesialis"}
    Dim foto
    Public Shared foto_pasien
    Public Shared nama_pasien
    Public Shared nik_pasien
    Public Shared jenis_kelamin_ As String
    Public Shared tanggal_lahir
    Public Shared alamat
    Public Shared layanan_value
    Public Shared catatatn_dokter
    Public Shared keluhan_list As New List(Of String)




    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Lblhasil.Text = Kamar.ToString()
        ComboBoxlayanan.DataSource = layanan
    End Sub


    Private Sub Btnpesan_Click(sender As Object, e As EventArgs) Handles Btnpesan.Click
        nama_pasien = txtNama.Text
        nik_pasien = txtNik.Text
        tanggal_lahir = Datetanggallahir.Value.ToShortDateString
        alamat = RichTextBox1.Text
        layanan_value = ComboBoxlayanan.SelectedItem()
        catatatn_dokter = catatandoktertb.Text

        If cbpusing.Checked() Then

            keluhan_list.Add("Pusing")
        End If
        If cbdemam.Checked() Then
            keluhan_list.Add("Demam")
        End If

        If cbmual.Checked() Then
            keluhan_list.Add("Mual")
        End If

        Kamar -= 1

        Dim pasien = New pasien()
        pasien.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblNik.Click

    End Sub

    Private Sub Btnkamar_Click(sender As Object, e As EventArgs) Handles Btnkamar.Click
        Dim tambah_kamar = New TambahKamar()
        tambah_kamar.Show()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Lblhasil.Text = Kamar
    End Sub

    Private Sub txtNik_TextChanged(sender As Object, e As EventArgs) Handles txtNik.TextChanged

    End Sub

    Private Sub txtNik_SizeChanged(sender As Object, e As EventArgs) Handles txtNik.SizeChanged

    End Sub

    Private Sub txtNik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNik.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True

            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub txtNama_Leave(sender As Object, e As EventArgs) Handles txtNama.Leave
        If txtNama.Text.Length < 1 Then
            txtNama.Select()
            MessageBox.Show("Please aadd At least 1 String")
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        janis_kelamin = "Laki-Laki"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        janis_kelamin = "Perempuan"
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cbpusing_CheckedChanged(sender As Object, e As EventArgs) Handles cbpusing.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbmual.CheckedChanged

    End Sub

    Private Sub btnoutput_Click(sender As Object, e As EventArgs) Handles btnoutput.Click
        If cbpusing.Checked() Then
            keluhan += "pucing aku"
        End If

        If cbdemam.Checked() Then
            keluhan += "demam akuh"
        End If

        If cbmual.Checked() Then
            keluhan += "mual-mual sedang hamil aku"
        End If

        MessageBox.Show(keluhan)

        keluhan = ""

    End Sub



    Private Sub btnoutputlist_Click(sender As Object, e As EventArgs) Handles btnoutputlist.Click
        If cbpusing.Checked() Then
            keluhan_arrlist.Add("pusing normal")
        End If

        If cbdemam.Checked() Then
            keluhan_arrlist.Add("Demam")
        End If

        If cbmual.Checked() Then
            keluhan_arrlist.Add("Mual")
        End If

        Dim keluhan_str = String.Join(",", keluhan_arrlist.ToArray)
        MessageBox.Show(keluhan_str)

        keluhan_arrlist.Clear()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnshowcbsel_Click(sender As Object, e As EventArgs) Handles btnshowcbsel.Click
        Dim layanan_item = ComboBoxlayanan.SelectedItem()
        MessageBox.Show(layanan_item)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndate.Click
        MessageBox.Show(Datetanggallahir.Value.ToString("dd/MMMM/yyyy"))
    End Sub

    Private Sub timelahir_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btntimelahir_Click(sender As Object, e As EventArgs)
        Dim current_time = DateTime.Now.ToString("yyyy/MM/dd:hh:mm:ss")
        MessageBox.Show(current_time)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Title = "Open foto"
        OpenFileDialog1.Filter = "Image|*.bmp|imageJPG|* Image JPEG|*.jpeg|Image PNG|*.png|image GIF|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        PictureBox1.Load(OpenFileDialog1.FileName)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        foto_pasien = PictureBox1.ImageLocation




    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
