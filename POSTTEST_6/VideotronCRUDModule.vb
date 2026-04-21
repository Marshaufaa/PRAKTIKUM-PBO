Imports MySqlConnector

Public Module VideotronCRUDModule

    Public Function GetAllPenyewaan(Optional searchKeyword As String = "") As List(Of Penyewaan)
        Dim listData As New List(Of Penyewaan)()

        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "SELECT * FROM tb_penyewaan"

            If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                query &= " WHERE NamaPenyewa LIKE @search " &
                         "OR LokasiVideotron LIKE @search " &
                         "OR CAST(ID AS CHAR) LIKE @search " &
                         "OR CAST(DurasiSewa AS CHAR) LIKE @search " &
                         "OR CAST(Harga AS CHAR) LIKE @search"
            End If

            query &= " ORDER BY ID DESC"

            Using cmd As New MySqlCommand(query, conn)
                If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchKeyword & "%")
                End If

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        listData.Add(New Penyewaan() With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .NamaPenyewa = reader("NamaPenyewa").ToString(),
                            .LokasiVideotron = reader("LokasiVideotron").ToString(),
                            .DurasiSewa = Convert.ToInt32(reader("DurasiSewa")),
                            .Harga = Convert.ToDecimal(reader("Harga")),
                            .TanggalSewa = Convert.ToDateTime(reader("TanggalSewa"))
                        })
                    End While
                End Using
            End Using
        End Using

        Return listData
    End Function

    Public Sub InsertPenyewaan(data As Penyewaan)
        Using conn = GetConnection()
            conn.Open()
            Dim query = "INSERT INTO tb_penyewaan (NamaPenyewa, LokasiVideotron, DurasiSewa, Harga, TanggalSewa) VALUES (@Nama, @Lokasi, @Durasi, @Harga, @Tanggal)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Nama", data.NamaPenyewa)
                cmd.Parameters.AddWithValue("@Lokasi", data.LokasiVideotron)
                cmd.Parameters.AddWithValue("@Durasi", data.DurasiSewa)
                cmd.Parameters.AddWithValue("@Harga", data.Harga)
                cmd.Parameters.AddWithValue("@Tanggal", data.TanggalSewa)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdatePenyewaan(data As Penyewaan)
        Using conn = GetConnection()
            conn.Open()
            Dim query = "UPDATE tb_penyewaan SET NamaPenyewa=@Nama, LokasiVideotron=@Lokasi, DurasiSewa=@Durasi, Harga=@Harga, TanggalSewa=@Tanggal WHERE ID=@ID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", data.ID)
                cmd.Parameters.AddWithValue("@Nama", data.NamaPenyewa)
                cmd.Parameters.AddWithValue("@Lokasi", data.LokasiVideotron)
                cmd.Parameters.AddWithValue("@Durasi", data.DurasiSewa)
                cmd.Parameters.AddWithValue("@Harga", data.Harga)
                cmd.Parameters.AddWithValue("@Tanggal", data.TanggalSewa)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeletePenyewaan(id As Integer)
        Using conn = GetConnection()
            conn.Open()
            Dim query = "DELETE FROM tb_penyewaan WHERE ID=@ID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module