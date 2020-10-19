using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibgeraete
{
    abstract class Schreibgeraet
    {
        public double Strichstärke { get; set; }
        public ConsoleColor Farbe { get; set; }
        public string Typ { get; set; }
        public Schreibgeraet(double Strichstärke)
        {
            this.Strichstärke = Strichstärke;
            Farbe = ConsoleColor.Black;
            Typ = "unbekannt";
        }
        public Schreibgeraet(double Strichstärke, ConsoleColor Farbe, string Typ)
        {
            this.Farbe = Farbe;
            this.Strichstärke = Strichstärke;
            this.Typ = Typ;
        }
        public void SchreibeText(string text, ConsoleColor Farbe)
        {
            Console.ForegroundColor = Farbe;
            Console.WriteLine($"(Typ: {this.Typ}, Farbe:{this.Farbe}, Strichstärke:{this.Strichstärke})schreibt: {text}");
        }
    }
}
