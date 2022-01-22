using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sesliharf = new ArrayList();
            Console.Write("Lütfen bir cümle giriniz: ");
            string metin=Console.ReadLine();
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;
            for (int i=0;i<metin.Length;i++)
            {
                if (sesli.Contains(metin[i]))
                {
                    sayac++;
                    sesliharf.Add(metin[i]);
                }

            }

            Console.WriteLine("Kelime içerisinde toplam " + sayac + " tane sesli harf var.");
            Console.WriteLine("Bunlar Şöyledir.");
            foreach (var item in sesliharf)
            {
                Console.WriteLine(item);
            }
        }
    }
}
