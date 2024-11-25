using System;

namespace calculatrice
{
    class Program
    {
        static void Main()
        {
            string operateur;
            double n1, n2, result;
            Calculatrice calc = new();

            Console.WriteLine("Veuillez saisir l'opération souhaité (+, -, * ou /):");
            operateur = Console.ReadLine();

            Console.WriteLine("Veuillez saisir le premier nombre:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le second nombre:");
            n2 = int.Parse(Console.ReadLine());

            switch(operateur)
            {
                case "+":
                    result = calc.Addition(n1, n2);
                    break;
                case "-":
                    result = calc.Soustraction(n1, n2);
                    break;
                case "*":
                    result = calc.Multiplication(n1, n2);
                    break;
                case "/":
                    result = calc.Division(n1, n2);
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine("Le résultat de l'opération est " + result);
        }
    }
}
