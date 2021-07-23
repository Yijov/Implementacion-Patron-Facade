using System;
using System.Collections.Generic;
using System.Text;

namespace HHRRSystem.IO
{
    class IOM
    {
        private static IOM instancia;
        private IOM() { }
        public static IOM getIO()
        {
            if (instancia == null)
            {
                instancia = new IOM();
            }
            return instancia;
        }

        public void emitir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public string capturar(string Pregunta)
        {
            Console.WriteLine(Pregunta);
            return Console.ReadLine();
        }
        public string Menu(string Mensaje, string menu1, string menu2)
        {
            Console.WriteLine(Mensaje);
            Console.WriteLine("[1] {0}  [2] {1}",  menu1, menu2);
            return Console.ReadLine();
        }


        public string Menu(string Mensaje, string menu1, string menu2, string menu3)
        {
            Console.WriteLine(Mensaje);
            Console.WriteLine("[1] {0}  [2] {1}  [3] {2}", menu1, menu2, menu3);
            return Console.ReadLine();
        }

        public string Menu(string Mensaje, string menu1, string menu2, string menu3, string menu4)
        {
            Console.WriteLine(Mensaje);
            Console.WriteLine("[1] {0}  [2] {1}  [3] {2}  [4] {3}", menu1, menu2, menu3, menu4);
            return Console.ReadLine();
        }
    }
}
