Console.WriteLine("Sınav Sonuçlarını Giriniz.");

int vize;
int final;

Console.Write("Vize:");
vize = Convert.ToInt32(Console.ReadLine());
Console.Write("Final:");
final = Convert.ToInt32(Console.ReadLine());

int ortamala = (vize + final) / 2;

if(ortamala >= 50)
{
    Console.WriteLine("Tebrikler Geçtiniz!");
}
else
{
    Console.Write("Büt Puanınızı Giriniz:");
    int büt = Convert.ToInt32(Console.ReadLine());
    int bütort = (vize + final + büt) / 3;
    if (bütort >= 50) Console.WriteLine("Tebrikler Geçtiniz");
    else Console.WriteLine("Kaldınız!");
}