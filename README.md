![indir](https://github.com/user-attachments/assets/54cdaaf1-f4a3-4cad-b9b1-e882d6cc2f5e)

# 🌐 LanguageWork

## 📝 Tanıtım

**LanguageWork**, çoklu dil (İngilizce ve İspanyolca) desteği ve dil dosyası yönetimi için geliştirilmiş, esnek yapılı bir .NET projesidir. Uygulamalarda kullanılan metinlerin farklı dillerde yönetilmesini ve çevrilmesini kolaylaştırır. Özellikle çok dilli yazılım projelerinde dil paketlerinin merkezi olarak kontrol edilmesini ve dinamik olarak güncellenmesini sağlar.

---

## 🚀 Özellikler

- 🌍 Çoklu dil desteği (İngilizce ve İspanyolca)
- 🏷️ Anahtar-değer (key-value) tabanlı XML dil dosyası yönetimi
- 🔄 Dinamik dil değiştirme (çalışma zamanında)
- 📦 Yeni dil ekleme ve mevcut dilleri güncelleme (manuel olarak)
- ⚙️ Otomatik fallback (bulunamayan anahtarlar için varsayılan dil)
- 🖥️ Modern Windows Forms arayüzü (DevExpress temalı)

---

## 🏗️ Teknik Altyapı

- **Platform:** .NET Framework 4.8
- **Arayüz:** Windows Forms (DevExpress skin/theme desteği)
- **Veritabanı:** Entity Framework 6, SQLite desteği (App.config içeriğine göre)
- **Dil Dosyaları:** XML tabanlı, anahtar-değer sistemi
- **Katmanlar ve Yapı:**
  - `Classes/` : Dil yönetimi ve yardımcı sınıflar
  - `Forms/` : Uygulama ana arayüzü ve formlar
  - `Properties/` : Assembly ve uygulama ayarları
  - `App.config` : Uygulama ve veritabanı bağlantı ayarları
  - `icons8_brick.ico` : Uygulama ikonu
- **Paketler:** NuGet ile yönetilen bağımlılıklar (`packages.config` ve `packages/`)
- **Tema:** DevExpress UI/Theme ve skin desteği (App.config’te tanımlı)

---

## 📂 Gerçek Proje Yapısı

Aşağıda projenin güncel dosya ve klasör yapısı özetlenmiştir. Daha fazlasını incelemek için [buraya tıklayın](https://github.com/dogukankosan/LanguageWork/tree/main).

```
LanguageWork/
│
├── .gitattributes
├── App.config
├── LanguageWork.csproj
├── LanguageWork.csproj.user
├── LanguageWork.sln
├── Program.cs
├── README.md
├── icons8_brick.ico
├── packages.config
│
├── .vs/              # Visual Studio dizini
├── bin/              # Derlenmiş çıktı dosyaları
├── obj/              # Geçici derleme dosyaları
├── packages/         # NuGet paketleri
├── Properties/       # Assembly ve ayar dosyaları
├── Classes/          # Dil yönetimi ve yardımcı sınıflar
├── Forms/            # Windows Forms arayüzleri
```
> Not: Listede yalnızca ilk 10+ dosya veya klasör gösterilmektedir. [Detayı görüntüle](https://github.com/dogukankosan/LanguageWork/tree/main)

---

## ⚙️ Kurulum & Kullanım

1. Projeyi klonlayın veya indirin.
2. `App.config` veya ilgili ayar dosyalarını düzenleyin (gerekirse dil dosyalarını ve veritabanı bağlantılarını tanımlayın).
3. NuGet paketlerini yükleyin (gerekli bağımlılıklar için).
4. Visual Studio ile projeyi açıp çalıştırın.
5. Uygulama üzerinden veya kod ile İngilizce ve İspanyolca dil dosyalarını yönetin; çevirileri test edin.

---

## 🤝 Katkı

Katkı sağlamak için projeyi forklayabilir ve pull request gönderebilirsiniz.

---

## 📄 Lisans

MIT License

---

## 📬 İletişim

- 👨‍💻 Geliştirici: [@dogukankosan](https://github.com/dogukankosan)  
- 🐞 Suggestions or issues: [Issues sekmesi](https://github.com/dogukankosan/LogoWhatsappEntegrasyon/issues)

---
