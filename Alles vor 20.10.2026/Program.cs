//Aufgabe 2, Nr. 1
/*
Console.Write("A = ");
string inputA = Console.ReadLine();
decimal a = decimal.Parse(inputA);

Console.Write("B = ");
string inputB = Console.ReadLine();
decimal b = decimal.Parse(inputB);

decimal add = a + b;
decimal sub = a - b;
decimal mult = a * b;
decimal div = a / b;

Console.WriteLine(add);
Console.WriteLine(sub);
Console.WriteLine(mult);
Console.WriteLine(Math.Round(div, 2));
*/

//Aufgabe 3
/*
int x = 5;
x++;
Console.WriteLine(x);
x--;
x--;
Console.WriteLine(x);
*/

//Aufgabe 4
/*
decimal riegelPreis = 3.20m;
decimal budget = 20;

decimal anzahlRiegel = budget / riegelPreis;
int anzahlRiegelInt = Convert.ToInt32(anzahlRiegel);
Console.WriteLine($"Du kannst {anzahlRiegelInt} Riegel kaufen.");
decimal rest = budget % riegelPreis;
Console.WriteLine($"Du hast {rest} Geld übrig");
*/

//Aufgabe 5, Nr. 1
/*
Console.Write("A = ");
decimal a = decimal.Parse(Console.ReadLine());

Console.Write("B = ");
decimal b = decimal.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} ist grösser als {b}");
}
else if (a < b)
{
    Console.WriteLine($"{a} ist kleiner als {b}");
}
else
{
    Console.WriteLine($"{a} ist gleich wie {b}");
}
*/

//Aufgabe 6, Nr. 1 und 2
/*
Console.Write("X = ");
decimal x = decimal.Parse(Console.ReadLine());

bool zwischen10Und20 = x > 10 && x < 20;
Console.WriteLine($"Ist {x} zwischen 10 und 20: {zwischen10Und20}");

bool kleiner0Grösser100 = x > 100 || x < 0;
Console.WriteLine($"Ist {x} grösser als 100 oder kleiner als 0: {kleiner0Grösser100}");
*/

//Aufgabe 7
/*
Console.Write("Gebe ein Passwort ein: ");
string password = Console.ReadLine();

int länge = password.Length;

if (länge > 8)
{
    Console.WriteLine("Dein passwort ist stark");
}

else
{
    Console.WriteLine("Dein passworrt ist nicht stark genug, bitte brauche ein längeres passwort (>8 Zeichen)!");
}
*/

//Aufgabe 8
/*
Console.Write("Wie schnell ist dein Auto durchschnittlich (Km/h)? ");
decimal speed = decimal.Parse(Console.ReadLine());

Console.Write("Wie viel benzin verbrauchst du per 100km (liter)? ");
decimal benzinVerbrauch = decimal.Parse(Console.ReadLine());

Console.Write("Wie weit willst du fahren (km)? ");
decimal distanz = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Du brauchst {distanz / speed}h und verbrauchst {(benzinVerbrauch / 100) * distanz} liter benzin.");
*/

//Aufgabe 9 IN PROGRESS
// /*
Console.Write("Wie schwer bist du (Kg)? ");
decimal gewicht = decimal.Parse(Console.ReadLine());

Console.Write("Wie gross bist du (m)? ");
decimal grösse = decimal.Parse(Console.ReadLine());

double grösse2 = Math.Pow((double)(grösse), 2);
decimal grösse3 = Convert.ToDecimal(grösse2);

Console.WriteLine(gewicht / grösse3);
Console.WriteLine(grösse2);
// */

//Aufgabe 10
// /*
