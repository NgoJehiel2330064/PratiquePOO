using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class Violon : Instrument
    {

        public Violon() : base() { NombresDeCorde = 4; }

        public override string ModifierNom()
        {
            Random random = new Random();
            int aleatoire = random.Next(1, 5);

            switch (aleatoire)
            {
                case 1:
                   Nom += " " + "Guarnerim";
                    break;
                case 2:
                    Nom += " " + "Stradivarius";
                    break;
                case 3:
                    Nom += " " + "Amati";
                    break;
                case 4:
                    Nom += " " + "Giuseppe";
                    break;
            }

            return Nom;
        }
    }
}
