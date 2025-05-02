using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Instrument
    {
        public string Nom {  get; set; }
        public int PrixAchat { get; set; }
        public Corde Corde { get; set; }
        public  int NombresDeCorde { get; set; }

        public Instrument (string nom = "Best")
        {
            Nom = nom;
            PrixAchat = Corde.Resistance * 200;
        }
   
        public static bool operator >(Instrument i1, Instrument i2)
        {
            return i1.Corde.Resistance <= i2.Corde.Resistance;
        }

        public static bool operator <(Instrument i1, Instrument i2)
        {
            return i1.Corde.Resistance >= i2.Corde.Resistance;
        }

        public virtual string ModifierNom()
        {
            return Nom;
        }
    }
}
