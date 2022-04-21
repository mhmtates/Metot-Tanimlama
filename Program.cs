using System;

namespace Metot_Tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim Belirteci Geri Dönüş Tipi Metot Adı(Parametre Listesi/Argüman)
            //{
            //// Komutlar 
            //return;
            //}
            int a = 2;
            int b = 3;
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));
           
            int sonuc2 = ornek.ArttirveTopla(ref a,ref b);
             ornek.EkranaYazdır(Convert.ToString(sonuc2));
             ornek.EkranaYazdır(Convert.ToString(a+b));
        }

        static int Topla(int deger1, int deger2)
        {

            return (deger1 + deger2);
        }
    }
        public class Metotlar
        {
            public void EkranaYazdır(string veri)
            {
                Console.WriteLine(veri);
            }


            public int ArttirveTopla(ref int deger1, ref int deger2)
            {

                deger1 += 1;
                deger2 += 1;
                return deger1 + deger2;
            }
        }
    }
    
