namespace TekÇift
{
    class Program
    {
        static void Main(string[] args) 
        {
            int sayi = 0;
            Console.Write("Bir Sayı Giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi % 2 == 0 )
            {
                Console.WriteLine($"{sayi} Çifttir..");
            }
            else
            {
                Console.WriteLine($"{sayi} Tektir");
            }
            Console.ReadKey();
        }
    }
}