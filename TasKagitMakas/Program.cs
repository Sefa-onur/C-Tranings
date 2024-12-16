Console.WriteLine("Seçim Yapınız:");
Console.WriteLine("Taş için biri: 1");
Console.WriteLine("Kağıt için ikiyi: 2");
Console.WriteLine("Makas için üçü: 3");


bool döngü = true;
int oyuncuskoru = 0;
int bilgisayarskoru = 0;
do
{
    int oyuncu;
    oyuncu = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    int bilgisayar = rnd.Next(1, 4);

    if (oyuncu == bilgisayar)
    {
        Console.WriteLine("Berabere");
    }
    else if (oyuncu == 1 & bilgisayar == 2)
    {
        Console.WriteLine("Bilgisayar Eli Kazandı..");
        Console.WriteLine("Kağıt Taşı Yener..");
        bilgisayarskoru++;
    }
    else if (oyuncu == 1 & bilgisayar == 3)
    {
        Console.WriteLine("Eli Kazandınız..");
        Console.WriteLine("Taş Makası Yener..");
        oyuncuskoru++;
    }
    else if (oyuncu == 2 & bilgisayar == 1)
    {
        Console.WriteLine("Eli Kazandınız..");
        Console.WriteLine("Kağıt Taşı Yener..");
        oyuncuskoru++;
    }
    else if (oyuncu == 2 & bilgisayar == 3)
    {
        Console.WriteLine("Bilgisayar Eli Kazandı..");
        Console.WriteLine("Makas Kağıtı Yener..");
        bilgisayarskoru++;
    }
    else if (oyuncu == 3 & bilgisayar == 1)
    {
        Console.WriteLine("Bilgisayar Eli Kazandı..");
        Console.WriteLine("Taş Makası Yener..");
        bilgisayarskoru++;
    }
    else if (oyuncu == 3 & bilgisayar == 2)
    {
        Console.WriteLine("Eli Kazandınız..");
        Console.WriteLine("Makas Kağıtı Yener..");
        oyuncuskoru++;
    }

    if(oyuncuskoru == 3 || bilgisayarskoru == 3)
    {
        döngü = false;
    }
    if(oyuncuskoru == 3)
    {
        Console.WriteLine("Tebrikler Kazandınız!!");
    }
    else if(bilgisayarskoru == 3)
    {
        Console.WriteLine("Oyunu Bilgisayar Kazandı!!");
    }
} while(döngü);

Console.WriteLine($"Skorlar : Oyuncu:{oyuncuskoru} Bilgisayar:{bilgisayarskoru}");



Console.ReadKey();

