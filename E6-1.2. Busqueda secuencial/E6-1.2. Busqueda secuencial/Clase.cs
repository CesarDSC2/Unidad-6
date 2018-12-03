using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_1._2.Busqueda_secuencial
{
    class Clase
    {
        public void Play()
        {
            
            Console.Write("¿Cuántos alumnos són?: ");
            int cant = Convert.ToInt32(Console.ReadLine());
            int[] conjunto = new int[cant]; //Creamos un vector.
            Console.Clear();
            for (int j = 0; j < cant; j++)
            {
                Console.Write("Ingrese la calificación el alumno {0}: ", j+1); //Capturamos las calificaciones dentro del Vector.
                conjunto[j] = Convert.ToInt32(Console.ReadLine());
            }
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
