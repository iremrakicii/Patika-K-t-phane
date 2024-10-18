using Patika_Kütüphane;

class Program
{
    static void Main(string[] args)
    {
        // 'Kutuphane' adında bir class (sınıf) tanımlıyoruz. Class, bir nesnenin özelliklerini ve davranışlarını (property ve method) tanımlamak için kullanılır.

        Kutuphane yazar1 = new Kutuphane("Yaş On Yedi", "400", "İpek Ongun", "Remzi Kİtapevi"); // 'new' anahtar kelimesi ile 'Kutuphane' sınıfının yeni bir nesnesi türetilir ve bellekte yer ayrılır.
        Console.WriteLine($"{yazar1.WriterName}'un {yazar1.PageNumber} sayfalık , {yazar1.PublishingHouse} yayınevinden çıkan {yazar1.BookName} adlı kitabının kaydı oluşturuldu.");
        // Properties (özellikler), sınıfın her bir nesnesine ait verileri saklamak için kullanılır.
        // Burada BookName, PageNumber, WriterName, ve PublishingHouse adlı özellikler tanımlanmıştır.
        // Constructor (yapıcı metot), sınıfın yeni bir nesnesi oluşturulduğunda çalışan bir metottur.

        //public Kutuphane(string kitapAdi, string sayfaSayisi, string yazarAdi, string yayinEvi)
        //_kitapAdi = kitapAdi;
        //_yazarAdi = yazarAdi;
        //_sayfaSayisi = sayfaSayisi;
        //_yayinEvi = yayinEvi;
        // Burada constructor, sınıfın özelliklerine başlangıç değerleri atıyor.
        // Parametreler aracılığıyla kitap bilgileri atanıyor.
        Console.WriteLine("-------------------------------------------------------------------------");

        Kutuphane yazar2 = new Kutuphane();
        yazar2.WriterName = "Ayşe Kulin";
        yazar2.PageNumber = "398";
        yazar2.PublishingHouse = "Nezih Kitapevi";
        yazar2.BookName = "Adı:Aylin";
        Console.WriteLine($"{yazar2.WriterName}'un {yazar2.PageNumber} sayfalık , {yazar2.PublishingHouse} yayınevinden çıkan {yazar2.BookName} adlı kitabının kaydı oluşturuldu.");
        Console.WriteLine("-------------------------------------------------------------------------");

        Kutuphane yazar3 = new Kutuphane("Kırmızı Saçlı Kadın", "220", "Orhan Pamuk", "Penguen Kitapevi");
        Console.WriteLine($"{yazar3.WriterName}'un {yazar3.PageNumber} sayfalık , {yazar3.PublishingHouse} yayınevinden çıkan {yazar3.BookName} adlı kitabının kaydı oluşturuldu.");
    }
}