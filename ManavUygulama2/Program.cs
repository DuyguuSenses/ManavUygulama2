/*Elma = 2 TL

Armut = 3 TL

Çilek = 2 TL

Muz = 3 TL

Diğer bütün meyveler = 4 TL

Kullanıcımıza konsol ekranında hangi meyveyi satın almak istediğini soruyoruz. Aldığımız cevaba göre ilgili meyvenin fiyatını ekrana yazdırıyoruz. */

Console.WriteLine("Rüya manavına hoşgeldiniz");
Console.WriteLine("Elma=2 TL");
Console.WriteLine("Armut=3 TL");
Console.WriteLine("Çilek=2 TL");
Console.WriteLine("Muz=3 TL");
Console.WriteLine("Diğer Bütün Meyveler=4 TL");

string elma = "elma";
int elmafiyat = 2;

string armut = "elma";
int armutfiyat = 3;

string cilek = "çilek";
int cilekfiyat = 2;

string muz = "muz";
int muzfiyat = 3;

string diger = "diğer";
int digerfiyat = 4;


Console.Write("Hangi meyveyi satın almak istersiniz ? (Elma/Armut/Çilek/Muz/Diğer):");
string cevap = (Console.ReadLine()).ToLower();

//if-else

if (cevap == elma)
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{elmafiyat} TL");
}
else if (cevap == armut)
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{armutfiyat} TL");
}
else if (cevap == cilek)
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{cilekfiyat} TL");
}
else if(cevap==muz)
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{muzfiyat} TL");

}
else
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{digerfiyat} TL");



//Switch-case

switch (cevap)
{
    case "elma":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{elmafiyat} TL");
        break;

    case "armut":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{armutfiyat} TL");
        break;

    case "çilek":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{cilekfiyat} TL");
        break;

    case "muz":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{muzfiyat} TL");
        break;
    default:
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{digerfiyat} TL");
        break;

}
