using System;

namespace banka
{
    class Program
    {
        static void Main(string[] args)
        {
            MUsteriManager mm = new MUsteriManager();

            mm.Ekle("oguz", "ery");
            mm.Listele();
            mm.Ekle("engin", "dmr");
            mm.Listele();
            mm.Ekle("eren", "xyz");
            mm.Listele();
            mm.Sil("asdf", "fdsd");//kayıtlı olmayan kişiyi silme
            mm.Listele();
            mm.Sil("engin", "dmr");
            mm.Listele();
        }
    }
}
