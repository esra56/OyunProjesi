using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi
{
    class OyunSatmaManager
    {
        private string kullaniciAdi;//müşteri
        private float kart;

        private string oyunAdi; // oyun
        private float oyunFiyati;

        private string kampanyaT;//kampanyalar
        private float indirimOrani;

        public OyunSatmaManager(Kullanici kullanici, Oyunlar oyun, Kampanya kampanya)
        {
            kullaniciAdi = kullanici.KullaniciAdi;
            kart = kullanici.Kart;
            oyunAdi = oyun.OyunAdi;
            oyunFiyati = oyun.OyunFiyati;
            kampanyaT = kampanya.KampanyaT;
            indirimOrani = kampanya.İndirimOrani;

        }
        public void satis()
        {
            float Yfiyat = oyunFiyati * (indirimOrani/10);
            if(kart >= Yfiyat)
            {
                float Ykart = kart - Yfiyat;
                Console.WriteLine("sayın {0}; {1} oyununu {2} TL yerine {3} TL karşılığında satın aldınız. " +
                    "Yararlandığınız kampanya: {4}\n Bakiyenizde kalan para: {5}\nİyi eğlenceler dileriz."
                    ,kullaniciAdi, oyunAdi, Yfiyat,kampanyaT, kart);
            }
            else
            {
                Console.WriteLine("Yeterli bakiyeniz yok.");
            }
        }


    }
}
