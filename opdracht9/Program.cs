namespace opdracht9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies (1) small, (2) medium of (3) large:");
            +int keuze = int.Parse(Console.ReadLine());          
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("Small kost 2,00");
                    
                    break;
                case 2:
                    Console.WriteLine("Medium kost 2,50");
                    
                    break;
                case 3:
                    Console.WriteLine("Large kost 3,00");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
            Console.ReadLine();
        }
    }
}
