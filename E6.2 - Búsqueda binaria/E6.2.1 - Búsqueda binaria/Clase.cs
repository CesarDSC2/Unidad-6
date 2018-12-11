using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace E6._2._1___Búsqueda_binaria
{
    class Clase
    {
        public void Play0()
        {
            x:
            Console.Clear();
            int opc;
            Console.Write("Ejecutar:\n1.-Programa 1.\n2.-Programa 2.\n3.-Salir.\nOpción: ");
            opc = int.Parse(Console.ReadLine());
            switch (opc) //Menú con "Switch-case".
            {
                case 1:
                    Play(); //Llama al método que se encuentra en esta clase.
                    goto x;
                    
                case 2:
                    Console.WriteLine("¡Se ha generado un vector aleatorio!");
                    Play2(); //
                    goto x;
                case 3:
                    Console.Write("Presione enter...");
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida");
                    Console.ReadKey();
                    goto x;
                    
            }                        
        }
        public void Play()
        {
            int[] array = new int[] { 0, 1, 2, 7, 15, 90, 122 }; //Creamos un arreglo ya definido.
            Proceso obj = new Proceso(); //Instancia de la clase Proceso.
            x: //Marca
            Console.Clear();
            Console.Write("¿Qué valor desea buscar? \nIngrese (00) para salir\nIngrese (01) para desplegar los elementos del arreglo\nOpción: ");
            string opc = Console.ReadLine();
            if (opc == "00") //Mini-menú con "If"
            {
                Console.WriteLine("Presione enter para salir.");
            }
            else if (opc == "01")
            {
                foreach (var item in array)
                {
                    Console.Write("({0})", item);                                      
                }
                Console.ReadKey();
                goto x;
            }
            else
            {
                obj.BBinaria(array, int.Parse(opc)); //Llamará al método enviando como parámetros el array y el item a buscar ingresado por el usuario.
                Console.ReadKey();
                goto x; //Referencia a la marca.
            }
        }
        public void Play2()
        {
            int[] array = new int[10]; //Creamos el Array con capacidad de 10 elementos.
            Random random = new Random(); //Instanciamos un objeto de la clase Random.
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 100); //Asignamos un número aleatorio entre 0 y 100.
            }
            Array.Sort(array); //Método de la clase Array para ordenar los elementos del array en forma ascendente. Lo cual es necesario para poder ejecutar la búsqueda binaria.
            Proceso obj = new Proceso();
            x:
            Console.Clear();
            Console.Write("¿Qué valor desea buscar? \nIngrese (00) para salir\nIngrese (01) para ver los elementos generados aleatoriamente\nOpción: ");
            string opc = Console.ReadLine();
            if (opc == "00")
            {
                Console.WriteLine("Presione enter para salir.");
            }
            else if (opc == "01")
            {
                foreach (var item in array)
                {
                    Console.Write("({0})", item);
                }
                Console.ReadKey();
                goto x;
            }
            else
            {
                obj.BBinaria(array, int.Parse(opc));
                Console.ReadKey();
                goto x;
            }
            Console.ReadKey();
        }
        
    }
}
