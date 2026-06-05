// See https://aka.ms/new-console-template for more information

int september;
int oktober;
int november;

Console.WriteLine("Hoeveel uren slaap ga je krijgen in september?");
september = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hoeveel uren slaap ga je krijgen in oktober?");
oktober = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hoeveel uren slaap ga je krijgen in november?");
november = Convert.ToInt32(Console.ReadLine());

int totaalAantalUrenSlaap = september + oktober + november;
float gemiddeldeUrenSlaap = (float)totaalAantalUrenSlaap / 3;

Console.WriteLine("Je slaapt gemideld " + gemiddeldeUrenSlaap + "uren per maand");

