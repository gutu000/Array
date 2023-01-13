string[] stad = new string[3];
stad[0] = "";
stad[1] = "";
stad[2] = "";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Skriv in en stad");
    stad[i] = Console.ReadLine();
}
Console.WriteLine($"Städerna du skrev {stad[0]}, {stad[1]}, {stad[2]}.");
