Public Class TambahKamar

    Public TotalAddKamar As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JumlahKamar.Text = lbkeluhan.Kamar.ToString()
        TxtValueKamar.Text = TotalAddKamar

        If TotalAddKamar < 1 Then
            BtnRemovekamar.Enabled = False
        End If
    End Sub

    Private Sub JumlahKamar_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub JumlahKamar_Click_1(sender As Object, e As EventArgs) Handles JumlahKamar.Click

    End Sub

    Private Sub TxtValueKamar_TextChanged(sender As Object, e As EventArgs) Handles TxtValueKamar.TextChanged

    End Sub

    Private Sub BtnRemovekamar_Click(sender As Object, e As EventArgs) Handles BtnRemovekamar.Click
        TotalAddKamar = TotalAddKamar - 1
        TxtValueKamar.Text = TotalAddKamar

        If TotalAddKamar < 1 Then
            BtnRemovekamar.Enabled = False
        End If
    End Sub

    Private Sub BtnAddkamar_Click(sender As Object, e As EventArgs) Handles BtnAddkamar.Click
        TotalAddKamar = TotalAddKamar + 1
        TxtValueKamar.Text = TotalAddKamar

        If TotalAddKamar >= 1 Then
            BtnRemovekamar.Enabled = True
        End If
    End Sub

    Private Sub BtnTambahkamar_Click(sender As Object, e As EventArgs) Handles BtnTambahkamar.Click
        lbkeluhan.Kamar += Integer.Parse(TxtValueKamar.Text)


        Me.Close()
    End Sub
End Class