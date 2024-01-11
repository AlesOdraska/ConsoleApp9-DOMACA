using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Ihlicnan : Strom
    {
        public Ihlicnan(int radius1, int vyska1) : base(radius1, vyska1)
        {
            radius = radius1;
            vyska = vyska1;
        }
        public override double Volume
        {
            get { return 1.0 * Math.PI * Math.Pow(radius, 2) * vyska / 3.0; }
        }
    }
}
