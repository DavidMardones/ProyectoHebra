using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoHebra
{
    internal class Program
    {
        static void ejecutar()
        {
            int i = Convert.ToInt32(Thread.CurrentThread.Name);
            Thread.Sleep(i * 2000);
            Console.WriteLine("Hola desde Hebra Nro. {0}", i);
        }

        static void ejecutarConParametro(object o)
        {
            int i = (int)o;
            Thread.Sleep(i * 1000);
            Console.WriteLine("Hola Hebra parametro {0}", i);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Hebra...");
            for (int i = 1; i < 7; i++)
            {
                //Thread t = new Thread(new ThreadStart(ejecutar));
                Thread t = new Thread(new ParameterizedThreadStart(ejecutarConParametro));
                t.Name = i.ToString();
                t.Start();
            }
            Console.WriteLine("Hebra iniciada: ");

            Console.ReadKey();


        }
    }
}

   
