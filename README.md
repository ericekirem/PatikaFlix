# Patikaflix Diziler Platformu

Bu proje, bir konsol uygulaması olarak geliştirilmiştir ve kullanıcıdan alınan verilerle bir dizi platformu simülasyonu oluşturmayı amaçlamaktadır. Kullanıcılar, dizilere dair bilgileri girerek bir liste oluşturabilir ve ardından komedi türündeki diziler için özel bir liste hazırlayabilirler.

---

## Özellikler

- Kullanıcıdan dizi bilgilerini alarak bir `Dizi` listesi oluşturur.
- Komedi türündeki dizilerden yalnızca `Dizi Adı`, `Dizi Türü` ve `Yönetmen` bilgilerini içeren yeni bir liste oluşturur.
- Oluşturulan liste sıralanarak ekrana yazdırılır:
  - Öncelikle dizi adına göre.
  - Ardından yönetmen adına göre.
- Kullanıcıya sürekli yeni bir dizi ekleme imkanı tanır.
- Basit ve anlaşılır bir kullanıcı arayüzü sunar.

---

## Kullanılan Teknolojiler

- **C#**
- **.NET Core Console Application**

---

## Proje Akışı

1. **Dizi Bilgilerinin Alınması:**
   - Kullanıcıdan dizi adı, türü, yönetmeni, yayın yılı ve bölüm sayısı bilgileri alınır.
   - Bilgiler bir `Dizi` nesnesi olarak ana listeye eklenir.
   - Kullanıcıya yeni bir dizi eklemek isteyip istemediği sorulur.
