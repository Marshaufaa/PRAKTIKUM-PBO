1. BAGIAN PenyewaBoothnya.java
```java
private String namaPenyewa;
private int jumlahUnitBooth;
private double totalBayar;
```
fungsi private access modifier untuk menyembunyikan data.

```java
public String getNamaPenyewa() {
    return namaPenyewa;
}
```
metode Getter untuk mengambil data secara aman

```java
public void setNamaPenyewa(String namaPenyewa) {
    this.namaPenyewa = namaPenyewa;
}
```
metode setter untuk mengubah data dengan kontrol.

2. BAGIAN SistemSewa.java
```java 
ArrayList<PenyewaBoothnya> dataRamadhan = new ArrayList<>();
```
untuk simpan koleksi objek PenyewaBooth.

```java
if (jumlah > 4) {
        System.out.println("MAAF, PEMESANAN GAGAL! Maksimal sewa 4 unit.");
    } else if (jumlah <= 0) {
        System.out.println("Jumlah unit tidak valid!");
    } else {
`       double total = jumlah * HARGA_PER_UNIT;
        dataRamadhan.add(new PenyewaBoothnya(nama, jumlah, total));
        System.out.println("Data berhasil ditambahkan!");
}
```
ini kode nunjukin kalo satu user di batasi sewa maksimal 4 unit booth.

```java
PenyewaBoothnya penyewa = dataRamadhan.get(idEdit);
```
ngambil id berdasarkan id user.

```java
penyewa.setNamaPenyewa(nBaru);
penyewa.setJumlahUnitBooth(jBaru);
penyewa.setTotalBayar(jBaru * 3825000);
```
perbarui data menggunakan setter (encapsulation).
