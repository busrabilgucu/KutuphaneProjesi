Kütüphane Yönetim Sistemi - Konsol Uygulaması
Proje Hakkında
Bu proje, basit bir kütüphane yönetim sistemi konsol uygulamasıdır.
Üyelerin kitap ödünç alma ve iade işlemlerini yönetmek, kitapların durumlarını takip etmek ve farklı türlerde kitaplar için temel işlemler gerçekleştirmek amaçlanmıştır.

# Özellikler
- Üyelerin kütüphaneye kayıt olması

- Kitap ekleme, listeleme

- Üyelerin kitap ödünç alma ve iade işlemleri

- Kitapların durum takibi (Ödünç alınabilir, Ödünç verilmiş, Mevcut değil)

- Farklı kitap türlerinin yönetimi: Bilim, Roman, Tarih, Polisiye, Psikoloji

- Üyelerin ödünç alma limiti kontrolü (varsayılan 5 kitap)

# Proje Yapısı ve Sınıflar
1. Durum (enum)
Kitapların mevcut durumlarını tanımlar:

OduncAlinabilir

OduncVerilmis

MevcutDegil

2. Kitap (Soyut Sınıf/Base Class)
Kitaplara ait ortak özellikler ve metotlar:

ISBN, Başlık, Yazar, Yayın Yılı, KitapDurumu vb.

Kitap bilgilerini gösterme metodu.

3. Kitap Türleri (Alt Sınıflar)
Her biri kendi türüne özgü alanlara sahip:

KitapBilim (Alan, Dil, Konu, SayfaSayisi)

KitapRoman (Konu, Dil, UzunMu)

KitapTarih (TarihDonemi, Dil, Olay, Kisiler)

KitapPolisiye (SucTipi, Dedektif, Dil)

KitapPsikoloji (PsikolojiAltAlan, TedaviYontemi, Dil)

4. IUye (Arayüz)
Üye bilgileri ve işlemleri:

Ad, Soyad, ÜyeNumarası

Ödünç alınan kitap listesi

Ödünç alma ve iade metotları

Ödünç alma limiti

5. Uye (Sınıf)
IUye arayüzünü uygular.

Üyelerin ödünç alma ve iade işlemlerini yönetir.

Üye ödünç alma limiti varsayılan 5 kitap.

Üye kütüphane listesinde yoksa işlem başarısız olur.

6. GenelIslemler<T> (Generic Sınıf)
Kitaplar için generic liste yönetimi sağlar.

Kitap ekleme, silme, listeleme ve erişim fonksiyonları içerir.

# Kullanım Notları
Üyeler ödünç alma işlemi yapmadan önce kütüphane üyesi olmalıdır.

Ödünç alınabilecek kitap sayısı üye başına 5 ile sınırlandırılmıştır.

Ödünç alma sırasında kitap durumu otomatik güncellenir.

İade sonrası kitap durumu tekrar ödünç alınabilir olur.

Kitaplar farklı türlerde yönetilerek türlere özgü özellikler desteklenir.


