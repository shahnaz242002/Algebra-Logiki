using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("height");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("lenght");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("width");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("mass");
int mass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("distance");
int distance= Convert.ToInt32(Console.ReadLine());
int sum = height + width + lenght;
if (sum<150)
{
    Console.WriteLine("Является малогабаритным");
}
else if (height<100 && width< 10 && lenght< 100)
{
    Console.WriteLine("Является малогабаритным");
}
else if (mass<10)
{
    Console.WriteLine("Является малогабаритным");
}
else if (distance<3 && distance<10)
{
Console.WriteLine("Является малогабаритным");
}
else
{
    Console.WriteLine("Не является малогабаритным");
}
