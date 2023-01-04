using System.Security.Cryptography.X509Certificates;

namespace A2_task3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            decimal n =  decimal.Parse(Console.ReadLine());
            int real = (int)n;
            decimal kesr = n - real;
            decimal x = (real / 1000M);
            decimal reverse = x + kesr * 1000;
            
            
            Console.WriteLine($"{reverse}");
        }
    }
}