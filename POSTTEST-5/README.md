``` java
public abstract void cetakStruk(); 
```
DARI FILE PENYEWABOOTHNYA.JAVA 

ini buat mastiin pas kita panggil .cetakStruk() di file SistemSewa tuh javanya ototmatis jalanin versi sesuai yang dipilih, entah reguler atau umkm walaupun tipe data referensinya parent class

```java
public interface Diskonable {
    double hitungDiskon(double hargaTotal);
    void tampilkanPromo();
}
```
DARI FILE DISKONABLE.JAVA 

bahwa setiap kategori penyewa yang mendapatkan potongan harga (seperti UMKM) wajib memiliki cara untuk menghitung nilai diskonnya dan cara menampilkan pesan promonya secara seragam. Dengan adanya file ini, logika diskon tidak tercampur dengan data penyewa biasa, sehingga kode menjadi lebih rapi, terorganisir, dan sangat mudah untuk ditambah fitur diskon baru di masa depan tanpa merusak struktur program yang sudah ada.
