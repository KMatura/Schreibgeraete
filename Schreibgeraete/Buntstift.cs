using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibgeraete
{
    class Buntstift : Schreibgeraet
    {
        public Buntstift(ConsoleColor Farbe, double Strichstärke) : base(Strichstärke, Farbe, "Buntstift")
        {
            
        }
    }
}
