using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi
{
    class KullaniciManager : IManager
    {
        private string kullaniciAdi;
        public KullaniciManager(Kullanici kullanici)
        {
            kullaniciAdi = kullanici.KullaniciAdi;
        }

        public void Add()
        {
            Console.WriteLine("Kullanıcı eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }
    }
}
