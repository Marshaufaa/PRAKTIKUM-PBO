1. DARI PenyewaBoothnya.java
```java
public class PenyewaBoothnya {
    protected String namaPenyewa;
    protected int jumlahUnitBooth;
    protected double totalBayar;
    protected String tipePenyewa;
```
pake atribut access modifier protected biar bisa di akses sama subclass

``` java
1. public void setTotalBayar(double totalBayar) {
        this.totalBayar = totalBayar;
    }
2. public void setTotalBayar(int jumlah, double harga) {
        this.totalBayar = (double) jumlah * harga;
    }
```
pake method overloading buat setTotalBayar

-penyewa UMKM pake perhitungan manual setelah dikurangi diskon

-sedangkan penyewa reguler pake perhitungann otomatis.

```java
    public String getNamaPenyewa() { return namaPenyewa; }
    public int getJumlahUnitBooth() { return jumlahUnitBooth; }
    public double getTotalBayar() { return totalBayar; }
```
pake method getter setter

```java
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
```
pake method overriding

-3 sout nya itu buat cetak data penyewa

-method ini bakal di override di subclass untuk detail bayar yang berbeda

-kalo override itu buat ngasih representasi string yang informatif saat objek dicetak atau dipanggil di list

2. DARI PenyewaReguler.java 
```java
 public PenyewaReguler(String namaPenyewa, int jumlahUnitBooth, double hargaPerUnit) {
```
pake method overriding

gunanya buat ngirim data ke constructor superclass

-perbedaannya kalo penyewa reguler dia bayar normal contoh nya yang emang udah punya nama besar gitu (aqua, le minerale, milo, dll.) sedangkan kalo penyewa umkm ada diskonnya 15%

3. DARI PenyewaUMKM.java
```java
public class PenyewaUMKM extends PenyewaBoothnya {
    private final double diskon = 0.15;

    public PenyewaUMKM(String namaPenyewa, int jumlahUnitBooth, double hargaPerUnit) {
        super(namaPenyewa, jumlahUnitBooth, "UMKM (Diskon 15%)"); 
```
pake access modifier private biar gabisa diubah dari luar class

```java
        this.setTotalBayar(hargaSetelahDiskon);
}
```
buat manggil method overload dari parent

```java
@Override
    public void cetakStruk() {
        super.cetakStruk();
        System.out.println("Total Bayar (Setelah Diskon)  : Rp " + this.totalBayar);
    }
```
buat nge override cetakStruk biar ngitung jumlah dan ada diskon tanda khusus UMKM.

```java
@Override
    public String toString() {
        return super.toString() + " - Dukung Produk Lokal!";
    }
```
biar ada identitas khusus umkm

4. DARI SistemSewa.java
```java
public static void main(String[] args) {
        ArrayList<PenyewaBoothnya> dataRamadhan = new ArrayList<>();
        Scanner input = new Scanner(System.in);
        int menu;
        final double HARGA_PER_UNIT = 3825000;
```
-<ArrayList<PenyewaBoothnya> dataRamadhan buat nyimpan semua transaksi penyewaan selama program running

-final double itu buat standar acuan perhitungan total bayar buat semua jenis penyewa, kek contohnya yang reguler atau umkm yang dapat diskon

```java
for (int i = 0; i < dataRamadhan.size(); i++) {
        System.out.println("ID [" + i + "] " + dataRamadhan.get(i).toString());
        dataRamadhan.get(i).cetakStruk();
        System.out.println("------------------------");
    }
}
```
buat nampilin hasil Override toString()
