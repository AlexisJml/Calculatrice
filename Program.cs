using System;

namespace calculatrice
{
    class Program
    {
        static void Main()
        {
            string operateur;
            Calculatrice calc = new();

            Console.WriteLine("Veuillez saisir l'opération souhaité (+, -, *, / ou %):");
            operateur = Console.ReadLine();

            Console.WriteLine("Veuillez saisir le premier nombre:");
            calc.Setn1(int.Parse(Console.ReadLine()));

            Console.WriteLine("Veuillez saisir le second nombre:");
            calc.Setn2(int.Parse(Console.ReadLine()));

            switch(operateur)
            {
                case "+":
                    calc.Addition();
                    break;
                case "-":
                    calc.Soustraction();
                    break;
                case "*":
                    calc.Multiplication();
                    break;
                case "/":
                    calc.Division();
                    break;
                case "%":
                    calc.Modulo();
                    break;
                default:
                    Console.WriteLine("Opérateur non reconnu");
                    break;
            }

            Console.WriteLine("Le résultat de l'opération est " + calc.GetResultat());
        }
    }
}
