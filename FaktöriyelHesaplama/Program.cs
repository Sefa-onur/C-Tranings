Console.Write("Bir Sayı Giriniz:");

int deger = Convert.ToInt32(Console.ReadLine());

int sonuc = 1;

for(int i = 1; i <= deger; i++)
{
    sonuc = sonuc*i;
}

Console.WriteLine(sonuc);

