using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Strom
    {
        public double radius;
        public double vyska;
        public Strom(int radius1, int vyska1)
        {
            radius = radius1;
            vyska = vyska1;
        }
        public virtual double Volume
        {
            get { return Math.PI * Math.Pow(radius, 2) * vyska; }
        }
    }
}
