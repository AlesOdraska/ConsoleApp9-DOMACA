using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Vetvicka 
    {
        public double radius;
        public double vyska;


        public Vetvicka(double radius, double vyska)
        {
            this.radius = radius;
            this.vyska = vyska;
  
        }
        public virtual double Volume
        {
            get { return Math.PI * Math.Pow(radius, 2) * vyska; }
        }

    }
        
   
}
