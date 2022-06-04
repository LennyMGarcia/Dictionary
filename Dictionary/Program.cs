using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //el diccionario tiene una clave y un valor
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            //rellenar el diccionario
            diccionario.Add("juan", 5);

            diccionario.Add("diandra", 48);

            diccionario["maria"] = 29;

            //para el foreach se necesita el keyvaluepair para ordenarlo por clave y valor
            foreach(KeyValuePair<string, int> persona in diccionario)
            {
                Console.WriteLine("nombre:  " + persona.Key + " edad: " + persona.Value);
            }



            
        }
    }
}
