import java.util.ArrayList;
import java.util.Scanner;

public class SistemSewa {
    public static void main(String[] args){
        ArrayList<PenyewaBoothnya> dataRamadhan = new ArrayList<>();
        Scanner input = new Scanner(System.in);
        int menu;

        do{
            System.out.println("\n---- SISTEM PENYEWAAN BOOTH PASAR RAMADHAN ----");
            System.out.println("1. tambah penyewa baru");
            System.out.println("2. tampilkan semua penyewa");
            System.out.println("3. edit data penyewa");
            System.out.println("4. hapus data penyewa");
            System.out.println("5. keluar");
            System.out.print("pilih menu: ");
            menu = input.nextInt();
            input.nextLine();

            switch (menu){
                case 1: // ini  create
                    System.out.println("nama penyewa = ");
                    String namaPenyewa = input.nextLine();
                    System.out.println("jumlah unit booth yang disewa = ");
                    int jumlahUnitBooth = input.nextInt();

                    if (jumlahUnitBooth > 4) {
                        System.out.println("MAAF, PEMESANAN GAGAL! maksimal sewa 4 unit perorang.");
                    } else if (jumlahUnitBooth <= 0) {
                        System.out.println("Jumlah unit tidak valid!");
                    } else {
                        double totalBayar = jumlahUnitBooth * 3825000;
                        dataRamadhan.add(new PenyewaBoothnya(namaPenyewa, jumlahUnitBooth, totalBayar));
                        System.out.println("data berhasil ditambahin");
                    }
                    break;

                case 2: // ini read nya
                    if (dataRamadhan.isEmpty()){
                        System.out.println("belum ada penyewa");
                    } else {
                        System.out.println("\n---- DAFTAR PENYEWA ----");
                        for (int i = 0; i < dataRamadhan.size(); i++){
                            System.out.println("ID [" + i + "] ");
                            dataRamadhan.get(i).cetakStruk();
                        }
                    }
                    break;

                case 3: // ini update nya
                    System.out.println("masukan id yang mau diedit = ");
                    int idEdit = input.nextInt();
                    input.nextLine();
                    if (idEdit >= 0 && idEdit < dataRamadhan.size()){
                        System.out.println("nama = ");
                        String nBaru = input.nextLine();
                        System.out.println("jumlah unit booth yang baru = ");
                        int jBaru = input.nextInt();

                        if (jBaru > 4) {
                            System.out.println("Update Gagal! Maksimal 4 unit.");
                        } else {
                            double tBaru = jBaru * 3825000;
                            dataRamadhan.set(idEdit, new PenyewaBoothnya(nBaru, jBaru, tBaru));
                            System.out.println("data berhasil diubah");
                        }
                    } else {
                        System.out.println("ID nya tidak ketemu");
                    }
                    break;

                case 4: // ini delete nya
                    System.out.println("masukan id yang mau dihapus = ");
                    int idHapus = input.nextInt();
                    if (idHapus >= 0 && idHapus < dataRamadhan.size()){
                        dataRamadhan.remove(idHapus);
                        System.out.println("data berhasil dihapus");
                    } else {
                        System.out.println("id nya tidak ketemu");
                    }
                    break;

                case 5:
                    System.out.println("keluar program.......");
                    break;

                default:
                    System.out.println("pilihan tidak tersedia");
            }
        } while (menu != 5);

        input.close();
    }
}