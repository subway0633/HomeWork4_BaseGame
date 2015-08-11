using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class BallEventArgs : EventArgs
    {
        public double Angle { get; set; }

        public double Distance { get; set; }
    }
}