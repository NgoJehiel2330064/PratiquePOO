using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum nomGuitare
    {
        Acoustique,
        Basse,
        Electrique
    };
    public class Guitare : Instrument
    {
        public Guitare () : base () { NombresDeCorde = 6; }

        public override string ModifierNom()
        {
            Random random = new Random();
            int aleatoire = random.Next(0, 3);
           switch(aleatoire)
            {
                case 0:
                    Nom += nomGuitare.Acoustique;
                    break;
                case 1:
                    Nom += nomGuitare.Basse;
                    break;
                case 2:
                    Nom += nomGuitare.Electrique;
                    break;
            }
            return Nom;          
        }


    }
}
