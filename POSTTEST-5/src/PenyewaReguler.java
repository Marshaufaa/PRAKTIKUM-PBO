public class PenyewaReguler extends PenyewaBoothnya {

    public PenyewaReguler(String namaPenyewa, int jumlahUnitBooth, double hargaPerUnit) {
        super(namaPenyewa, jumlahUnitBooth, "Reguler");
        this.totalBayar = (double) jumlahUnitBooth * hargaPerUnit;
    }

    @Override
    public void cetakStruk() {
        System.out.println("Tipe Penyewa                  : " + this.tipePenyewa);
        System.out.println("Nama Penyewa                  : " + this.namaPenyewa);
        System.out.println("Jumlah Unit Booth             : " + this.jumlahUnitBooth);
        System.out.println("Total Bayar                   : Rp " + this.totalBayar);
    }
}