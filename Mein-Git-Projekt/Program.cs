//W6 Bedingungen (if else)
//Aufgabe 4

Console.Write("Geschlecht(m/f)? ");
char genderInput = char.Parse(Console.ReadLine());

//Gewichtsberechnung
Console.Write("Gewicht? ");
decimal gewicht = decimal.Parse(Console.ReadLine());


//Gewicht SEHR LEICHT
if (gewicht < 55.0m)
{
    if (genderInput == 'm')
    {
        Console.WriteLine("Du kommst in die **Federleichte** Klasse");
    }
    if (genderInput == 'f')
    {
        if (gewicht > 48)
        {
            Console.WriteLine("Du kommst in die Klasse **Leichtgewicht**");
        }
        else
        {
            Console.WriteLine("Du kommst in die **Federleichte** Klasse");
        }
    }
}

//MALE
else if (genderInput == 'm')
{
    if (gewicht < 66.0m)
    {
        Console.WriteLine("Du kommst in die Klasse **Leichtgewicht**");
    }
    else if (gewicht < 84.0m)
    {
        Console.WriteLine("Du kommst in die Klasse **Mittelgewicht**");
    }
    else if (gewicht > 84.0m)
    {
        Console.WriteLine("Du kommst in die Klasse **Schwergewicht**");
    }
}

//FEMALE
else if (genderInput == 'f')
{
    if (gewicht < 63.0m)
    {
        Console.WriteLine("Du kommst in die Klasse **Mittelgewicht**");
    }
    if (gewicht > 63.0m)
    {
        Console.WriteLine("Du kommst in die Klasse **Schwergewicht**");
    }
}

