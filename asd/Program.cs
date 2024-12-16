Console.Write("Bir Değer Giriniz:");
int deger;
deger = Convert.ToInt32(Console.ReadLine());

//Sola dayalı dik üçgen
for(int i = 1; i <= deger; i++)
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Sağa yatık üçgen
for(int i =0; i < deger; i++)
{
    for (int j = i; j <= deger; j++)
    {
        Console.Write(" ");
    }
    for(int k = 1;k <= i; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}




// Eşkenar üçgen
for (int i = 0; i <= deger; i++)
{
    for (int j = i; j <= deger; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i + 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}




