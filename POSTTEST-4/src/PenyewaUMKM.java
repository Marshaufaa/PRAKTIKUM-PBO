public class PenyewaUMKM extends PenyewaBoothnya {
    private final double diskon = 0.15;

    public PenyewaUMKM(String namaPenyewa, int jumlahUnitBooth, double hargaPerUnit) {
        super(namaPenyewa, jumlahUnitBooth, "UMKM (Diskon 15%)");
        double hargaNormal = (double) jumlahUnitBooth * hargaPerUnit;
        this.setTotalBayar(hargaNormal - (hargaNormal * diskon));
    }
    @Override
    public void cetakStruk() {
        super.cetakStruk();
        System.out.println("Total Bayar (Setelah Diskon)  : Rp " + this.totalBayar);
    }
    @Override
    public String toString() {
        return super.toString() + " - Dukung Produk Lokal!";
    }
}