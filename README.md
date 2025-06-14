![indir](https://github.com/user-attachments/assets/54cdaaf1-f4a3-4cad-b9b1-e882d6cc2f5e)

# 🌐 LanguageWork

## 📝 Tanıtım

**LanguageWork**, çoklu dil desteği ve dil dosyası yönetimi için geliştirilmiş, esnek yapıya sahip bir .NET projesidir. Uygulamalarda kullanılan metinlerin farklı dillerde yönetilmesini ve çevrilmesini kolaylaştırır. Özellikle çok dilli (multilingual) yazılım projelerinde, dil paketlerinin merkezi olarak kontrol edilmesini ve dinamik olarak güncellenmesini sağlar.

---

## 🚀 Özellikler

- 🌍 Çoklu dil desteği (tr, en, de, ve diğerleri)
- 🏷️ Anahtar-değer (key-value) tabanlı dil dosyası yönetimi
- 🔄 Dinamik dil değiştirme (runtime switch)
- 🗂️ JSON/XML/Excel tabanlı dil kaynak dosyaları ile çalışma
- 📦 Yeni dil ekleme ve mevcut dilleri güncelleme
- 📝 Merkezi dil yönetim paneli (varsa)
- 🚦 Eksik çevirileri tespit ve raporlama
- ⚙️ Otomatik fallback (bulunamayan anahtarlar için varsayılan dil)
- 🔒 Güvenli ve hızlı erişim için önbellekleme (optional)

---

## 🏗️ Teknik Altyapı

- **Backend:** .NET, C#
- **Veri Formatları:** JSON, XML, (isteğe bağlı Excel/CSV)
- **Yapı:**  
  - `Language/` : Dil dosyaları ve yönetim sınıfları
  - `Helpers/` : Yardımcı fonksiyonlar
  - `Models/` : Dil ve çeviri modelleri
  - `Config/` : Ayar ve konfigürasyon dosyaları
  - `UI/` : (Varsa) Yönetim veya örnek arayüzler

---

## 📂 Klasör Yapısı

```
LanguageWork/
├── Language/     # Dil yönetimi ve dosyaları
├── Models/       # Veri modelleri
├── Helpers/      # Yardımcı fonksiyonlar
├── Config/       # Ayar dosyaları (settings.json, config.xml vs)
├── UI/           # Yönetim/örnek arayüz
├── Program.cs    # Uygulama girişi
└── ...
```

---

## ⚙️ Kurulum & Kullanım

1. Projeyi klonlayın veya indirin.
2. `Config/` klasörüne dil dosyalarınızı (JSON, XML) yerleştirin.
3. Gerekirse `settings.json` veya `config.xml` dosyasından varsayılan dili ve yolları düzenleyin.
4. Projeyi Visual Studio ile açıp çalıştırın.
5. Koddan veya arayüzden (varsa) dili değiştirip çevirileri test edin.

---

## 🤝 Katkı

Katkı sağlamak için projeyi forklayabilir ve pull request gönderebilirsiniz.

---

## 📄 Lisans

Bu proje MIT lisansı ile sunulmuştur.
