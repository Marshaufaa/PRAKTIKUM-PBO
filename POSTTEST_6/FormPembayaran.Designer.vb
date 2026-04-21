<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembayaran
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPenyewaan = New System.Windows.Forms.ComboBox()
        Me.lblInfoTagihan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMetode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numJumlahBayar = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTanggalBayar = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpanPembayaran = New System.Windows.Forms.Button()
        Me.dgvPembayaran = New System.Windows.Forms.DataGridView()
        CType(Me.numJumlahBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Data Penyewa"
        '
        'cmbPenyewaan
        '
        Me.cmbPenyewaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPenyewaan.FormattingEnabled = True
        Me.cmbPenyewaan.Location = New System.Drawing.Point(160, 27)
        Me.cmbPenyewaan.Name = "cmbPenyewaan"
        Me.cmbPenyewaan.Size = New System.Drawing.Size(300, 23)
        Me.cmbPenyewaan.TabIndex = 1
        '
        'lblInfoTagihan
        '
        Me.lblInfoTagihan.AutoSize = True
        Me.lblInfoTagihan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInfoTagihan.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblInfoTagihan.Location = New System.Drawing.Point(475, 30)
        Me.lblInfoTagihan.Name = "lblInfoTagihan"
        Me.lblInfoTagihan.Size = New System.Drawing.Size(126, 15)
        Me.lblInfoTagihan.TabIndex = 10
        Me.lblInfoTagihan.Text = "Total Tagihan: Rp 0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Metode Pembayaran"
        '
        'cmbMetode
        '
        Me.cmbMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMetode.FormattingEnabled = True
        Me.cmbMetode.Items.AddRange(New Object() {"Transfer Bank", "Qris", "Tunai"})
        Me.cmbMetode.Location = New System.Drawing.Point(160, 67)
        Me.cmbMetode.Name = "cmbMetode"
        Me.cmbMetode.Size = New System.Drawing.Size(200, 23)
        Me.cmbMetode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jumlah Bayar (Rp)"
        '
        'numJumlahBayar
        '
        Me.numJumlahBayar.DecimalPlaces = 2
        Me.numJumlahBayar.Location = New System.Drawing.Point(160, 107)
        Me.numJumlahBayar.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numJumlahBayar.Name = "numJumlahBayar"
        Me.numJumlahBayar.Size = New System.Drawing.Size(200, 23)
        Me.numJumlahBayar.TabIndex = 5
        Me.numJumlahBayar.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tanggal Bayar"
        '
        'dtpTanggalBayar
        '
        Me.dtpTanggalBayar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalBayar.Location = New System.Drawing.Point(160, 147)
        Me.dtpTanggalBayar.Name = "dtpTanggalBayar"
        Me.dtpTanggalBayar.Size = New System.Drawing.Size(200, 23)
        Me.dtpTanggalBayar.TabIndex = 7
        '
        'btnSimpanPembayaran
        '
        Me.btnSimpanPembayaran.Location = New System.Drawing.Point(160, 185)
        Me.btnSimpanPembayaran.Name = "btnSimpanPembayaran"
        Me.btnSimpanPembayaran.Size = New System.Drawing.Size(140, 35)
        Me.btnSimpanPembayaran.TabIndex = 8
        Me.btnSimpanPembayaran.Text = "Simpan Pembayaran"
        Me.btnSimpanPembayaran.UseVisualStyleBackColor = True
        '
        'dgvPembayaran
        '
        Me.dgvPembayaran.AllowUserToAddRows = False
        Me.dgvPembayaran.AllowUserToDeleteRows = False
        Me.dgvPembayaran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPembayaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembayaran.Location = New System.Drawing.Point(28, 240)
        Me.dgvPembayaran.Name = "dgvPembayaran"
        Me.dgvPembayaran.ReadOnly = True
        Me.dgvPembayaran.RowHeadersVisible = False
        Me.dgvPembayaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPembayaran.Size = New System.Drawing.Size(730, 200)
        Me.dgvPembayaran.TabIndex = 9
        '
        'FormPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lblInfoTagihan)
        Me.Controls.Add(Me.dgvPembayaran)
        Me.Controls.Add(Me.btnSimpanPembayaran)
        Me.Controls.Add(Me.dtpTanggalBayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numJumlahBayar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMetode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbPenyewaan)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kelola Pembayaran Videotron"
        CType(Me.numJumlahBayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPenyewaan As System.Windows.Forms.ComboBox
    Friend WithEvents lblInfoTagihan As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMetode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numJumlahBayar As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalBayar As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSimpanPembayaran As System.Windows.Forms.Button
    Friend WithEvents dgvPembayaran As System.Windows.Forms.DataGridView
End Class