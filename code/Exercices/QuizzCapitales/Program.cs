namespace QuizzCapitales;

class Program
{
    static void Main(string[] args)
    {
        string[] pays = { "Albanie", "Allemagne", "Andore", "Autriche",
            "Belgique", "Bielorussie", "Bosnie-Herzegovine", "Bulgarie",
            "Chypre", "Croatie"
        };
        string[] capitales = { "Tirana", "Berlin", "Andore-la-Vieille", "Vienne",
            "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb"
        };
        int goodAnswerCounter;
        bool playAgain = true;

        do
        {
            goodAnswerCounter = 0;
            Console.Clear();

            // all questions
            for (int i = 0; i < pays.Length; i++)
            // 1 question over 2
            //for (int i = 0; i < pays.Length; i += 2)
            // revert all questions
            //for (int i = pays.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine($"Quelle est la capitale du {pays[i]} ?");
                string? reponse = Console.ReadLine();
                if ((reponse == null)
                    || (reponse == string.Empty)
                    || (reponse?.ToLower() != capitales[i].ToLower())
                    )
                {
                    Console.WriteLine($"Mauvaise reponse, La reponse etait {capitales[i]}.");
                }
                else
                {
                    goodAnswerCounter++;
                    Console.WriteLine($"Bravo !");
                }
            }

            string pluriel = (goodAnswerCounter > 1) ? "s." : ".";

            Console.WriteLine($"{Environment.NewLine}Vous avez repondu juste a {goodAnswerCounter} question" + pluriel);

            Console.WriteLine($"{Environment.NewLine}Voulez-vous rejouer [O/N] ?");
            string? rep = Console.ReadLine();
            playAgain = rep?.ToLower() == "o" && rep != null;
        } while (playAgain);

        Console.WriteLine($"{Environment.NewLine}Merci d'avoir joue !");
        Console.ReadKey();
    }
}

