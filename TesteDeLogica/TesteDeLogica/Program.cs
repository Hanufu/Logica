using System;

namespace TesteDeLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio I\n");
            Exercicios.Exercicio_01(5);
            Console.WriteLine("\n---------------------------------");


            Console.WriteLine("\nExercicio II\n");
            int[] array = { 3, 8, 50, 5, 1, 18, 121, 122, 125, 131, 133, 34, 51, 41, 40 };
            Exercicios.Exercicio_02(array);
            Console.WriteLine("\n---------------------------------");


            Console.WriteLine("\nExercicio III\n");
            int[] numeros = { 1, 2, 3 };
            Exercicios.Exercicio_03(numeros);


        }
    }
}