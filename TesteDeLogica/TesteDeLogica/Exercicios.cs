using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    static class Exercicios
    {
        public static List<string> Exercicio_01(int n)
        {

            List<string> lista = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string asterico = new string('*', i);
                lista.Add(asterico);
            }

            //mostra resultado
            string listaCompleta = "[" + string.Join(",", lista) + "]";
            Console.WriteLine(listaCompleta);

            return lista;
        }

        public static List<(int, int)> Exercicio_02(int[] array)
        {

            Array.Sort(array);
            int menorDiferenca = int.MaxValue;

            //Encontra a menor diferença absoluta
            for (int i = 0; i < array.Length - 1; i++)
            {
                int diferenca = Math.Abs(array[i] - array[i + 1]);
                menorDiferenca = Math.Min(menorDiferenca, diferenca);
            }

            //Encontra todos os pares com a menor diferenlça
            List<(int, int)> pares = new List<(int, int)>();
            for (int i = 0; i < array.Length - 1; i++)
            {
                int diferenca = Math.Abs(array[i] - array[i + 1]);
                if (diferenca == menorDiferenca)
                    pares.Add((array[i], array[i + 1]));
            }

            //mostra resultado
            List<(int, int)> resultado = pares;
            foreach (var par in resultado)
            {
                Console.WriteLine($"({par.Item1}, {par.Item2})");
            }
            return pares;
        }

        public static List<List<int>> Exercicio_03(int[] array)
        {
            List<List<int>> result = new List<List<int>>();

            //Começa com um sobconjunto vazio
            result.Add(new List<int>());

            foreach (int item in array)
            {
                int count = result.Count;
                for (int i = 0; i < count; i++)
                {
                    List<int> subset = new List<int>(result[i]);
                    subset.Add(item);
                    result.Add(subset);
                }
            }

            //Mostra resultado
            List<List<int>> subsets = result;
            foreach (List<int> subset in subsets)
            {
                Console.WriteLine("[{0}]", string.Join(", ", subset));
            }
            return result;
        }
    }
}

