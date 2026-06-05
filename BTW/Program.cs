// See https://aka.ms/new-console-template for more information
double prijs = 20;
const double BTW = 21.0;

double btwBedrag = prijs * BTW/100;
double prijsMetBtw = prijs + btwBedrag;

Console.WriteLine("Prijs 20 euro zonder btw. Met BTW: " + prijsMetBtw + " euro");