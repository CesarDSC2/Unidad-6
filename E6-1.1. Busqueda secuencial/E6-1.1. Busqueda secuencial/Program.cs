using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_1._1.Busqueda_secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conjunto = { 1, 1, 2, 3, 5, 8, 13, 21 }; //Creamos un vector e inicializamos sus valores.
            Console.Write("Búsqueda:");
            int busqueda = Convert.ToInt32(Console.ReadLine());
            var salida = conjunto.Where(con => con == busqueda); //Utilizamos una expresión "Lambda" para buscar el elemento.
            int i = 1;
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~");
            foreach (var item in salida) //Con un foreach, el el elemento existe, lo despliega, si no, no imprime nada.
            {
                Console.WriteLine(i + ".-" + item.ToString());
                i++;
            }
            Console.ReadKey();
        }
    }
}