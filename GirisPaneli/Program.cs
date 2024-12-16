

Console.Write("Kullanıcı İsmi:");

string isim = Console.ReadLine();

Console.Write("Şifre:");

string sifre = Console.ReadLine();

if (isim == "Demo"&&sifre == "123456")
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Hatalı Giriş!");
}