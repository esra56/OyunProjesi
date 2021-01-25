using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi
{
    class KampanyaManager : IManager
    {
        private string Ykampanya;

        public KampanyaManager(Kampanya kampanya)
        {
            Ykampanya = kampanya.KampanyaT;
        }
        public void Add()
        {
            Console.WriteLine(" Yeni kampanya eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update()
        {
            Console.WriteLine(" Yeni kampanya güncellendi.");
        }
    }
}
