namespace Lern_Periode_3
{
    internal class Rechner
    {
        static void Main()
        {
            Random random = new Random();

            int zahl1 = random.Next(1, 101);
            int zahl2 = random.Next(1, 101);

            bool Addition = random.Next(0, 2) == 0;

            if (Addition)
            {
                Console.Write($"Was ist {zahl1} + {zahl2}? ");
            }
            else
            {
                Console.Write($"Was ist {zahl1} - {zahl2}? ");
            }

        }
    }
}

 