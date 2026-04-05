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

    public String getNamaPenyewa() { return namaPenyewa; }
    public void setNamaPenyewa(String namaPenyewa) { this.namaPenyewa = namaPenyewa; }
    public int getJumlahUnitBooth() { return jumlahUnitBooth; }
    public void setJumlahUnitBooth(int jumlahUnitBooth) { this.jumlahUnitBooth = jumlahUnitBooth; }
    public double getTotalBayar() { return totalBayar; }
    public void setTotalBayar(double totalBayar) { this.totalBayar = totalBayar; }

    public void cetakStruk() {
        System.out.println("Tipe Penyewa                  : " + this.tipePenyewa);
        System.out.println("Nama Penyewa                  : " + this.namaPenyewa);
        System.out.println("Jumlah Unit Booth             : " + this.jumlahUnitBooth);
    }
}
