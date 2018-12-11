using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6._3.Función_Hash
{
    class Clase
    {
        public void Play()
        {
            Proceso obj = new Proceso();
            string[] array = new string[10] { "30", "90", "45", "65", "84", "20", "155", "62", "80", "97" }; //Creamos nuestro vector con 10 valores definidos.
            
            obj.Hash(array); //Asignara la clave a cada elemento.
            x: //Marca.
            obj.Desplegar(); //Llama al método que despliega el elemento con su nueva clave.
            
            Console.Write("¿Qué elemento desea buscar?\nIngrese (00) para salir.\nOpción: ");
            string opc = Console.ReadLine();
            if (opc == "00") //Mini-menú con "if".
            {
                Console.WriteLine("Presione enter...");
            }
            else
            {
                string buscar = obj.Buscar(opc); //Variable tipo string en la cual llamamos al método buscar e imprime la respuesta sea true o false.
                if (buscar == null) //
                {
                    Console.WriteLine("No se encontró el elemento {0}", opc);
                }
                Console.ReadKey();
                Console.Clear();
                goto x; //Referencia de la marca.
            }
        }
    }
}
