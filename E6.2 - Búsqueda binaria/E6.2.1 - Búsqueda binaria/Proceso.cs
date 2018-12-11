using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6._2._1___Búsqueda_binaria
{
    class Proceso
    {
        public void BBinaria(int[] array, int item)
        {

            int primero = 0, ultimo = (array.Length - 1); //Variables auxiliares.
            bool encontrado = false; //Creamos una bandera
            while (primero <= ultimo && encontrado == false) //Mientras el primero sea menor o igual al último y encontrado sea "False", entra al ciclo.
            {
                int central = (primero + ultimo) / 2; //Creamos una variable para determinar el centro de nuestra array.
                if (array[central] == item) //Desde un principio si resulta que nuestro central es igual al item que deseamos buscar, encontrado será "True" y termina el ciclo while.
                {

                    encontrado = true;
                }
                else
                {
                    if (item < array[central]) //Si no es "True" entonces si el item a buscar es menor al central, el último sera igual al central - 1, es decir, se recorre una posición menos.
                    {
                        ultimo = central - 1;

                    }
                    else
                    {
                        primero = central + 1; //El primero se recorre una posición más.
                    }

                }
                //Se repite hasta que se cumpla la condición o se terminen los valores y se determine "Falso".
            }
            if (encontrado == true)
            {
                Console.WriteLine("\n(" + item + ") si se encuentra, en la posición:" + "[" + array.ToList().IndexOf(item) + "].");
            }
            else
            {
                Console.WriteLine("\n(" + item + ") no se encuentra.");
            }
        }
    }
}
