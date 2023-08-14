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