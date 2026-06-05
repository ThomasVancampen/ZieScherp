// See https://aka.ms/new-console-template for more information

double kills;
double deaths;

Console.WriteLine("Hoeveel kills heb je");
kills = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hoeveel deaths heb je");
deaths = Convert.ToDouble(Console.ReadLine());

double kdRatio = kills/deaths;

Console.WriteLine("Je k/d-ratio is " + kdRatio);