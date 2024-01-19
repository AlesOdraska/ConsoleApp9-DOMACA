using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Strom : Organizmus
    {
        public double radius;
        public double vyska;
        public double vek; //v rokoch
        
        public Strom()
        {  
            List<Vetvicka> vetva = new List<Vetvicka>();
            Vetvicka v1 = new Vetvicka(5, 7);
            vetva.Add(v1);
        }
        
        public virtual double Volume
        {
            get { return Math.PI * Math.Pow(radius, 2) * vyska; }
        }
        public virtual void Rastie(double vek, double cas, double prirastok) {
            if (vek > 2)
            {
                vyska += prirastok * cas;
            }
            else {
                Console.WriteLine("nerastie");
            }
                
        }
    }
}
