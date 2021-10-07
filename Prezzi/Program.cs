using System;

namespace Prezzi
{
    class Prezzi
    {
        //attibuti
        double prezzi;
        

        //costruttore
        public Prezzi(double prezzi)
        {
            this.prezzi = prezzi;
            
            
        }
        //metodi

        public void setPrezzo()
        {
            try
            {
                do
                {
                    Console.Write("Inserisci il prezzo cellulare in modo che sia maggiore di 0");
                    prezzi = Convert.ToDouble(Console.ReadLine());
                } while (prezzi <= 0);
            }
            catch
            {
                Console.Write("Inserisci valore valido");
            }
        }

        public void controlloPrezzo()
        {
            if (prezzi > 100)
            {
                Console.WriteLine("Questo prezzo è maggiore di 100 euro, infatti è di: {0} euro", prezzi);
            }
            else
            {

            }
                
            
        }


        static void Main(string[] args)
        {
            int n, pz = 0;
            Prezzi p = new Prezzi(pz);
            Console.WriteLine("Quanti prezzi vuoi inserire?");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                p.setPrezzo();
                p.controlloPrezzo();

            }

        }
    }
}
