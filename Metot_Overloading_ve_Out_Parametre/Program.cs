using System;

namespace Metot_Overloading_ve_Out_Parametre
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi ="999";

           bool sonuc= int.TryParse(sayi,out int outSayi);
            //sayıyı git bana çevirip çeviremediğine bak çevirebiliyorsam çevirdiğin sayıyı bana şu şekilde geri dön out int outSayi

            //başarılı bir çevrim olmuş mu bakalım
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar nesne = new Metotlar();
            nesne.Topla(4,5,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);

            //Metot Aşırı Yükleme - Overloading
            // bir fonksiyonun imzasını değiştirerek birden fazla şekilde o fonksiyonu kullanabiliriz.

            int ifade = 888;
            nesne.EkranaYazdir(Convert.ToString(ifade));
            nesne.EkranaYazdir(ifade);//başta bunu izin vermemişti overloadingden sonra izin verdi.
             
             nesne.EkranaYazdir("cem","kunduz");

            //Metot imzası
            //metot Adi +parametre sayısı + parametre
            //3ü aynı olduğunda kızar
        }
    }
    class Metotlar
    {
        public void Topla(int a,int b,out int toplam)
        {
           toplam=a+b;
        }

        //metot overloading yaptım metotun hem string tipinde hem de int tipinde bir parametre alan karşılığı var

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
