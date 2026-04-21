<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        MenuUtamaToolStripMenuItem = New ToolStripMenuItem()
        MenuPembayaranToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPageInput = New TabPage()
        lblID = New Label()
        btnSimpan = New Button()
        dtpTanggal = New DateTimePicker()
        Label5 = New Label()
        numHarga = New NumericUpDown()
        Label4 = New Label()
        numDurasi = New NumericUpDown()
        Label3 = New Label()
        txtLokasi = New TextBox()
        Label2 = New Label()
        txtNamaPenyewa = New TextBox()
        Label1 = New Label()
        TabPageData = New TabPage()
        btnHapus = New Button()
        btnEdit = New Button()
        dgvData = New DataGridView()
        txtSearch = New TextBox()
        Label6 = New Label()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPageInput.SuspendLayout()
        CType(numHarga, ComponentModel.ISupportInitialize).BeginInit()
        CType(numDurasi, ComponentModel.ISupportInitialize).BeginInit()
        TabPageData.SuspendLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuUtamaToolStripMenuItem, MenuPembayaranToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(1120, 35)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuUtamaToolStripMenuItem
        ' 
        MenuUtamaToolStripMenuItem.Name = "MenuUtamaToolStripMenuItem"
        MenuUtamaToolStripMenuItem.Size = New Size(153, 29)
        MenuUtamaToolStripMenuItem.Text = "Halaman Utama"
        ' 
        ' MenuPembayaranToolStripMenuItem
        ' 
        MenuPembayaranToolStripMenuItem.Name = "MenuPembayaranToolStripMenuItem"
        MenuPembayaranToolStripMenuItem.Size = New Size(155, 29)
        MenuPembayaranToolStripMenuItem.Text = "Kelola Pembayaran"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(74, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPageInput)
        TabControl1.Controls.Add(TabPageData)
        TabControl1.Location = New Point(17, 63)
        TabControl1.Margin = New Padding(4, 5, 4, 5)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1086, 685)
        TabControl1.TabIndex = 1
        ' 
        ' TabPageInput
        ' 
        TabPageInput.Controls.Add(lblID)
        TabPageInput.Controls.Add(btnSimpan)
        TabPageInput.Controls.Add(dtpTanggal)
        TabPageInput.Controls.Add(Label5)
        TabPageInput.Controls.Add(numHarga)
        TabPageInput.Controls.Add(Label4)
        TabPageInput.Controls.Add(numDurasi)
        TabPageInput.Controls.Add(Label3)
        TabPageInput.Controls.Add(txtLokasi)
        TabPageInput.Controls.Add(Label2)
        TabPageInput.Controls.Add(txtNamaPenyewa)
        TabPageInput.Controls.Add(Label1)
        TabPageInput.Location = New Point(4, 34)
        TabPageInput.Margin = New Padding(4, 5, 4, 5)
        TabPageInput.Name = "TabPageInput"
        TabPageInput.Padding = New Padding(4, 5, 4, 5)
        TabPageInput.Size = New Size(1078, 647)
        TabPageInput.TabIndex = 0
        TabPageInput.Text = "Form Input"
        TabPageInput.UseVisualStyleBackColor = True
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(214, 367)
        lblID.Margin = New Padding(4, 0, 4, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(22, 25)
        lblID.TabIndex = 0
        lblID.Text = "0"
        lblID.Visible = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(214, 408)
        btnSimpan.Margin = New Padding(4, 5, 4, 5)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(171, 58)
        btnSimpan.TabIndex = 1
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(214, 312)
        dtpTanggal.Margin = New Padding(4, 5, 4, 5)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(284, 31)
        dtpTanggal.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 317)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 25)
        Label5.TabIndex = 3
        Label5.Text = "Tanggal Sewa"
        ' 
        ' numHarga
        ' 
        numHarga.DecimalPlaces = 2
        numHarga.Location = New Point(214, 245)
        numHarga.Margin = New Padding(4, 5, 4, 5)
        numHarga.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        numHarga.Name = "numHarga"
        numHarga.Size = New Size(286, 31)
        numHarga.TabIndex = 4
        numHarga.ThousandsSeparator = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(37, 250)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 25)
        Label4.TabIndex = 5
        Label4.Text = "Harga (Rp)"
        ' 
        ' numDurasi
        ' 
        numDurasi.Location = New Point(214, 178)
        numDurasi.Margin = New Padding(4, 5, 4, 5)
        numDurasi.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        numDurasi.Name = "numDurasi"
        numDurasi.Size = New Size(143, 31)
        numDurasi.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 183)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 25)
        Label3.TabIndex = 7
        Label3.Text = "Durasi Sewa (Hari)"
        ' 
        ' txtLokasi
        ' 
        txtLokasi.Location = New Point(214, 112)
        txtLokasi.Margin = New Padding(4, 5, 4, 5)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(427, 31)
        txtLokasi.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 117)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 25)
        Label2.TabIndex = 9
        Label2.Text = "Lokasi Videotron"
        ' 
        ' txtNamaPenyewa
        ' 
        txtNamaPenyewa.Location = New Point(214, 45)
        txtNamaPenyewa.Margin = New Padding(4, 5, 4, 5)
        txtNamaPenyewa.Name = "txtNamaPenyewa"
        txtNamaPenyewa.Size = New Size(427, 31)
        txtNamaPenyewa.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 50)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 11
        Label1.Text = "Nama Penyewa"
        ' 
        ' TabPageData
        ' 
        TabPageData.Controls.Add(btnHapus)
        TabPageData.Controls.Add(btnEdit)
        TabPageData.Controls.Add(dgvData)
        TabPageData.Controls.Add(txtSearch)
        TabPageData.Controls.Add(Label6)
        TabPageData.Location = New Point(4, 34)
        TabPageData.Margin = New Padding(4, 5, 4, 5)
        TabPageData.Name = "TabPageData"
        TabPageData.Padding = New Padding(4, 5, 4, 5)
        TabPageData.Size = New Size(1078, 647)
        TabPageData.TabIndex = 1
        TabPageData.Text = "Data Penyewaan"
        TabPageData.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHapus.Location = New Point(159, 567)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(129, 50)
        btnHapus.TabIndex = 0
        btnHapus.Text = "Hapus Data"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnEdit.Location = New Point(21, 567)
        btnEdit.Margin = New Padding(4, 5, 4, 5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(129, 50)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit Data"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AllowUserToDeleteRows = False
        dgvData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(21, 92)
        dgvData.Margin = New Padding(4, 5, 4, 5)
        dgvData.MultiSelect = False
        dgvData.Name = "dgvData"
        dgvData.ReadOnly = True
        dgvData.RowHeadersWidth = 51
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.Size = New Size(1029, 458)
        dgvData.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(113, 28)
        txtSearch.Margin = New Padding(4, 5, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(427, 31)
        txtSearch.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 33)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 25)
        Label6.TabIndex = 4
        Label6.Text = "Cari Data:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1120, 768)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        MinimumSize = New Size(1135, 802)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Penyewaan Videotron"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPageInput.ResumeLayout(False)
        TabPageInput.PerformLayout()
        CType(numHarga, ComponentModel.ISupportInitialize).EndInit()
        CType(numDurasi, ComponentModel.ISupportInitialize).EndInit()
        TabPageData.ResumeLayout(False)
        TabPageData.PerformLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuUtamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuPembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageInput As TabPage
    Friend WithEvents TabPageData As TabPage

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamaPenyewa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numDurasi As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numHarga As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents btnSimpan As Button
    Friend WithEvents lblID As Label

    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

End Class