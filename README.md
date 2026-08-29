# Mağaza Otomasyonu

Windows üzerinde çalışan, ürün ve satış takibini tek bir uygulama üzerinden yapmayı amaçlayan bir mağaza yönetim programı.

## Özellikler

- Kullanıcı girişi ve role göre ekran yetkilendirmesi
- Kategori, marka, renk ve beden yönetimi
- Ürün ve ürün varyasyonu ekleme, güncelleme ve silme
- Varyant bazlı stok takibi
- Müşteri kayıtları
- Sepet oluşturma ve satış tamamlama
- Satış geçmişi ve satış detayları
- Düşük stok, en çok satan ürün ve günlük satış raporları
- SQL Server transaction kullanımıyla satış sırasında stok kontrolü
- Açık renkli, ortak bir Windows Forms arayüz teması

## Kullanılan teknolojiler

- C#
- .NET 10
- Windows Forms
- SQL Server
- Microsoft.Data.SqlClient

Harici bir arayüz kütüphanesi kullanılmıyor.

## Kurulum

### Gereksinimler

- Windows
- .NET 10 SDK
- SQL Server
- SQL Server Management Studio (veritabanı scriptini çalıştırmak için)

### Veritabanını oluşturma

1. SQL Server Management Studio'yu açın.
2. Repo içindeki `MagazaOtomasyonu/Database/MagazaOptimizasyonu.sql` dosyasını açıp çalıştırın.
3. Script, `MagazaOptimizasyonu` veritabanını ve uygulamanın kullandığı tabloları oluşturur.
4. Gerekirse `MagazaOtomasyonu/DataAccess/DatabaseConnection.cs` içindeki bağlantı bilgisini kendi SQL Server ayarlarınıza göre güncelleyin.

Varsayılan bağlantı Windows Authentication ile yerel SQL Server içindir:

```text
Server=localhost;Database=MagazaOptimizasyonu;Trusted_Connection=True;TrustServerCertificate=True;
```

Scriptte roller ve ödeme türleri için temel kayıtlar bulunur. Login ekranını kullanabilmek için veritabanında aktif bir kullanıcı kaydı bulunmalıdır.

Ekranları örnek verilerle denemek için isteğe bağlı olarak `MagazaOtomasyonu/Database/DemoData.sql` dosyasını çalıştırabilirsiniz. Bu script mevcut kayıtları silmez; yalnızca eksik demo kayıtlarını ekler. Demo giriş bilgileri `demo.admin` veya `demo.cashier` kullanıcı adı ve `Demo123!` şifresidir. Bu hesaplar sadece test içindir.

### Uygulamayı çalıştırma

1. `MagazaOtomasyonu.slnx` dosyasını Visual Studio ile açın.
2. NuGet paketlerinin yüklenmesini bekleyin.
3. `MagazaOtomasyonu` projesini başlangıç projesi olarak seçin.
4. Uygulamayı çalıştırın.

Komut satırından derlemek için:

```bash
dotnet build
```

## Proje yapısı

```text
MagazaOtomasyonu/
├── Assets/          Uygulama ikonu
├── DataAccess/      Veritabanı bağlantısı
├── Database/        SQL Server kurulum ve demo veri scriptleri
├── Forms/           Windows Forms ekranları
├── Helpers/         Oturum ve arayüz yardımcıları
├── Models/          Model klasörü
├── MagazaOtomasyonu.csproj
└── Program.cs
```

## English

## Store Automation

A Windows desktop application for managing products, stock, customers and sales from one place.

## Features

- User login and role-based screen access
- Category, brand, color and size management
- Product and product variant management
- Variant-based stock tracking
- Customer records
- Cart and sales completion workflow
- Sales history and sale details
- Low-stock, best-selling product and daily sales reports
- Stock checks and SQL Server transaction handling during sales
- A shared light theme for the Windows Forms screens

## Technologies

- C#
- .NET 10
- Windows Forms
- SQL Server
- Microsoft.Data.SqlClient

No external UI library is used.

## Setup

### Requirements

- Windows
- .NET 10 SDK
- SQL Server
- SQL Server Management Studio for running the database script

### Database setup

1. Open SQL Server Management Studio.
2. Open and run `MagazaOtomasyonu/Database/MagazaOptimizasyonu.sql` from the repository.
3. The script creates the `MagazaOptimizasyonu` database and the tables used by the application.
4. If needed, update the connection string in `MagazaOtomasyonu/DataAccess/DatabaseConnection.cs` for your SQL Server instance.

The default connection uses Windows Authentication with a local SQL Server instance:

```text
Server=localhost;Database=MagazaOptimizasyonu;Trusted_Connection=True;TrustServerCertificate=True;
```

The script adds the basic roles and payment types. An active user record must exist in the database before the login screen can be used.

To try the screens with sample data, you can optionally run `MagazaOtomasyonu/Database/DemoData.sql`. It does not delete existing records; it only adds missing demo records. The demo login accounts are `demo.admin` and `demo.cashier`, both with the password `Demo123!`. These accounts are for testing only.

### Running the application

1. Open `MagazaOtomasyonu.slnx` with Visual Studio.
2. Wait for the NuGet packages to restore.
3. Set the `MagazaOtomasyonu` project as the startup project.
4. Run the application.

To build from the command line:

```bash
dotnet build
```

## Project structure

```text
MagazaOtomasyonu/
├── Assets/          Application icon
├── DataAccess/      Database connection
├── Database/        SQL Server setup and demo data scripts
├── Forms/           Windows Forms screens
├── Helpers/         Session and UI helpers
├── Models/          Model folder
├── MagazaOtomasyonu.csproj
└── Program.cs
```

## Notlar / Notes

SQL Server'ın `.bak`, `.mdf` ve `.ldf` dosyaları repoya dahil edilmez. Gerçek bağlantı bilgilerini veya parolaları kaynak koduna eklemeyin.

SQL Server `.bak`, `.mdf` and `.ldf` files are not included in the repository. Do not add real connection details or passwords to the source code.
