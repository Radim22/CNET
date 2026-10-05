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

*/


Console.WriteLine("Kolik ti je let?");

int vek = Convert.ToInt32(Console.ReadLine());

if (vek < 18)
{Console.WriteLine("Jsi nezletilý.");}
else
{Console.WriteLine("Jsi dospělý.");}