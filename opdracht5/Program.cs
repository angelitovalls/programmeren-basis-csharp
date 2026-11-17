namespace opdracht5
{
   internal class Program
    {
        static void Main()
        {
            Console.Write("Voer de breedte in: ");
            double breedte = double.Parse(Console.ReadLine());

            Console.Write("Voer de hoogte in: ");
            double hoogte = double.Parse(Console.ReadLine());

            double oppervlakte = breedte * hoogte;

            Console.WriteLine(string.Format("De oppervlakte is: {0:F2}", oppervlakte));
        }
    }
}