using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Gott
    {
        //Konstruktor
        static Gott() { }

        //Instanz
        static Gott Gottimperator = new Gott(); 

        //Methode für den Objektzugriff
        public static Gott erscheine()
        {
            return Gottimperator; 
        }

        public void sprich()
        {
            Console.WriteLine("DU SOLLST KEINE ANDEREN GÖTTER NEBEN MIR HABEN!");
            Console.ReadLine();
        }

    }
}
