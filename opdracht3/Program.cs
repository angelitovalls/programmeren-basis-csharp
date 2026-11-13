namespace opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer = "42";
            int getal = int.Parse(invoer);
            int resultaat = getal * 2;

            Console.WriteLine("Het dubbele is: " + resultaat);
            Console.ReadLine();
            //De uitkomst is 84, omdat het ingevoerde getal 42 keer 2 word gedaan.
        }
    }
}
