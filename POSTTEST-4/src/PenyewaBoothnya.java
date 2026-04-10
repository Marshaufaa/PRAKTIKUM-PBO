public class PenyewaBoothnya {
    protected String namaPenyewa;
    protected int jumlahUnitBooth;
    protected double totalBayar;
    protected String tipePenyewa;

    public PenyewaBoothnya(String namaPenyewa, int jumlahUnitBooth, String tipePenyewa) {
        this.namaPenyewa = namaPenyewa;
        this.jumlahUnitBooth = jumlahUnitBooth;
        this.tipePenyewa = tipePenyewa;
    }
    public void setTotalBayar(double totalBayar) {
        this.totalBayar = totalBayar;
    }
    public void setTotalBayar(int jumlah, double harga) {
        this.totalBayar = (double) jumlah * harga;
    }

    public String getNamaPenyewa() { return namaPenyewa; }
    public int getJumlahUnitBooth() { return jumlahUnitBooth; }
    public double getTotalBayar() { return totalBayar; }

    public void cetakStruk() {
        System.out.println("Tipe Penyewa                  : " + this.tipePenyewa);
        System.out.println("Nama Penyewa                  : " + this.namaPenyewa);
        System.out.println("Jumlah Unit Booth             : " + this.jumlahUnitBooth);
    }
    @Override
    public String toString() {
        return "Penyewa: " + namaPenyewa + " [" + tipePenyewa + "]";
    }
}