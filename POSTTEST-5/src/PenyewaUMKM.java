public class PenyewaUMKM extends PenyewaBoothnya implements Diskonable {
    private final double PERSEN_DISKON = 0.15;

    public PenyewaUMKM(String namaPenyewa, int jumlahUnitBooth, double hargaPerUnit) {
        super(namaPenyewa, jumlahUnitBooth, "UMKM");
        double hargaNormal = (double) jumlahUnitBooth * hargaPerUnit;
        this.totalBayar = hargaNormal - hitungDiskon(hargaNormal);
    }

    @Override
    public double hitungDiskon(double hargaTotal) {
        return hargaTotal * PERSEN_DISKON;
    }

    @Override
    public void tampilkanPromo() {
        System.out.println(">>> PROMO KHUSUS UMKM: Diskon 15% diterapkan! <<<");
    }

    @Override
    public void cetakStruk() {
        tampilkanPromo();
        System.out.println("Tipe Penyewa                  : " + this.tipePenyewa);
        System.out.println("Nama Penyewa                  : " + this.namaPenyewa);
        System.out.println("Jumlah Unit Booth             : " + this.jumlahUnitBooth);
        System.out.println("Total Bayar (Setelah Diskon)  : Rp " + this.totalBayar);
    }

    @Override
    public String toString() {
        return super.toString() + " - [Dukung Produk Lokal!]";
    }
}