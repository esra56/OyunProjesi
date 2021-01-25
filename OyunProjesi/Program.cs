using System;

namespace OyunProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici1 = new Kullanici();
            kullanici1.Id = 3;
            kullanici1.KullaniciAdi = "Ayşe" ;
            kullanici1.Sifre = "1234666";
            kullanici1.Kart = 4562;

            Kullanici kullanici2 = new Kullanici();
            kullanici2.Id = 1;
            kullanici2.KullaniciAdi = "Ali";
            kullanici2.Sifre = "253789";
            kullanici2.Kart = 3675;

            KullaniciManager manager1 = new KullaniciManager(kullanici2);
            manager1.Add();
            manager1.Delete();

            Oyunlar oyun1 = new Oyunlar();
            oyun1.OyunId = 2 ;
            oyun1.OyunAdi = "COD 5";
            oyun1.OyunFiyati =999;

            Kampanya kampanya = new Kampanya();
            kampanya.KampanyaT = "Tüm oyunlar indirimde";
            kampanya.İndirimOrani = 70;

            KampanyaManager kampanyaManager = new KampanyaManager(kampanya);
            kampanyaManager.Add();
            kampanyaManager.Delete();

            OyunSatmaManager oyunSatmaManager = new OyunSatmaManager(kullanici2,oyun1,kampanya);
            oyunSatmaManager.satis();




        }
    }
}
