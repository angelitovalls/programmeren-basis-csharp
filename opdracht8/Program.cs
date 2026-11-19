namespace opdracht8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("raad mij gelukswoord");

            string gelukswoord = Console.ReadLine();
            string resultaat = (gelukswoord?.ToUpper() == "LUcky") ? $"Correct my gelukswoord is {gelukswoord}!" : "Incorrect my gelukswoord is niet lucky.";
            Console.WriteLine(resultaat);
        }
    }
} 
