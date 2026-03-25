using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Ovo je drugi komentar.
    // Ovo je treci komentar.
    public class LengthConventer : IConvert
    {
        public double Convert(double value)
        {
            return Math.Round(value * 0.3048, 3);
        }
    }
}
