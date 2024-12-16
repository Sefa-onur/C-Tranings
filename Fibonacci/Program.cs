
Console.Write("Bir Sayı Giriniz:");

int deger = Convert.ToInt32(Console.ReadLine());

int a = 1;
int b = 1;
int kat = 0;
Console.WriteLine(a);
Console.WriteLine(b);
for (int i = 1; i <= deger; i++)
{
    kat = a + b;
    a = b;
    b = kat;
    Console.WriteLine(kat);
}