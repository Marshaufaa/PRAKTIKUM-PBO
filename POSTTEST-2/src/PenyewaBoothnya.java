public class PenyewaBoothnya {
    private String namaPenyewa;
    private int jumlahUnitBooth;
    private double totalBayar;

    public PenyewaBoothnya(String namaPenyewa, int jumlahUnitBooth, double totalBayar){
        this.namaPenyewa = namaPenyewa;
        this.jumlahUnitBooth = jumlahUnitBooth;
        this.totalBayar = totalBayar;
    }
    public String getNamaPenyewa() {
        return namaPenyewa;
    }
    public int getJumlahUnitBooth() {
        return jumlahUnitBooth;
    }
    public double getTotalBayar() {
        return totalBayar;
    }

    public void setNamaPenyewa(String namaPenyewa) {
        this.namaPenyewa = namaPenyewa;
    }

    public void setJumlahUnitBooth(int jumlahUnitBooth) {
        this.jumlahUnitBooth = jumlahUnitBooth;
    }

    public void setTotalBayar(double totalBayar) {
        this.totalBayar = totalBayar;
    }

    public void cetakStruk(){
        System.out.println("Nama Penyewa                  : " + this.namaPenyewa);
        System.out.println("Jumlah Unit Booth yang Disewa : " + this.jumlahUnitBooth);
        System.out.println("Total Bayar                   : Rp " + this.totalBayar);
    }
}