using System;

namespace CSharp_2d_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D Arrays!");

            int people = 2;
            int scores = 3;

            int[,] peopleScores = new int[people, scores];

            // Person 1
            peopleScores[0, 0] = 15;
            peopleScores[0, 1] = 25;
            peopleScores[0, 2] = 35;

            // Person 2
            peopleScores[1, 0] = 20;
            peopleScores[1, 1] = 15;
            peopleScores[1, 2] = 30;

            int lengthPeople = peopleScores.GetLength(0);

            int lengthScores = peopleScores.GetLength(1);

            Console.WriteLine($"People has length {lengthPeople}");

            Console.WriteLine($"Scores has length {lengthScores}");

            int[] personScores = new int[lengthPeople];

            // Nästlade loop
            for (int person = 0; person < lengthPeople; person++)
            {
                int personSum = 0;

                for (int score = 0; score < lengthScores; score++)
                {
                    Console.WriteLine(peopleScores[person, score]);

                    personSum += peopleScores[person, score];
                }

                personScores[person] = personSum;

                Console.WriteLine($"Person {person + 1} got {personSum}");
            }

            Console.WriteLine();

            // Loop the person scores array
            for (int i = 0; i < personScores.Length; i++)
            {
                Console.WriteLine($"Person {i + 1} got {personScores[i]}");
            }

            // Alternativ sätt att skapa multidimensionell arrays

            Console.WriteLine("\nAlternativ sätt att skapa multidimensionell arrays\n");

            int[,] altScores = { { 10, 20, 30 }, { 15, 10, 25 } };

            int altLengthX = altScores.GetLength(0);

            int altLengthY = altScores.GetLength(1);

            Console.WriteLine($"Row X has length {altLengthX}");

            Console.WriteLine($"Column Y has length {altLengthY}");

            // "Dividerar integrar"
            Console.WriteLine("\nDividerar integrar\n");
            int a = 7;
            int b = 3;

            // Dividerar man två integrar är resultet altid en integer

            // Resultatet är 2.
            int div = a / b;

            // Remainder, det som är kvar när man dividerar integrar
            // 3 finns två gånger (3 * 2 = 6) i 7 med 1 kvar

            // Resultatet är 1.
            int mod = a % b;

            Console.WriteLine(div);
            Console.WriteLine(mod);
        }
    }
}
