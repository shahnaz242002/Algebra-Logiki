
using System.Security.Cryptography;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("name:");
string clientName = Console.ReadLine();
Console.WriteLine("age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("count of order:");
int kolicestvoZakazov =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("summa potracennix deneg:");
int summa = Convert.ToInt32(Console.ReadLine());
if (age>60)
{
    Console.WriteLine("Вы получаете скидку");
}
else if (summa>5000 && kolicestvoZakazov > 4)
{
    Console.WriteLine("Вы получаете скидку");
}
else
{
    Console.WriteLine("Вы не получаете скидку");
}
