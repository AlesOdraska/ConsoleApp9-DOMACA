using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Baobab : Strom
    {

        public Baobab(double radius1, double vyska1) : base(radius1, vyska1)
        {
            radius = radius1;
            vyska = vyska1;
        }
        public override double Volume
        {
            get { return Math.PI * Math.Pow(radius, 2) * vyska; }
        }



    }
}
