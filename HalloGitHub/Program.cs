string s = "";

while (s != "n")
{
    //Abfrage
    Console.WriteLine("Geben sie eine Zahl zwischen 0-10 ein");

    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(a);

    //Schleife
    while (a < 0 || a > 10)
    {
        Console.WriteLine("Sie müssen eine Zahl zwischen 0-10 eingeben");
        a = Convert.ToInt32(Console.ReadLine());
    }

    //Antwort
    Console.WriteLine(String.Format("Sie haben es geschafft {0} ist eine zahl zwischen 0-10", a));

    Console.WriteLine("Möchten sie nochmal eine Zahl eingeben y/n");
    s = Console.ReadLine();
}

Console.WriteLine("Möchten Sie eine Bewertung abgeben? y/n");

string s1 = Console.ReadLine();

if (s1 == "y")
{
    Console.WriteLine("Würden Sie das Programm weiterempfehlen? y/n");

    s1 = Console.ReadLine();

    if (s1 == "n")
    {
        Console.WriteLine("Drecksack!");
    }
    else { Console.WriteLine("Mr. Niceguy!!!"); }
}

Console.ReadKey();