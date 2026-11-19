namespace opdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string één = "Welkom bij C#!";
            //Dit past het best bij een string ,omdat het een tekst is.
            short twee = 260;
            //Dit past het best bij een short ,omdat het een getal is en het tussen -32.768 en 32.767 ligt.
            short drie = -56;
            //Dit past het best bij een short ,omdat het een getal is en het tussen -32.768 en 32.767 ligt.
            double vier = 2001.99;
            //Dit past het best bij een double ,omdat het een kommagetal is.
            string vijf = "k1ngd0m";
            //Dit past het best bij een string ,omdat het een tekst is

            Console.WriteLine($"{één}");
            Console.WriteLine($"{twee}");
            Console.WriteLine($"{drie}");
            Console.WriteLine($"{vier}");
            Console.WriteLine($"{vijf}");

        }
    }
}
