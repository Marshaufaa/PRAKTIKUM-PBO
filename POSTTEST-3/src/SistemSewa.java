import java.util.ArrayList;
import java.util.Scanner;

public class SistemSewa {
    public static void main(String[] args) {
        ArrayList<PenyewaBoothnya> dataRamadhan = new ArrayList<>();
        Scanner input = new Scanner(System.in);
        int menu;
        final double HARGA_PER_UNIT = 3825000;

        do {
            System.out.println("\n---- SISTEM PENYEWAAN BOOTH PASAR RAMADHAN ----");
            System.out.println("1. Tambah Penyewa Baru");
            System.out.println("2. Tampilkan Semua Penyewa");
            System.out.println("3. Hapus Data Penyewa");
            System.out.println("4. Keluar");
            System.out.print("Pilih menu: ");
            menu = input.nextInt();
            input.nextLine();

            switch (menu) {
                case 1:
                    System.out.print("Nama Penyewa: ");
                    String nama = input.nextLine();
                    System.out.print("Jumlah Unit Booth: ");
                    int jumlah = input.nextInt();

                    if (jumlah > 4 || jumlah <= 0) {
                        System.out.println("Jumlah unit tidak valid! (Max 4)");
                    } else {
                        System.out.println("Pilih Tipe: 1. Reguler | 2. UMKM");
                        int tipe = input.nextInt();
                        if (tipe == 1) {
                            dataRamadhan.add(new PenyewaReguler(nama, jumlah, HARGA_PER_UNIT));
                        } else {
                            dataRamadhan.add(new PenyewaUMKM(nama, jumlah, HARGA_PER_UNIT));
                        }
                        System.out.println("Data berhasil ditambahkan!");
                    }
                    break;

                case 2:
                    if (dataRamadhan.isEmpty()) {
                        System.out.println("Belum ada penyewa.");
                    } else {
                        System.out.println("\n---- DAFTAR PENYEWA ----");
                        for (int i = 0; i < dataRamadhan.size(); i++) {
                            System.out.println("ID [" + i + "]");
                            dataRamadhan.get(i).cetakStruk();
                            System.out.println("------------------------");
                        }
                    }
                    break;

                case 3:
                    System.out.print("Masukkan ID yang dihapus: ");
                    int id = input.nextInt();
                    if (id >= 0 && id < dataRamadhan.size()) {
                        dataRamadhan.remove(id);
                        System.out.println("Berhasil dihapus!");
                    } else {
                        System.out.println("ID tidak ditemukan!");
                    }
                    break;

                case 4:
                    System.out.println("Keluar...");
                    break;
            }
        } while (menu != 4);
        input.close();
    }
}