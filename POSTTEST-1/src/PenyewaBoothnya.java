public class PenyewaBoothnya {
    String namaPenyewa;
    int jumlahUnitBooth;
    double totalBayar;

    public PenyewaBoothnya(String namaPenyewa, int jumlahUnitBooth, double totalBayar){
        this.namaPenyewa = namaPenyewa;
        this.jumlahUnitBooth = jumlahUnitBooth;
        this.totalBayar = totalBayar;
    }

    public void cetakStruk(){
        System.out.println("nama penyewa = " + namaPenyewa);
        System.out.println("jumlah unit booth yang disewa = " + jumlahUnitBooth);
        System.out.println("total bayar = " + totalBayar);
    }
}