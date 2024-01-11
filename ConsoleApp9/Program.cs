using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        /*public static double objem(double radius, double vyska)
        {

            
            return (((radius * radius) * vyska * Math.PI) / 3);        
        }*/

        static void Main(string[] args)
        {
            /*double x = 0;
            for (int i = 0; i<4; i++)
            {
                Console.WriteLine("napis R");
                double.TryParse(Console.ReadLine(), out double r);
                Console.WriteLine("napis V");
                double.TryParse(Console.ReadLine(), out double v);

                Program.objem(r,v);
                x += Program.objem(r,v);
            }
            Console.WriteLine("celkovy ibjem");
            Console.WriteLine(x);
            Console.ReadLine();*/
            Listnaty listnaty = new Listnaty(10, 10);
            Console.WriteLine(listnaty.Volume);
            Baobab baobab = new Baobab(10, 10);
            Console.WriteLine(baobab.Volume);
            Ihlicnan ihlicnan = new Ihlicnan(10, 10);
            Console.WriteLine(ihlicnan.Volume);
            Console.ReadLine();
            Console.ReadLine();


        }
    }
}
