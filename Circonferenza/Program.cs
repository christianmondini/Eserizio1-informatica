using System;

namespace Circonferenza
{
    class Circonferenza
    {
        //attributi:
        double r;
        double a;
        double d;
        double c;

        //costruttore
        public Circonferenza()
        {
            r = 0;
            a = 0;
            d = 0;
            c = 0;
        }

        public void leggiDati()
        {
           

            do
            {
                Console.WriteLine("Inserisci il valore del raggio, deve essere maggiore di 0");
                try
                {
                    r = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Inserisci un valore numerico");
                }
            } while (r <= 0);
                
        }

        public void calcoloDiametro()
        {
            d = r * 2;
            Console.WriteLine("Il diametro è {0}",d);
        }

        public void calcoloCirconferenza()
        {
            c = d * Math.PI;
            Console.WriteLine("Il perimetro equivale a {0}", c);
        }

        public void calcoloArea()
        {
            a = (r * r) * Math.PI;
            Console.WriteLine("L'area equivale a {0}", a);
        }

        static void Main(string[] args)
        {
            Circonferenza c = new Circonferenza();
            c.leggiDati();
            c.calcoloDiametro();
            c.calcoloArea();
            c.calcoloCirconferenza();
        }
    }
}
