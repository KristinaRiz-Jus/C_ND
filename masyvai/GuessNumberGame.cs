using System;

class GuessNumberGame
{
    public static void Run()
    {
        Random rnd = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int secretNumber = rnd.Next(1, 101); // atsitiktinis skaičius nuo 1 iki 100
            int guess = 0;

            Console.WriteLine("\nSugeneruotas skaičius nuo 1 iki 100. Bandykite atspėti!");

            while (guess != secretNumber)
            {
                Console.Write("Įveskite savo spėjimą: ");
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Įveskite skaičių nuo 1 iki 100.");
                    continue;
                }

                if (guess < secretNumber)
                    Console.WriteLine("Sugeneruotas skaičius didesnis");
                else if (guess > secretNumber)
                    Console.WriteLine("Sugeneruotas skaičius mažesnis");
                else
                    Console.WriteLine("Jūs atspėjote :)");
            }

            // Papildomas funkcionalumas – klausimas, ar žaisti dar kartą
            Console.Write("Ar norite žaisti dar kartą? (Taip/Ne): ");
            string? response = Console.ReadLine();

            if (response != null && (response.Equals("Ne", StringComparison.OrdinalIgnoreCase)))
            {
                playAgain = false;
                Console.WriteLine("Ačiū už žaidimą!");
            }
            else
            {
                Console.WriteLine("Pradedamas naujas žaidimas...");
            }
        }
    }
}