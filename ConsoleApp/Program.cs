/*
 Console.WriteLine("Jak se jmenuješ?");

string jmeno = Console.ReadLine();

Console.Write("Ahoj, ");
Console.WriteLine(jmeno);

Console.WriteLine($"Tvoje jméno má {jmeno.Length} písmen.");

Console.WriteLine("lablala");


string hvezda = "********************************";

Console.WriteLine("Jak se jmenuješ?");

string jmeno = Console.ReadLine();


Console.WriteLine("Kde pracuješ?");

string firma = Console.ReadLine();


Console.WriteLine(hvezda);
Console.WriteLine(jmeno.ToUpper());
Console.WriteLine(firma);
Console.WriteLine(hvezda);




Console.WriteLine("Kolik ti je let?");

int vek =  int.Parse(Console.ReadLine());

if (vek < 18)
{Console.WriteLine("Jsi nezletilý.");}
else
{Console.WriteLine("Jsi dospělý.");}



Console.Writeline("Jak se jmenuje produkt?");
string produkt = Console.ReadLine();


Console.Writeline("Kolik kusů je na skladě?");
int kusy = int.Parse(Console.ReadLine());

if (kusy == 0)
    Console.WriteLine("Produkt není skladem.");

if (kusy <= 5)
    Console.WriteLine("Produkt je téměř vyprodaný.");

if (kusy > 5)
    Console.WriteLine("Produkt je skladem.");





Console.Write("Zahrajeme si hru kámen, nůžky, papír!!!");
Console.WriteLine("Zadej písmeno k, n nebo p:");
string hrac = Console.ReadLine();


int cislo = new Random().Next(0, 3);
string pocitac;

if (cislo == 0)
    pocitac = "k";
else if (cislo == 1)
    pocitac = "n";
else
    pocitac = "p";

Console.WriteLine("Počítač zvolil: " + pocitac);
if (hrac == pocitac)
{
    Console.WriteLine("Remíza!");
}
else if (
    (hrac == "k" && pocitac == "n") ||
    (hrac == "n" && pocitac == "p") ||
    (hrac == "p" && pocitac == "k")
)
{
    Console.WriteLine("Vyhrál jsi!");
}
else if (hrac == "k" || hrac == "n" || hrac == "p")
{
    Console.WriteLine("Vyhrál počítač!");
}
else
{
    Console.WriteLine("Zadal jsi neplatnou hodnotu.");
}

*/


for (int i = 0; i < 10; i = i + 2)  
{
    Console.Write($"{i} " );
    //Console.WriteLine(i);
    
};



var prvni = "ukazka";