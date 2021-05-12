using System;

namespace ExercicioSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            string letra = nome.Substring(0,1).ToUpper();

            Console.WriteLine();

            switch(letra){
                case "A":
                    Console.WriteLine("seu nome começa com a vogal "+letra+" de aranha!!!");
                break;
                case "E":
                    Console.WriteLine("seu nome começa com a vogal "+letra+" de elefante!!!");
                break;
                case "I":
                    Console.WriteLine("seu nome começa com a vogal "+letra+" de iguana!!!");
                break;
                case "O":
                    Console.WriteLine("seu nome começa com a vogal "+letra+" de onça!!!");
                break;
                case "U":
                    Console.WriteLine("seu nome começa com a vogal "+letra+" de urso!!!");
                break;
                default:
                    Console.WriteLine("Seu nome não começa com uma vogal :(");
                break;
            }
        }
    }
}
