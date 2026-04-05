public class PenyewaUMKM extends PenyewaBoothnya {
    private double diskon = 0.15; // untuk diskon 15%

    public PenyewaUMKM(String namaPenyewa, int jumlahUnitBooth, double hargaPerUnit) {
        super(namaPenyewa, jumlahUnitBooth, "UMKM (Diskon 15%)");
        double hargaNormal = jumlahUnitBooth * hargaPerUnit;
        this.totalBayar = hargaNormal - (hargaNormal * diskon);
    }

    @Override
    public void cetakStruk() {
        super.cetakStruk();
        System.out.println("Total Bayar (Setelah Diskon)  : Rp " + this.totalBayar);
    }
}
