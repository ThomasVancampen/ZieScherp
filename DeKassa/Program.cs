// See https://aka.ms/new-console-template for more information

const double FRIETENPRIJS = 4.50;
const double KONINGINNENHAPJEPRIJS = 12.00;
const double COLAPRIJS = 2.80;

const int FRIETENAANTAL = 2;
const int KONINGINNENHAPJEAANTAL = 1;
const int COLAAANTAL = 3;

const double WISSELKOERSDOLLAR = 1.08;

double totaalBedragFrieten = FRIETENAANTAL * FRIETENPRIJS;
double totaalBedragKoninginnehapje = KONINGINNENHAPJEAANTAL * KONINGINNENHAPJEPRIJS;
double totaalBedragCola = Math.Round(COLAAANTAL * COLAPRIJS, 2);

double totaalBedrag = totaalBedragFrieten + totaalBedragKoninginnehapje + totaalBedragCola;
double totaalAantalItems = FRIETENAANTAL + KONINGINNENHAPJEAANTAL + COLAAANTAL;
double gemideldBedragPerItem = Math.Round(totaalBedrag / totaalAantalItems, 2);

double totaalBedragInDollar = totaalBedrag * WISSELKOERSDOLLAR;

Console.WriteLine("Kassa wordt geladen... druk op enter");
Console.ReadLine();
Console.Clear();

Console.WriteLine("*************************");
Console.WriteLine("KASSATICKET");
Console.WriteLine("*************************");
Console.WriteLine(FRIETENAANTAL + " x Friet       : " + totaalBedragFrieten + " euro");
Console.WriteLine(KONINGINNENHAPJEAANTAL + " x Koninginha  : " + totaalBedragKoninginnehapje + " euro");
Console.WriteLine(COLAAANTAL + " x Cola        : " + totaalBedragCola + " euro");
Console.WriteLine("-------------------------");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("TOTAAL (EUR)    : " + totaalBedrag + " euro");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("TOTAAL (USD)    : " + totaalBedragInDollar + " euro");
Console.ResetColor();
Console.WriteLine("-------------------------");
Console.WriteLine("Gemiddeld/prod  : " + gemideldBedragPerItem + " euro");
Console.WriteLine("*************************");