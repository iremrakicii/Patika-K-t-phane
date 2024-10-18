# Kütüphane Programı

Bu proje, basit bir kütüphane sistemi oluşturarak kitap kayıtları yapmayı ve görüntülemeyi amaçlayan bir C# konsol uygulamasıdır.

## Açıklama

Programda `Kutuphane` adında bir sınıf tanımlanmıştır. Bu sınıf, bir kitabın adını, yazarını, sayfa sayısını ve yayınevini temsil eden özelliklere sahiptir. Program, `Kutuphane` sınıfından türetilen nesneler aracılığıyla kitapların bilgilerini kaydedip ekrana yazdırmaktadır.

### Kullanılan Özellikler

- **BookName**: Kitabın adını tutar.
- **PageNumber**: Kitabın sayfa sayısını tutar.
- **WriterName**: Yazarın adını tutar.
- **PublishingHouse**: Kitabın yayınevini tutar.

### Constructor'lar

1. **Parametreli Constructor**: Kitabın bilgilerini oluşturmak için parametrelerle çağrılan yapıcı metot.
    ```csharp
    Kutuphane yazar1 = new Kutuphane("Yaş On Yedi", "400", "İpek Ongun", "Remzi Kitapevi");
    ```
    
2. **Parametresiz Constructor**: Kitap bilgilerini sonradan ayarlamak için kullanılabilir.
    ```csharp
    Kutuphane yazar2 = new Kutuphane();
    yazar2.WriterName = "Ayşe Kulin";
    yazar2.PageNumber = "398";
    yazar2.PublishingHouse = "Nezih Kitapevi";
    yazar2.BookName = "Adı: Aylin";
    ```

## Kullanım

Aşağıdaki adımlar programın nasıl çalıştığını açıklar:

1. **Kitap Bilgilerini Girme**: Kitap bilgileri ya sınıfın yapıcı metotlarıyla girilebilir ya da sonradan ayarlanabilir.
2. **Kitap Kaydını Yazdırma**: Her kitap için bilgilerin ekrana yazdırılması sağlanır.

## Kullandığım Araçlar ve Teknolojiler
Programlama Dili: C# IDE: Visual Studio
