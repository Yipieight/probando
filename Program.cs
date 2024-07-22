using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hola como = new Hola("Jose");
            como.imprimir();
        }

        public class Hola{
            public static string hola {get; set;}

            hola(string hola){
                this.hola = hola;
            }            

            public void imprimir(){
                Console.WriteLine($"Hola como estas {this.hola}");
            }
        }
    }
}