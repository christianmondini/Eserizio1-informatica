using System;

namespace Temperatura
{
    class Temperatura
    {
        //attributi
        int[] t = new int[1];
        int min,max;

        //costruttore
        public Temperatura(int[] t)
        {
            this.t= t;
            min = 9999;
            max = -9999;

        }

        //metodi
        public bool setTemp()
        {
            try
            {
                t[0] = Convert.ToInt32(Console.ReadLine());
                return true;
            }
            catch {
                return false;
            }

           
        }

        public int temperaturamaggiore()
        {
            if (max < t[0])
                max = t[0];
            return max;
        }

        public int temperaturaMinore()
        {
            if (min > t[0])
                min = t[0];
            return min;
        }

        static void Main(string[] args)
        {
            int n;
            int[] temp = new int[1];
            Temperatura t = new Temperatura(temp);

            Console.Write("Quante temperature vuoi inserire?");
            n =Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci la temperatura");
                t.setTemp();
                t.temperaturamaggiore();
                t.temperaturaMinore();

            }

            Console.Write("La temperatura massima è {0} ",t.temperaturamaggiore());
            Console.Write("La temperatura minima è {0} ",t.temperaturaMinore());
        }
    }
}
