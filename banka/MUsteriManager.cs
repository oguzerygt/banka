using System;
using System.Collections.Generic;
using System.Text;

namespace banka
{
    class MUsteriManager
    {
        List <Musteri> musteriler=new List<Musteri>();

        public void Ekle(string isim,string soyIsim)
        {
            musteriler.Add(new Musteri(isim, soyIsim));
            Console.WriteLine("eklendi");
        }
        public void Sil(string isim, string soyIsim)
        {
            Musteri silinecekMusteri=null;
            foreach (Musteri item in musteriler)
            {
                if (item.isim == isim && item.soyIsim == soyIsim)
                {
                    silinecekMusteri = item;//silinecek müşteriyi buluruz
                    break;
                }
            }
            if (silinecekMusteri!=null)
            {
                musteriler.Remove(silinecekMusteri);
                Console.WriteLine("silindi");
            }
            else
            {
                Console.WriteLine("silinecek müsteri bulunamadı");
            }
        }
        public void Listele()
        {
            Console.WriteLine("\nmustetiler:");
            foreach (Musteri item in musteriler)
            {
               
                Console.WriteLine("\t"+item.isim+" "+item.soyIsim+" "+item.bakiye);
            }
        }
    }
}
