namespace opdracht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Raad het geluksgetal: ");
            ConsoleKeyInfo toets = Console.ReadKey();
            Console.WriteLine(); 

            char geluksgetal = toets.KeyChar;

            if (geluksgetal == '5')
            {
                Console.WriteLine("Correct mijn geluksgetal is 5!");
            }
            else if (char.IsDigit(geluksgetal))
            {
                Console.WriteLine(geluksgetal + " is niet juist.");
            }
            else
            {
                Console.WriteLine(geluksgetal + " is niet juist. Voer een cijfer in.");
            }

            Console.ReadLine();
        }
    }
}
