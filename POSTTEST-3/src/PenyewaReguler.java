public class PenyewaReguler extends PenyewaBoothnya {
    public PenyewaReguler(String namaPenyewa, int jumlahUnitBooth, double hargaPerUnit) {
        super(namaPenyewa, jumlahUnitBooth, "Reguler");
        this.totalBayar = jumlahUnitBooth * hargaPerUnit;
    }

    @Override
    public void cetakStruk() {
        super.cetakStruk();
        System.out.println("Total Bayar                   : Rp " + this.totalBayar);
    }
}