# Kütüphane Yönetim Sistemi (Library Management System)

## Proje Tanımı
ASP.NET Core MVC kullanılarak geliştirilmiş bu uygulama, bir kütüphanenin kitap ve yazar yönetimini sağlayan kapsamlı bir sistemdir.  
Kullanıcılar kitap ve yazar bilgilerini görüntüleyebilir, yeni kayıtlar ekleyebilir, mevcut kayıtları düzenleyebilir ve silebilirler.  
Proje, Nesne Yönelimli Programlama (OOP) prensiplerine uygun olarak tasarlanmıştır.

---

## İçerikler

- **Kitap (Book) Modeli**  
  - Id (int): Kitabın benzersiz kimliği  
  - Title (string): Kitap başlığı  
  - AuthorId (int): Kitaba ait yazarın Id'si  
  - Genre (string): Kitap türü  
  - PublishDate (DateTime): Yayın tarihi  
  - ISBN (string): ISBN numarası  
  - CopiesAvailable (int): Mevcut kopya sayısı  

- **Yazar (Author) Modeli**  
  - Id (int): Yazarın benzersiz kimliği  
  - FirstName (string): Yazarın adı  
  - LastName (string): Yazarın soyadı  
  - DateOfBirth (DateTime): Yazarın doğum tarihi  

- **ViewModel'ler**  
  Kitap ve yazar detaylarının görüntülenmesi için özel ViewModel sınıfları oluşturuldu. Bu sayede gerekli tüm bilgiler ilgili sayfalarda kolayca gösterilebilmektedir.

---

## Özellikler

- **Kitap İşlemleri (BookController)**  
  - Kitap listesi görüntüleme  
  - Kitap detaylarını görüntüleme  
  - Yeni kitap ekleme  
  - Mevcut kitabı düzenleme  
  - Kitap silme  

- **Yazar İşlemleri (AuthorController)**  
  - Yazar listesi görüntüleme  
  - Yazar detaylarını görüntüleme  
  - Yeni yazar ekleme  
  - Mevcut yazarı düzenleme  
  - Yazar silme  

- **Kullanıcı Arayüzü**  
  - Kitap ve yazar listeleri, detay sayfaları, oluşturma ve düzenleme formları için ayrı View sayfaları  
  - Dropdown menülerde dinamik olarak yazar seçimi  
  - Silme işlemleri için onay sayfaları  
  - Layout ve Partial View kullanımı ile tutarlı ve kolay yönetilebilir UI  
  - Sayfa altında sabit footer: Tüm hakları saklıdır yazısı  

- **Routing & Konfigürasyon**  
  - Program.cs dosyasında MVC servisleri ve routing ayarları yapılandırıldı.  
  - wwwroot klasöründe statik dosya kullanımı aktif.  

---

## Kullanım

1. Projeyi klonlayın veya dosyaları indirin.  
2. Visual Studio veya Visual Studio Code ile açın.  
3. Projeyi build edin ve çalıştırın.  
4. Ana sayfada kitap ve yazar listelerine erişebilirsiniz.  
5. Yeni yazar ekledikten sonra kitap ekleme sayfasındaki yazar dropdown menüsünde yeni yazar görünür.  
6. Kitap ve yazarlar üzerinde CRUD işlemlerini gerçekleştirebilirsiniz.  

---

## Proje Yapısı

- **Controllers**  
  `BookController.cs` ve `AuthorController.cs` kitap ve yazar işlemlerini yönetir.  
- **Models**  
  `Book.cs` ve `Author.cs` sınıfları temel veri modellerini içerir.  
- **ViewModels**  
  Kitap ve yazar detayları için özel ViewModel sınıfları bulunur.  
- **Views**  
  Her controller için ayrı view klasörleri (Book, Author) altında List, Create, Edit, Details ve Delete sayfaları yer alır.  
- **Data**  
  `DataRepository.cs` içinde geçici veri kaynağı ve veri yönetimi yapılır.  

---

## Teknolojiler ve Araçlar

- ASP.NET Core MVC  
- C#  
- Razor View Engine  
- Bootstrap (CSS Framework)  
- Visual Studio / Visual Studio Code  

---

## Notlar

- Projede gerçek veritabanı kullanılmamış, geçici liste bazlı veri yönetimi sağlanmıştır.  
- Kodlar OOP prensiplerine uygun, anlaşılır ve modüler yapıda yazılmıştır.  
- Proje genişletilmeye ve gerçek veritabanı entegrasyonuna uygundur.  

