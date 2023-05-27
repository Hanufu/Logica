using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    static class Exercicios
    {
    public static List<string> Exercicio_01(int n){

            List<string> lista = new List<string>();

            for(int i = 1; i <= n; i++) {
                string asterico = new string('*', i);
                lista.Add(asterico);
            }

            string listaCompleta = "[" + string.Join(",", lista) + "]";
            Console.WriteLine(listaCompleta);

            return lista;
        }
    }

  
}
