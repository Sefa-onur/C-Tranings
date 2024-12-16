using System.Runtime.Serialization.Formatters;

namespace AsalSayı
{
    class AsalSayı
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz:");
            int deger = Convert.ToInt32(Console.ReadLine());
            if(deger == 1 || deger == 0 )
            {
                Console.WriteLine("Sayı Asaldır");
            }
            else
            {
                int sonuc = 0;
                int sayac = 0;
                for (int i = 2; i < deger;i++)
                {
                    if (deger % i == 0)
                    {
                        sayac++;
                    }
                    else
                    {                       
                        sonuc++;
                    }
                }
                if(sayac > 0)
                {
                    Console.WriteLine($"{deger} Sayısı Asal Değildir.{sayac+1} Adet Tam Böleni Vardır");
                } 
                else
                {
                    Console.WriteLine($"{deger} Sayısı Asaldır");
                }
         
            }
                
            Console.ReadKey();
        }

    }
}
