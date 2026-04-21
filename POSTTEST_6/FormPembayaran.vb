Public Class FormPembayaran
    Private currentTotalTagihan As Decimal = 0

    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxPenyewaan()
        LoadDataPembayaran()
    End Sub

    Private Sub LoadComboBoxPenyewaan()
        Try
            Dim listPenyewaan = VideotronCRUDModule.GetAllPenyewaan("")
            cmbPenyewaan.DataSource = listPenyewaan
            cmbPenyewaan.DisplayMember = "NamaPenyewa"
            cmbPenyewaan.ValueMember = "ID"
            cmbPenyewaan.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Gagal memuat daftar penyewa: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbPenyewaan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPenyewaan.SelectedIndexChanged
        If cmbPenyewaan.SelectedIndex <> -1 AndAlso TypeOf cmbPenyewaan.SelectedValue Is Integer Then
            Dim id = Convert.ToInt32(cmbPenyewaan.SelectedValue)
            currentTotalTagihan = PembayaranCRUDModule.GetHargaPenyewaanByID(id)
            lblInfoTagihan.Text = "Total Tagihan: Rp " & currentTotalTagihan.ToString("N2")
        Else
            lblInfoTagihan.Text = "Total Tagihan: Rp 0.00"
            currentTotalTagihan = 0
        End If
    End Sub

    Private Sub LoadDataPembayaran()
        Try
            Dim listData = PembayaranCRUDModule.GetAllPembayaran()
            dgvPembayaran.DataSource = listData

            If dgvPembayaran.Columns.Contains("ID_Penyewaan") Then
                dgvPembayaran.Columns("ID_Penyewaan").Visible = False
            End If
            If dgvPembayaran.Columns.Contains("JumlahBayar") Then
                dgvPembayaran.Columns("JumlahBayar").DefaultCellStyle.Format = "N2"
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data pembayaran: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSimpanPembayaran_Click(sender As Object, e As EventArgs) Handles btnSimpanPembayaran.Click
        If cmbPenyewaan.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(cmbMetode.Text) Then
            MessageBox.Show("Penyewa dan Metode Pembayaran harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If numJumlahBayar.Value <= 0 Then
            MessageBox.Show("Jumlah bayar harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If numJumlahBayar.Value > currentTotalTagihan Then
            MessageBox.Show("Validasi Gagal: Jumlah bayar tidak boleh melebihi total tagihan penyewaan (Rp " & currentTotalTagihan.ToString("N2") & ")!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim statusBayar As String = "Belum Lunas"
        If numJumlahBayar.Value = currentTotalTagihan Then
            statusBayar = "Lunas"
        End If

        Dim data As New Pembayaran() With {
            .ID_Penyewaan = Convert.ToInt32(cmbPenyewaan.SelectedValue),
            .MetodePembayaran = cmbMetode.Text,
            .JumlahBayar = numJumlahBayar.Value,
            .TanggalBayar = dtpTanggalBayar.Value,
            .StatusPembayaran = statusBayar
        }

        Try
            PembayaranCRUDModule.InsertPembayaran(data)
            MessageBox.Show("Pembayaran berhasil dicatat dengan status: " & statusBayar, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            numJumlahBayar.Value = 0
            cmbMetode.SelectedIndex = -1
            cmbPenyewaan.SelectedIndex = -1
            dtpTanggalBayar.Value = DateTime.Now
            lblInfoTagihan.Text = "Total Tagihan: Rp 0.00"

            LoadDataPembayaran()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class