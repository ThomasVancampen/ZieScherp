// See https://aka.ms/new-console-template for more information

const short MAGICNUMBER = 411;

for (int i = 1; i < 11; i++)
{
    int uitkomst = MAGICNUMBER * i;
    Console.WriteLine(i + " x " + MAGICNUMBER + " = " + uitkomst);
    Console.WriteLine("Druk op enter voor de volgende lijn.");
    Console.ReadLine();
    Console.Clear();
}