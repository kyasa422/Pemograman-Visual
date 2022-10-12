Public Class lbkeluhan
    Public Shared Kamar As Integer = 100

    Dim nik As String
    Dim nama As String
    Dim janis_kelamin As String
    Dim max_char_alamat = 50
    Dim tempMaxCharAlamat = max_char_alamat
    Dim keluhan As String = ""
    Dim keluhan_arrlist As New List(Of String)
    Dim keluhan_arrlist_id As New List(Of String)
    Dim layanan As New List(Of String) From {"Inap", "Poliklinik", "Spesialis"}



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Lblhasil.Text = Kamar.ToString()
        ComboBoxlayanan.DataSource = layanan
    End Sub


    Private Sub Btnpesan_Click(sender As Object, e As EventArgs) Handles Btnpesan.Click
        Dim nama = MessageBox.Show(txtNama.Text)

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

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If RichTextBox1.Text.Length >= max_char_alamat Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("max Length")
            End If
        ElseIf Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            tempMaxCharAlamat -= 1
            lblalamat.Text = tempMaxCharAlamat.ToString()
        ElseIf tempMaxCharAlamat < max_char_alamat Then
            tempMaxCharAlamat += 1
            lblalamat.Text = tempMaxCharAlamat.ToString()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        janis_kelamin = "Laki-Laki"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        janis_kelamin = "Perempuan"
    End Sub

    Private Sub btnJenis_Click(sender As Object, e As EventArgs) Handles btnJenis.Click

        btnJenis.Text = " Select " + janis_kelamin
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxkeluhan.SelectedIndexChanged

    End Sub

    Private Sub btntf_Click(sender As Object, e As EventArgs) Handles btntf.Click
        listboxkeluhan.Items.Clear()
        If cbpusing.Checked() Then
            keluhan_arrlist.Add("Pusing")
        End If
        If cbdemam.Checked() Then
            keluhan_arrlist.Add("Demam")
        End If

        If cbmual.Checked() Then
            keluhan_arrlist.Add("Mual")
        End If

        For Each kel In keluhan_arrlist
            listboxkeluhan.Items.Add(kel)
        Next
        keluhan_arrlist.Clear()
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        Dim add_item = txtadaitem.Text
        lboxkeluhanadd.Items.Add(add_item)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(lboxkeluhanadd.SelectedItem())
    End Sub

    Private Sub btncheckedlist_Click(sender As Object, e As EventArgs) Handles btncheckedlist.Click
        For i = 0 To CheckedListBoxkeluhan.Items.Count - 1
            Dim Item As Object = CheckedListBoxkeluhan.Items(i)

            If CheckedListBoxkeluhan.GetItemChecked(i) Then
                keluhan_arrlist.Add(CheckedListBoxkeluhan.Items(i))
            End If
        Next

        Dim keluhan_str = String.Join(",", keluhan_arrlist.ToArray)
        MessageBox.Show(keluhan_str)

        keluhan_arrlist.Clear()

    End Sub

    Private Sub btntflist_Click(sender As Object, e As EventArgs) Handles btntflist.Click
        For i As Integer = 0 To CheckedListBoxkeluhan.Items.Count - 1
            CheckedListBoxkeluhan.SetItemChecked(i, False)
        Next

        If cbpusing.Checked() Then
            keluhan_arrlist_id.Add(0)
        End If

        If cbmual.Checked() Then
            keluhan_arrlist_id.Add(1)
        End If
        If cbdemam.Checked() Then
            keluhan_arrlist_id.Add(2)
        End If

        For Each kel In keluhan_arrlist_id
            CheckedListBoxkeluhan.SetItemChecked(kel, True)
        Next
        keluhan_arrlist_id.Clear()
    End Sub

    Private Sub btnshowcbsel_Click(sender As Object, e As EventArgs) Handles btnshowcbsel.Click
        Dim layanan_item = ComboBoxlayanan.SelectedItem()
        MessageBox.Show(layanan_item)
    End Sub
End Class
