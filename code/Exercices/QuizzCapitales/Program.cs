namespace QuizzCapitales;

class Program
{
    static void Main(string[] args)
    {
        //Quizz.Jouer(1,5,8,9,50);
        OutilsMaths.GetValeursMinMax(out double mini, out double maxi, 4.21, 5.54, 2.13, 3.47);
        Console.WriteLine($"Valeurs mini et maxi : {mini}, {maxi}");

        double min, max;
        OutilsMaths.GetValeursMinMax(out min, out max, 4.21, 5.54, 2.13, 3.47);

        bool repOk;
        do
        {
            Console.WriteLine("Saisissez un nombre compris entre 1 et 10 :");
            string? rep = Console.ReadLine();
            repOk = int.TryParse(rep, out int nombre) && nombre >= 1 && nombre <= 10;
        } while (!repOk);
    }
}

