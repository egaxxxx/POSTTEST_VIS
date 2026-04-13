CREATE DATABASE IF NOT EXISTS db_depot_barokah;
USE db_depot_barokah;

CREATE TABLE IF NOT EXISTS tbl_produk (
    id_produk     INT AUTO_INCREMENT PRIMARY KEY,
    nama_produk   VARCHAR(100) NOT NULL,
    kategori      VARCHAR(50)  NOT NULL,
    harga         DECIMAL(10,0) NOT NULL,
    stok          INT NOT NULL DEFAULT 0,
    keterangan    TEXT
);

CREATE TABLE IF NOT EXISTS tbl_isiulang (
    id_pesan       INT AUTO_INCREMENT PRIMARY KEY,
    nama_pelanggan VARCHAR(100) NOT NULL,
    no_hp          VARCHAR(20),
    id_produk      INT NOT NULL,
    jumlah         INT NOT NULL,
    total_harga    DECIMAL(10,0) NOT NULL,
    tanggal        DATE NOT NULL,
    status         VARCHAR(20) NOT NULL DEFAULT 'Proses',
    FOREIGN KEY (id_produk) REFERENCES tbl_produk(id_produk)
);

INSERT INTO tbl_produk (nama_produk, kategori, harga, stok, keterangan) VALUES
('Galon Isi Ulang 19L', 'Galon', 5000, 200, 'Air mineral murni'),
('Galon Isi Ulang 10L', 'Galon', 3000, 150, 'Ukuran medium'),
('Botol 1.5L',          'Botol', 4000, 500, 'Kemasan botol bersegel'),
('Botol 600ml',         'Botol', 2500, 300, 'Ukuran mini praktis');
