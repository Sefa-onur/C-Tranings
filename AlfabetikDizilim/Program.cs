Console.Write("Bir Kelime Giriniz:");

string kelime = Convert.ToString(Console.ReadLine());

int uzunluk = kelime.Length;

char[] dizi = new char[uzunluk];

for (int i = 0; i < uzunluk; i++)
{
    dizi[i] = kelime[i];
}

Array.Sort(dizi);

for (int i = 0;i < dizi.Length; i++)
{
    Console.WriteLine(dizi[i]);
}

Console.ReadKey();
