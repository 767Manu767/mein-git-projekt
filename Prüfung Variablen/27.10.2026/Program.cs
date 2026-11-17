// AUFGABE 2
//A)
/*
int x = 1;
while (x < 50)
{
    Console.WriteLine(x);
    x = x * 2;
}
Console.WriteLine("Ende: " + x);
*/
//B)
/*
int a = 10;
int b = 0;
while (a > 0)
{
    b += a;
    a -= 3;
}
Console.WriteLine("a = " + a + ", b = " + b);
*/

//AUFGABE 3
/*


//Teil 1
int i = 10;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}
Console.WriteLine("Start");

//Hier ist der 2. Teil!!!
Console.Write("Gib eine Ganze zahl an: ");
int x = 1;
int n = int.Parse(Console.ReadLine());
int summe = 0;

while (x <= n)
{
    summe += x;
    x++;

}
Console.WriteLine(summe);
*/

//AUFGABE 4
/*
int summe = 0;
int zahl = 0;
do
{
    Console.Write("Zahl: ");
    zahl = Convert.ToInt32(Console.ReadLine());
    summe += zahl;
}
while (zahl != 0);
Console.WriteLine("Summe: " + summe);
*/

//AUFGABE 5
/*

Console.Write("Wie alt bist du ? ");
int alter = int.Parse(Console.ReadLine());

while (alter < 0 || alter > 120)
{
    Console.WriteLine("Stop Capping");
    Console.Write("Wie alt bist du fr? ");
    alter = int.Parse(Console.ReadLine());
}
Console.WriteLine("Du bist " + alter + ", Glückwunsch...");
*/

//AUFGABE 6