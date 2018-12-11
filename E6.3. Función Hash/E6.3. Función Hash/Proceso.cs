using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6._3.Función_Hash
{
    class Proceso
    {
        public string[] array; 
        public Proceso()
        {
            array = new string[10]; //Asignaremos al vector un tamaño de 10 ranuras.
            for (int i = 0; i < array.Length; i++) //A través de un "For" llenaremos los espacios.
            {
                array[i] = "-1"; //Simplemente inicializamos cada ranura con valor de "-1".
            }
        }
        public void Hash(string[] clave) //Recibe como parámetro el array.
        {
            for (int i = 0; i < clave.Length; i++)
            {
                string item = clave[i];
                int indice = int.Parse(item) % 7;//De esta manera se obtiene el valor Hash, que vendría siendo el nuevo índice que tendrá el item. Utilize 7 porque es el número primo más cercano al tamaño del array
                //Lo había puesto con el tamaño del array (10) y me devolvía los índices iguales a como están ingresados al crear el vector.
                Console.WriteLine("Elemento: {0} \t Indice: {1}", item, indice); //Despliega los nuevos índices de cada elemento.
                while (array[indice] != "-1") //Mientras el indice en el arreglo sea diferente a "-1". Aquí vamos a comparar de igual manera que los índices no sean iguales, para que no existan dos elementos en la misma ranura.
                {
                    indice++; //Aumentamos el índice en 1.
                    Console.WriteLine("Ocurrió una colisión en el índice {0}, se cambiará al índice {1}", indice - 1, indice); 
                    indice %= 10; //El nuevo índice será igual a (indice / tamaño del array), (residuo * tamaño del array), índice - multiplicación realizada = resultado (es decir, nuevo índice)
                }
                array[indice] = item;
            }
            
        }
        public void Desplegar()
        {
            Console.WriteLine("-    -   -   -   -   -   -   -   -\nElemento\tIndice"); //Despliega el resultado final despues de solucionar cada colisión.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("  {0} \t   :\t {1}", array[i], i);
            }
        }
        public string Buscar(string item) //Creamos un método para buscar el elemento ingresado.
        {
            int indice = int.Parse(item) % 7;
            int cont = 0;
            while (array[indice] != "-1")
            {
                if (array[indice] == item)
                {
                    Console.WriteLine("El elemento {0} se encontró en el índice {1}", item, indice);
                    return array[indice];
                }
                indice++; //Aumentamos el indice en 1.
                indice = indice % 10;
                cont++; //Aumentamos el contador en 1.
                if (cont > 7) //Si el contador es mayor a 10 se detendrá.
                {
                    break; //Rompemos el ciclo.
                }
            }
            return null; //Se retorna un nulo.
        }
    }
}
