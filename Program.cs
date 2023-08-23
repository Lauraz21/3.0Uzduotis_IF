Console.WriteLine("Iveskite atsikelimo laika");
int time = Convert.ToInt32(Console.ReadLine());
if (time < 12)
{
    Console.WriteLine("Geros dienos!");
}
else if (time >= 12 && time <= 18)
{
    Console.WriteLine("Geros popietes!");
}
else if (time >= 18 && time <= 24)
{
    Console.WriteLine("Gero vakaro!");
}