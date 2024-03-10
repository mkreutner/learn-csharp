using System;
namespace QuizzCapitales
{
	public class Quizz
	{
        static string[] pays = { "Albanie", "Allemagne", "Andore", "Autriche",
            "Belgique", "Bielorussie", "Bosnie-Herzegovine", "Bulgarie",
            "Chypre", "Croatie"
        };
        static string[] capitales = { "Tirana", "Berlin", "Andore-la-Vieille", "Vienne",
            "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb"
        };
        const int MIN_QUESTION_IDX = 0;
        const int MAX_QUESTION_IDX = 9;

        public static bool PoserQuestion(int idxQuestion = 0)
        {
            bool bonneReponse = false;
            Console.WriteLine($"Quelle est la capitale du {pays[idxQuestion]} ?");
            string? reponse = Console.ReadLine();
            if ((reponse == null)
                || (reponse == string.Empty)
                || (reponse?.ToLower() != capitales[idxQuestion].ToLower())
                )
            {
                Console.WriteLine($"Mauvaise reponse, La reponse etait {capitales[idxQuestion]}.");
            }
            else
            {
                bonneReponse = true;
                Console.WriteLine($"Bravo !");
            }
            return bonneReponse;
        }

        public static bool DemanderSiRejouer()
        {
            bool continuer = false;
            Console.WriteLine($"{Environment.NewLine}Voulez-vous rejouer [O/N] ?");
            string? rep = Console.ReadLine();
            if ((rep?.ToLower() == "o") && (rep != null))
            {
                continuer = true;
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Merci d'avoir joue !");
            }
            return continuer;
        }

        public static void Jouer()
		{
            int goodAnswerCounter;
            bool playAgain = true;

            do
            {
                goodAnswerCounter = 0;
                

                for (int i = 0; i < pays.Length; i++)
                {
                   if (PoserQuestion(i) == true)
                    {
                        goodAnswerCounter++;
                    }
                }

                string pluriel = (goodAnswerCounter > 1) ? "s." : ".";
                Console.WriteLine($"{Environment.NewLine}Vous avez repondu juste a {goodAnswerCounter} question" + pluriel);
                playAgain = DemanderSiRejouer();
            } while (playAgain);

            
            Console.ReadKey();
        }

        public static void Jouer(params int[] indexes)
        {
            int goodAnswerCounter;
            bool playAgain = true;

            do
            {
                goodAnswerCounter = 0;


                for (int i = 0; i < indexes.Length; i++)
                {
                    if (((indexes[i] >= MIN_QUESTION_IDX)
                        && (indexes[i] <= MAX_QUESTION_IDX)))
                    {
                        if (PoserQuestion(indexes[i]) == true)
                        {
                            goodAnswerCounter++;
                        }
                    }
                }

                string pluriel = (goodAnswerCounter > 1) ? "s." : ".";
                Console.WriteLine($"{Environment.NewLine}Vous avez repondu juste a {goodAnswerCounter} question" + pluriel);
                playAgain = DemanderSiRejouer();
            } while (playAgain);


            Console.ReadKey();
        }
    }
}

