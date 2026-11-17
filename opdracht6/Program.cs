namespace opdracht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer je geboortjaar in: ");
            int geboortjaar = int.Parse(Console.ReadLine());

            int huidigJaar = DateTime.Now.Year;
            int leeftijd = huidigJaar - geboortjaar;

            Console.WriteLine($"Je leeftijd is: {leeftijd} jaar.");
        }
    }
}
