namespace Patika_Kütüphane
{
    public class Kutuphane
    {
        private string _kitapAdi;
        private string _yazarAdi;
        private string _sayfaSayisi;
        private string _yayinEvi;
        private DateTime _kayitTarihi;

        public Kutuphane()
        {
            _kayitTarihi = DateTime.Now;
            Console.WriteLine($"Kaydınız başarılı bir şekilde tamamlanmıştır. {_kayitTarihi}");
        }
        public Kutuphane(string kitapAdi, string sayfaSayisi, string yazarAdi, string yayinEvi)
        {
            _kitapAdi = kitapAdi;
            _yazarAdi = yazarAdi;
            _sayfaSayisi = sayfaSayisi;
            _yayinEvi = yayinEvi;
            _kayitTarihi = DateTime.Now;
            Console.WriteLine($"Kaydınız başarılı bir şekilde tamamlanmıştır.Kayıt tarihi:  {_kayitTarihi}");

        }

        public string BookName
        {
            get
            {
                return _kitapAdi;
            }
            set
            {
                _kitapAdi = value;
            }
        }
        public string WriterName
        {
            get
            {
                return _yazarAdi;
            }
            set
            {
                _yazarAdi = value;
            }
        }
        public string PageNumber
        {
            get
            {
                return _sayfaSayisi;
            }
            set
            {
                _sayfaSayisi = value;
            }
        }
        public string PublishingHouse
        {
            get
            {
                return _yayinEvi;
            }
            set
            {
                _yayinEvi = value;
            }
        }
        public DateTime RegistrationDate
        {
            get
            {
                return _kayitTarihi;
            }
            set
            {
                _kayitTarihi = value;
            }
        }

    }
}
