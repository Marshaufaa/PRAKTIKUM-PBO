Imports System.Windows.Forms

Public Class Form1
    Private isEditMode As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        ResetForm()
    End Sub

    Private Sub MenuUtamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuUtamaToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPageInput
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtNamaPenyewa.Text) OrElse String.IsNullOrWhiteSpace(txtLokasi.Text) Then
            MessageBox.Show("Nama Penyewa dan Lokasi Videotron tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If numDurasi.Value <= 0 OrElse numHarga.Value <= 0 Then
            MessageBox.Show("Durasi dan Harga harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim data As New Penyewaan() With {
            .NamaPenyewa = txtNamaPenyewa.Text.Trim(),
            .LokasiVideotron = txtLokasi.Text.Trim(),
            .DurasiSewa = Convert.ToInt32(numDurasi.Value),
            .Harga = numHarga.Value,
            .TanggalSewa = dtpTanggal.Value
        }

        Try
            If isEditMode Then
                data.ID = Convert.ToInt32(lblID.Text)
                VideotronCRUDModule.UpdatePenyewaan(data)
                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                VideotronCRUDModule.InsertPenyewaan(data)
                MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ResetForm()
            LoadData()
            TabControl1.SelectedTab = TabPageData
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResetForm()
        txtNamaPenyewa.Clear()
        txtLokasi.Clear()
        numDurasi.Value = 0
        numHarga.Value = 0
        dtpTanggal.Value = DateTime.Now
        lblID.Text = "0"
        isEditMode = False
        btnSimpan.Text = "Simpan"
    End Sub

    Private Sub LoadData(Optional search As String = "")
        Try
            Dim listData = VideotronCRUDModule.GetAllPenyewaan(search)
            dgvData.DataSource = listData

            If dgvData.Columns.Contains("Harga") Then
                dgvData.Columns("Harga").DefaultCellStyle.Format = "N2"
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadData(txtSearch.Text.Trim())
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvData.SelectedRows.Count > 0 Then
            Dim row = dgvData.SelectedRows(0)
            lblID.Text = row.Cells("ID").Value.ToString()
            txtNamaPenyewa.Text = row.Cells("NamaPenyewa").Value.ToString()
            txtLokasi.Text = row.Cells("LokasiVideotron").Value.ToString()
            numDurasi.Value = Convert.ToDecimal(row.Cells("DurasiSewa").Value)
            numHarga.Value = Convert.ToDecimal(row.Cells("Harga").Value)
            dtpTanggal.Value = Convert.ToDateTime(row.Cells("TanggalSewa").Value)

            isEditMode = True
            btnSimpan.Text = "Update Data"
            TabControl1.SelectedTab = TabPageInput
        Else
            MessageBox.Show("Pilih data di tabel yang ingin diedit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvData.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dgvData.SelectedRows(0).Cells("ID").Value)

            If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    VideotronCRUDModule.DeletePenyewaan(id)
                    LoadData(txtSearch.Text.Trim())
                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MenuPembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPembayaranToolStripMenuItem.Click
        Dim formBayar As New FormPembayaran()
        formBayar.ShowDialog()
    End Sub

End Class