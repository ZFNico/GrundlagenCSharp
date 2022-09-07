Console.WriteLine("Bitte geben sie die erste zahl ein:");
string mich1 = Console.ReadLine();
Console.WriteLine("Bitte geben sie die zweite zahl ein:");
string mich2 = Console.ReadLine();

int michint1 = Convert.ToInt32(mich1); 
int michint2 = Convert.ToInt32(mich2);

if (michint1 > michint2)

    Console.WriteLine(michint2);
else
    Console.WriteLine(michint1);