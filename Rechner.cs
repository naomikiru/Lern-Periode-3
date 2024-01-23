namespace Lern_Periode_3
{
    internal class Rechner
    {
        static void Main()
        {
            Random random = new Random();

            for (int i = 0;i < 5;i++) 
            {
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

                int benutzerAntwort = Convert.ToInt32(Console.ReadLine());

                int korrekteAntwort = Addition ? (zahl1 + zahl2) : (zahl1 - zahl2);
                if (benutzerAntwort == korrekteAntwort)
                {
                    Console.WriteLine("Richtig!");
                }
                else
                {
                    Console.WriteLine($"Falsch. Die richtige Antwort ist {korrekteAntwort}.");
                }

            }

            Console.ReadLine();

        }
    }
}

 