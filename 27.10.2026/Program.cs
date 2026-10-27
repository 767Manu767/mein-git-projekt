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
// /*

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