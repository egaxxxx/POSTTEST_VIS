# 🚀 NEXUS COMMUNITY — Kartu Anggota Digital
## Panduan Setup di Visual Studio 2022

---

## 📁 STRUKTUR FILE

```
KartuKomunitas/
│
├── Form1.vb          ← Form utama (input + navigasi)
├── FormKartu.vb      ← Form hasil / tampilan ID Card
├── Program.vb        ← Entry point aplikasi
└── README.md         ← Panduan ini
```

---

## ⚙️ CARA MEMBUAT PROJECT DI VISUAL STUDIO 2022

### Langkah 1 — Buat Project Baru
1. Buka **Visual Studio 2022**
2. Klik **"Create a new project"**
3. Cari **"Windows Forms App (.NET Framework)"** — pastikan pilih **Visual Basic**
4. Klik **Next**
5. Isi nama project: `KartuKomunitas`
6. Pilih **.NET Framework 4.8**
7. Klik **Create**

### Langkah 2 — Hapus File Default
1. Di **Solution Explorer**, hapus `Form1.vb` default yang dibuat VS
2. Hapus juga `Form1.Designer.vb` (jika ada)

### Langkah 3 — Tambahkan File Kode
1. Klik kanan pada **Project** → **Add** → **Existing Item...**
2. Pilih ketiga file: `Form1.vb`, `FormKartu.vb`, `Program.vb`
3. Klik **Add**

### Langkah 4 — Konfigurasi Startup
1. Klik kanan project → **Properties**
2. Di tab **Application**:
   - **Startup object**: pilih `KartuKomunitas.Program`
   - Atau bisa langsung pilih `Form1` jika Sub Main tidak digunakan
3. Pastikan **Output type**: Windows Application

### Langkah 5 — Jalankan
1. Tekan **F5** atau klik **▶ Start**
2. Jika ada error namespace, tambahkan di atas setiap file:
   ```vb
   Namespace KartuKomunitas
   ```

---

## 🎨 FITUR YANG TERSEDIA

### Form Utama (Form1)
| Fitur | Keterangan |
|-------|------------|
| MenuStrip | Input Data, Lihat Kartu, Simpan Data, Buka Data, Keluar |
| Tab 1 — Data Utama | Nama, ID, Tanggal Lahir, Umur (auto), Jenis Kelamin (RadioButton), Komunitas (ComboBox) |
| Tab 2 — Kontak & Info | MaskedTextBox Telepon, Email, Alamat, Kota, Provinsi |
| Tab 3 — Profil & Aktivitas | Foto (Browse), Peran (RadioButton), Hobi/Aktivitas (12 CheckBox) |

### Validasi Input
- ✅ Nama: hanya menerima huruf
- ✅ Telepon: MaskedTextBox format `0000-0000-00000`
- ✅ Umur: dihitung otomatis dari DateTimePicker
- ✅ Semua field kosong menampilkan pesan error
- ✅ Minimal 1 hobi harus dipilih

### Form Kartu Digital
- 🎨 Tampilan ID Card modern dengan warna neon dark
- 📷 Foto profil terintegrasi
- 🏷️ Badge komunitas, ID, dan peran
- 🏷️ Tag hobi/aktivitas
- 💾 Bisa simpan sebagai gambar PNG/JPG
- 🖨️ Preview cetak (PrintPreviewDialog)

### Fitur File
- 💾 SaveFileDialog → simpan ke `.txt` atau `.csv`
- 📂 OpenFileDialog → buka file data
- 📷 OpenFileDialog → upload foto profil

---

## 🛠️ TROUBLESHOOTING

**Error: "Type 'FormKartu' is not defined"**
→ Pastikan `FormKartu.vb` sudah ditambahkan ke project

**Error: "Namespace" conflict**
→ Bungkus semua class dengan `Namespace KartuKomunitas ... End Namespace`

**MaskedTextBox tidak muncul**
→ Pastikan `System.Windows.Forms` di-import: tambahkan `Imports System.Windows.Forms` di atas

**Gambar tidak bisa disimpan**
→ Pastikan `Imports System.Drawing.Imaging` ada di `FormKartu.vb`

---

## 📝 CATATAN PENGEMBANG

Program ini dibuat sepenuhnya secara **programatik** (tanpa Designer file),
sehingga tidak membutuhkan file `.Designer.vb` atau `.resx`.

Semua komponen UI dibuat di dalam kode `Form1_Load` dan method `BangunUI()`.

---

*NEXUS COMMUNITY — Digital Member Card System v2.0*
