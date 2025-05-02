using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Simulateur
    {
        public Instrument Instrument { get; set; }
        public Musicien Musicien { get; set; }
        private Instrument[] Instruments = new Instrument[5];

        public string AfficherInfoMusicien(Musicien musicien)
        {
            Console.WriteLine("Bienvenue à la Simulation");
            return musicien.ToString();
        }

        public Instrument[] GenererInstrument()
        {
            int nbInstrument = 5;

            for (int i = 0; i < nbInstrument; i++)
            {
                Random random = new Random();
                int aleatoire = random.Next(2);

                if (aleatoire == 0)
                    Instruments[i] = new Violon();
                else
                    Instruments[i] = new Guitare();
            }

            return Instruments;
        }


        public Instrument AfficherInstrument(Instrument[] instrument)
        {

            Instrument meilleur = instrument[0];

            for (int i = 1; i < instrument.Length; i++)
                if (instrument[i] > meilleur)
                    meilleur = instrument[i];

            return meilleur;
        }

        public void Pratiquer(PieceDeMusique piece)
        {
            Console.WriteLine(piece.Nom);

        }

        public void ReparerInstrument(Instrument instrument)
        {
            instrument.Corde.Durabilite = instrument.Corde.Resistance * 2;
        }

        public void AcheterNouvellePiece()
        {

        }
    
    }
}
