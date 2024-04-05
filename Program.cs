using System;

namespace Inlämninguppgift._3_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            namn p = new namn();
            Console.WriteLine("Förnamn?");
            p.Förnamm = Console.ReadLine();
            Console.WriteLine("Efternamn?");
            p.Efternamn = Console.ReadLine();
            Console.WriteLine("");
            p.Namn();

            bool myndig = false;
            Console.WriteLine("");
            Console.WriteLine("När är du född?");
            int år = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilken månd föddes du?");
            int månad = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilken dag föddes du?");
            int dag = int.Parse(Console.ReadLine());
            DateTime nu = DateTime.Today;
            DateTime årsedan = DateTime.Today.AddYears(-18);
            DateTime person = new DateTime(år, månad, dag);

            if (person < årsedan)
            {
                myndig = true;
            }

            Console.WriteLine("Din myndighetsstatus är " + myndig);

        }
    }
}