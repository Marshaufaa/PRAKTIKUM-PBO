import java.util.ArrayList;
import java.util.Scanner;

public class SistemSewa {
    public static void main(String[] args){
        ArrayList<PenyewaBoothnya> dataRamadhan = new ArrayList<>();
        Scanner input = new Scanner(System.in);
        int menu;
        final double HARGA_PER_UNIT = 3825000;

        do {
            System.out.println("\n---- SISTEM PENYEWAAN BOOTH PASAR RAMADHAN ----");
            System.out.println("1. Tambah Penyewa Baru");
            System.out.println("2. Tampilkan Semua Penyewa");
            System.out.println("3. Edit Data Penyewa (Update)");
            System.out.println("4. Hapus Data Penyewa (Delete)");
            System.out.println("5. Keluar");
            System.out.print("Pilih menu: ");
            menu = input.nextInt();
            input.nextLine();

            switch (menu){
                case 1:
                    System.out.print("Nama Penyewa: ");
                    String nama = input.nextLine();
                    System.out.print("Jumlah Unit Booth: ");
                    int jumlah = input.nextInt();

                    if (jumlah > 4) {
                        System.out.println("MAAF, PEMESANAN GAGAL! Maksimal sewa 4 unit.");
                    } else if (jumlah <= 0) {
                        System.out.println("Jumlah unit tidak valid!");
                    } else {
                        double total = jumlah * HARGA_PER_UNIT;
                        dataRamadhan.add(new PenyewaBoothnya(nama, jumlah, total));
                        System.out.println("Data berhasil ditambahkan!");
                    }
                    break;

                case 2:
                    if (dataRamadhan.isEmpty()){
                        System.out.println("Belum ada penyewa.");
                    } else {
                        System.out.println("\n---- DAFTAR PENYEWA ----");
                        for (int i = 0; i < dataRamadhan.size(); i++){
                            System.out.println("ID [" + i + "]");
                            dataRamadhan.get(i).cetakStruk();
                            System.out.println("------------------------");
                        }
                    }
                    break;

                case 3:
                    System.out.print("Masukkan ID yang mau diedit: ");
                    int idEdit = input.nextInt();
                    input.nextLine();
                    if (idEdit >= 0 && idEdit < dataRamadhan.size()){
                        PenyewaBoothnya penyewa = dataRamadhan.get(idEdit);

                        System.out.print("Nama Baru: ");
                        String nBaru = input.nextLine();
                        System.out.print("Jumlah Unit Baru: ");
                        int jBaru = input.nextInt();

                        if (jBaru > 4) {
                            System.out.println("Update Gagal! Maksimal 4 unit.");
                        } else {
                            penyewa.setNamaPenyewa(nBaru);
                            penyewa.setJumlahUnitBooth(jBaru);
                            penyewa.setTotalBayar(jBaru * HARGA_PER_UNIT);
                            System.out.println("Data berhasil diperbarui!");
                        }
                    } else {
                        System.out.println("ID tidak ditemukan!");
                    }
                    break;

                case 4:
                    System.out.print("Masukkan ID yang mau dihapus: ");
                    int idHapus = input.nextInt();
                    if (idHapus >= 0 && idHapus < dataRamadhan.size()){
                        dataRamadhan.remove(idHapus);
                        System.out.println("Data berhasil dihapus!");
                    } else {
                        System.out.println("ID tidak ditemukan!");
                    }
                    break;

                case 5:
                    System.out.println("Keluar program...");
                    break;

                default:
                    System.out.println("Pilihan tidak tersedia.");
            }
        } while (menu != 5);

        input.close();
    }
}