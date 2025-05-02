using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Preference
    {
        Guitare,
        Violon
    };
    public class Musicien
    {
        public string Nom {  get; set; }
        public Preference Preference { get; set; }
        public int NiveauMusicien { get; set; }
        public int Argent { get; set; }
        public int Experience { get; set; }
        public PieceDeMusique PieceMusique { get; set; }

        public Musicien ()
        {
            Nom = "Jehiel";
            Preference = Preference.Guitare;
            NiveauMusicien = 1;
            Argent = 1000;
            Experience = 0;
            PieceMusique  = new PieceDeMusique (Niveau.Facile);            
        }

        public void ChangerNiveau(Musicien musicien)
        {          
            if (musicien.NiveauMusicien >= 1 && musicien.Experience >=  musicien.NiveauMusicien * 100)
                musicien.NiveauMusicien += 1;
        }

        public void GagnerExperience(PieceDeMusique piece)
        {

        }

        public override string ToString()
        {
            return $"Nom : {Nom} \n Niveau : {NiveauMusicien} \n Vous possedez : {Argent} $ \n Preference : {Preference.Guitare}";
        }
    }
}
