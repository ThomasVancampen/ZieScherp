// See https://aka.ms/new-console-template for more information

Console.WriteLine("Geef de filmtitel:");
string filmtitle = Console.ReadLine();
Console.WriteLine("Geef de prijs:");
string prijs = Console.ReadLine();
Console.WriteLine("Geef je naam:");
string naam = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("--------------------");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(filmtitle);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(prijs);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(naam);
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("--------------------");
Console.ResetColor();