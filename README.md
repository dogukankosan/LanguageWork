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

## 🏗️ Gerçek Proje Yapısı

Aşağıda, projenin gerçek dosya ve klasör yapısının bir özeti verilmiştir. Daha fazlasını incelemek için [buraya tıklayın](https://github.com/dogukankosan/LanguageWork/tree/main).

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
├── Classes/          # (Muhtemelen) Dil yönetimi ve yardımcı sınıflar
├── Forms/            # (Muhtemelen) Windows Forms arayüzleri
```
> Not: Listede yalnızca ilk 10+ dosya veya klasör gösterilmektedir. [Detayı görüntüle](https://github.com/dogukankosan/LanguageWork/tree/main)

---

## ⚙️ Kurulum & Kullanım

1. Projeyi klonlayın veya indirin.
2. `App.config` veya ilgili ayar dosyalarını düzenleyin.
3. Visual Studio ile projeyi açıp çalıştırın.
4. Uygulama üzerinden veya kod ile dil dosyalarını yönetin, yeni diller ekleyin ve çevirileri test edin.

---

## 🤝 Katkı

Katkı sağlamak için projeyi forklayabilir ve pull request gönderebilirsiniz.

---

## 📄 Lisans

Bu proje MIT lisansı ile sunulmuştur.
