// See https://aka.ms/new-console-template for more information
Console.Write("Geef een bestand naam: ");
string bestandNaam = Console.ReadLine();
bestandNaam = bestandNaam + ".txt";
Console.Write("Geef een tekst: ");
string tekst = Console.ReadLine();

System.IO.File.WriteAllText(bestandNaam, tekst);