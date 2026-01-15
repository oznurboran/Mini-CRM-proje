Güzellik Salonu CRM Yönetim Sistemi (WinForms)

Bu proje, bir güzellik salonu / beauty center için geliştirilmiş;
müşteri yönetimi, personel yönetimi, hizmet tanımlama, talep & işlem takibi ve raporlama süreçlerini dijital ortamda yönetmeyi amaçlayan bir Windows Forms masaüstü uygulamasıdır.

Proje, katmanlı mimari (N-Tier Architecture) kullanılarak geliştirilmiş olup; sürdürülebilir, genişletilebilir ve temiz bir kod yapısı sunmaktadır.

📌 Proje Özellikleri
🔐 Kullanıcı Girişi ve Yetkilendirme

Rol bazlı giriş sistemi

Admin

Çağrı Personeli (Call Center)

Destek Personeli (Support)

Kullanıcı rolüne göre yetkilendirilmiş ekranlar

Kullanıcı adı & şifre doğrulaması

👥 Müşteri Yönetimi

Müşteri ekleme, güncelleme ve silme

Ad-soyad, telefon ve e-posta bilgileri takibi

Müşterilere ait taleplerin görüntülenmesi

DataGridView üzerinden listeleme ve düzenleme

🧑‍💼 Personel Yönetimi

Personel ekleme, güncelleme ve silme

Uzmanlık alanı tanımlama

Cilt bakım uzmanı

Makyaj uzmanı

El & ayak bakım uzmanı vb.

Taleplere personel atama

🛎️ Hizmet Yönetimi

Güzellik salonuna ait hizmetlerin tanımlanması

Manikür

Pedikür

Cilt bakımı

Kirpik lifting

Kalıcı oje vb.

Hizmet açıklaması ve ücret bilgileri

Hizmet–talep ilişkilerinin yönetimi

📄 Talep & İşlem Yönetimi

Müşteri, personel ve hizmet seçimi

Talep durumu takibi

Beklemede

Tamamlandı

Oluşturulma ve tamamlanma tarihleri

Memnuniyet puanı girişi (tamamlanan talepler için)

📊 Raporlama ve Dashboard

Hizmet türüne göre yoğunluk raporu

Personel performans raporu

Müşteri bazlı talep raporu

Müşteri memnuniyet raporu

Grafik (Chart) ve tablo (DataGridView) destekli raporlama ekranları

📐 Mimari Yapı

Proje katmanlı mimari kullanılarak geliştirilmiştir:

UI (User Interface)
Windows Forms arayüzleri

BLL (Business Logic Layer/ Service)
İş kuralları ve kontroller

DAL (Data Access Layer)
MySQL veritabanı işlemleri

Domain / Entities
Veri modelleri (Musteri, Hizmet, Personel, Talep vb.)

📂 Proje Yapısı
CRMProjeyeni
│
├── UI              → Windows Forms arayüzleri
├── Service          → İş mantığı
├── DAL             → Veritabanı işlemleri
├── Domain          → Veri modelleri
│
├── App.config      → MySQL bağlantı ayarları
├── Program.cs      → Uygulama başlangıç noktası
└── CRMProjeyeni.sln

🛠️ Kullanılan Teknolojiler

Programlama Dili: C# (.NET Framework)

Arayüz: Windows Forms

Veritabanı: MySQL (phpMyAdmin)

Mimari: Katmanlı Mimari (N-Tier)

Veri İşleme: LINQ

Versiyon Kontrol: Git & GitHub

🚀 Kurulum ve Çalıştırma
1️⃣ Projeyi Klonlayın
git clone https://github.com/oznurboran/Mini-CRM-proje

2️⃣ Visual Studio ile Açın

CRMProjeyeni.sln dosyasını açın.

3️⃣ Veritabanı Ayarları

App.config dosyasındaki MySQL bağlantı bilgilerini düzenleyin.

4️⃣ Gerekli Veritabanı Tabloları

MySQL üzerinde aşağıdaki tabloların oluşturulması gerekmektedir:

kullanicilar

musteriler

personeller

hizmetler

talepler

5️⃣ Çalıştırma

Visual Studio üzerinden F5 ile projeyi başlatın.

🎯 Projenin Amaçları

✅ Güzellik salonu süreçlerini dijitalleştirmek
✅ Müşteri ve hizmet takibini kolaylaştırmak
✅ İşletme içi iş akışını düzenlemek
✅ Manuel hataları azaltmak
✅ Katmanlı mimariyi uygulamalı olarak öğrenmek

📌 Geliştirilebilecek Özellikler

📄 PDF / Excel rapor çıktıları

🔐 Şifrelerin hashlenerek saklanması (SHA-256)

📊 Gelişmiş grafik tabanlı dashboard

🌐 Web veya mobil versiyon

🔔 Otomatik bildirim sistemi

👤 Geliştirici

Ad Soyad: Öznur Boran
Üniversite: Uludağ Üniversitesi
Bölüm: Yönetim Bilişim Sistemleri

🎥 Tanıtım Videosu

👉 https://youtu.be/mpp54pcjbmI
