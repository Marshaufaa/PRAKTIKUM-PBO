Imports MySqlConnector

Public Module PembayaranCRUDModule

    Public Function GetAllPembayaran() As List(Of Pembayaran)
        Dim listData As New List(Of Pembayaran)()
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "SELECT p.ID_Pembayaran, p.ID_Penyewaan, s.NamaPenyewa, " &
                                  "p.MetodePembayaran, p.JumlahBayar, p.TanggalBayar, p.StatusPembayaran " &
                                  "FROM tb_pembayaran p " &
                                  "JOIN tb_penyewaan s ON p.ID_Penyewaan = s.ID " &
                                  "ORDER BY p.ID_Pembayaran DESC"

            Using cmd As New MySqlCommand(query, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        listData.Add(New Pembayaran() With {
                            .ID_Pembayaran = Convert.ToInt32(reader("ID_Pembayaran")),
                            .ID_Penyewaan = Convert.ToInt32(reader("ID_Penyewaan")),
                            .NamaPenyewa = reader("NamaPenyewa").ToString(),
                            .MetodePembayaran = reader("MetodePembayaran").ToString(),
                            .JumlahBayar = Convert.ToDecimal(reader("JumlahBayar")),
                            .TanggalBayar = Convert.ToDateTime(reader("TanggalBayar")),
                            .StatusPembayaran = reader("StatusPembayaran").ToString()
                        })
                    End While
                End Using
            End Using
        End Using
        Return listData
    End Function

    Public Sub InsertPembayaran(data As Pembayaran)
        Using conn = GetConnection()
            conn.Open()
            Dim query = "INSERT INTO tb_pembayaran (ID_Penyewaan, MetodePembayaran, JumlahBayar, TanggalBayar, StatusPembayaran) " &
                        "VALUES (@ID_Penyewaan, @Metode, @Jumlah, @Tanggal, @Status)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID_Penyewaan", data.ID_Penyewaan)
                cmd.Parameters.AddWithValue("@Metode", data.MetodePembayaran)
                cmd.Parameters.AddWithValue("@Jumlah", data.JumlahBayar)
                cmd.Parameters.AddWithValue("@Tanggal", data.TanggalBayar)
                cmd.Parameters.AddWithValue("@Status", data.StatusPembayaran)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetHargaPenyewaanByID(id As Integer) As Decimal
        Dim harga As Decimal = 0
        Using conn = GetConnection()
            conn.Open()
            Dim query = "SELECT Harga FROM tb_penyewaan WHERE ID = @ID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    harga = Convert.ToDecimal(result)
                End If
            End Using
        End Using
        Return harga
    End Function

End Module