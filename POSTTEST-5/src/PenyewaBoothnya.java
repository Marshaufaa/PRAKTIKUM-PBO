public abstract class PenyewaBoothnya {
    protected String namaPenyewa;
    protected int jumlahUnitBooth;
    protected double totalBayar;
    protected String tipePenyewa;

    public PenyewaBoothnya(String namaPenyewa, int jumlahUnitBooth, String tipePenyewa) {
        this.namaPenyewa = namaPenyewa;
        this.jumlahUnitBooth = jumlahUnitBooth;
        this.tipePenyewa = tipePenyewa;
    }
    public abstract void cetakStruk();
    public String getNamaPenyewa() {
        return namaPenyewa;
    }

    @Override
    public String toString() {
        return "Penyewa: " + namaPenyewa + " [" + tipePenyewa + "]";
    }
}