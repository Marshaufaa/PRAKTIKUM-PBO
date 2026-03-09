1. Dari file PenyewaBoothnya.java
```java
String namaPenyewa;
int jumlahUnitBooth;
double totalBayar;
```
ini untuk nyimpan nama, unit booth, dan jumlah bayar dengan memakai tipe datanya masing masing yaitu str buat teks, int buat angka, dan double buat nyimpan angka tp dlm jumlah besar karena supaya variabelnya lebih lega untuk menampung angka harga sewa unit yang mencapai jutaan.

```java
public PenyewaBoothnya(String namaPenyewa, int jumlahUnitBooth, double totalBayar){
        this.namaPenyewa = namaPenyewa;
        this.jumlahUnitBooth = jumlahUnitBooth;
        this.totalBayar = totalBayar;
    }
```
ini saya pake Parameterized Constructor

```java
 public void cetakStruk(){
        System.out.println("nama penyewa = " + namaPenyewa);
        System.out.println("jumlah unit booth yang disewa = " + jumlahUnitBooth);
        System.out.println("total bayar = " + totalBayar);
    }
}
```
ini bagian yg dipanggil dalam perulangan for pada SistemSewa di bagian READ

2. Dari file SistemSewa.java
```java
public class SistemSewa {
    public static void main(String[] args){
        ArrayList<PenyewaBoothnya> dataRamadhan = new ArrayList<>();
        Scanner input = new Scanner(System.in);
        int menu;
```
-ArrayList<PenyewaBoothnya> itu fungsinya sebagai database sementara untuk menampung banyak objek penyewanya. 
-Scanner input(tambahan) ini objek yang bikin program baca apa yang  diketik di keyboard.
-int menu untuk penampung angka menu yang dipilih user.

```java
if (jumlahUnitBooth > 4) {
        System.out.println("MAAF, PEMESANAN GAGAL! maksimal sewa 4 unit perorang.");
    } else if (jumlahUnitBooth <= 0) {
        System.out.println("Jumlah unit tidak valid!");
    } else {
        double totalBayar = jumlahUnitBooth * 3825000;
        dataRamadhan.add(new PenyewaBoothnya(namaPenyewa, jumlahUnitBooth, totalBayar));
        System.out.println("data berhasil ditambahin");
}
break;
```
ini bagian CREATE, per user maksimal sewanya dibatasi cuma 4 unit.
kalo bagian 'dataRamadhan.add' itu perintah untuk membuat objek baru dan memasukkannya ke daftar penyewa kalau validasi datanya berhasil.

```java
 for (int i = 0; i < dataRamadhan.size(); i++){
    System.out.println("ID [" + i + "] ");
    dataRamadhan.get(i).cetakStruk();
}
```
ini bagian READ, dataRamadhan buat menghitung seberapa banyak penyewa yg ada, get(i) untuk ambik data satu persatu sesuai indexnya, dan cetakStruk() untuk manggil fungsi dari file PenyewaBoothnya.java (gunanya buat nampilin rincian data seperti nama penyewa, jumlah unit booth yang disewa dan total bayar.

```java
dataRamadhan.set(idEdit, new PenyewaBoothnya(nBaru, jBaru, tBaru));
    System.out.println("data berhasil diubah");
    }
} else {
    System.out.println("ID nya tidak ketemu");
```
ini bagian UPDATE, didalam dataRamadhan.set isinya ada index dan objek baru nya (nBaru,jBaru,tBaru atau data baru yg sudah di edit dan di update). kalau berhasil maka outputnya adalah "data berhasil diubah" tapi kalau tidak berhasil maka outputnya adalah "ID nya tidak ketemu".

``` java
dataRamadhan.remove(idHapus);
    System.out.println("data berhasil dihapus");
    } else {
    System.out.println("id nya tidak ketemu");
}
```
ini bagian DELETE, dataRamadhan.remove(index) fungsinya untuk menghapus data secara permanen dari daftar sehingga ukuran ArrayListnya akan berkurang.

```java
System.out.println("keluar program.......");
    break;
```
ini fungsinya untuk exit program.

```java
} while (menu != 5);

input.close();
```
bagian while(menu!=5) selama user tidak memilih menu no.5, maka programnya akan terus berputar kembali nampilin ke menu utama.

bagian input.close() fungsinya program ngasih sinyal ke sistem kalau program selesai dengan sukses tanpa error.

