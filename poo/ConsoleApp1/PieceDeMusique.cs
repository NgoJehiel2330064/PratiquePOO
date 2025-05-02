using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Niveau
    {
        Facile,
        Moyen,
        Difficile
    };
    public class PieceDeMusique
    {
        public List<string> Nom { get; set; }
        public Niveau Niveau { get; set; }
        public int Experience { get; set; }
        public int NiveauMinimum { get; set; }
        public int Prix { get; set; }



        public PieceDeMusique(Niveau niveau, string nom = "Amanda")
        {
            Random random = new Random();
            int aleatoire = random.Next(0, 3);

            Nom = new List<string> {  "Clair de Lune – Debussy",
    "Für Elise – Beethoven",
    "Bohemian Rhapsody – Queen",
    "Nocturne Op. 9 No. 2 – Chopin",
    "Imagine – John Lennon",
    "Canon in D – Pachelbel",
    "The Four Seasons: Spring – Vivaldi",
    "Smells Like Teen Spirit – Nirvana",
    "Gymnopédie No. 1 – Satie",
    "Yesterday – The Beatles",
    "Moonlight Sonata – Beethoven",
    "Take Five – Dave Brubeck",
    "Symphony No. 5 – Beethoven",
    "Let It Be – The Beatles",
    "La vie en rose – Édith Piaf",
    "Rhapsody in Blue – Gershwin",
    "Hallelujah – Leonard Cohen",
    "Requiem: Lacrimosa – Mozart",
    "Carmen: Habanera – Bizet",
    "Hotel California – Eagles",
    "The Sound of Silence – Simon & Garfunkel",
    "Eine kleine Nachtmusik – Mozart",
    "Bridge Over Troubled Water – Simon & Garfunkel",
    "Toccata and Fugue in D minor – Bach",
    "Stairway to Heaven – Led Zeppelin",
    "Rêverie – Debussy",
    "Boléro – Ravel",
    "Wish You Were Here – Pink Floyd",
    "Ode to Joy – Beethoven",
    "Adagio for Strings – Barber" };
            Niveau = niveau;
            if (Niveau == Niveau.Facile)
            {
                Experience = random.Next(10, 31);
                Prix = 200;
                NiveauMinimum = 1;
            }
            else if (Niveau == Niveau.Moyen)
            {
                Experience = random.Next(60, 81);
                Prix = 400;
                NiveauMinimum = random.Next(2, 4);
            }
            else
            {
                Experience = random.Next(100, 151);
                Prix = 600;
                NiveauMinimum = random.Next(4, 6);
            }
        }

        public PieceDeMusique()
        {
            Random random = new Random();
            int aleatoire = random.Next(0, 3);

            Nom = new List<string> {  "Clair de Lune – Debussy",
    "Für Elise – Beethoven",
    "Bohemian Rhapsody – Queen",
    "Nocturne Op. 9 No. 2 – Chopin",
    "Imagine – John Lennon",
    "Canon in D – Pachelbel",
    "The Four Seasons: Spring – Vivaldi",
    "Smells Like Teen Spirit – Nirvana",
    "Gymnopédie No. 1 – Satie",
    "Yesterday – The Beatles",
    "Moonlight Sonata – Beethoven",
    "Take Five – Dave Brubeck",
    "Symphony No. 5 – Beethoven",
    "Let It Be – The Beatles",
    "La vie en rose – Édith Piaf",
    "Rhapsody in Blue – Gershwin",
    "Hallelujah – Leonard Cohen",
    "Requiem: Lacrimosa – Mozart",
    "Carmen: Habanera – Bizet",
    "Hotel California – Eagles",
    "The Sound of Silence – Simon & Garfunkel",
    "Eine kleine Nachtmusik – Mozart",
    "Bridge Over Troubled Water – Simon & Garfunkel",
    "Toccata and Fugue in D minor – Bach",
    "Stairway to Heaven – Led Zeppelin",
    "Rêverie – Debussy",
    "Boléro – Ravel",
    "Wish You Were Here – Pink Floyd",
    "Ode to Joy – Beethoven",
    "Adagio for Strings – Barber" };
            switch (aleatoire)
            {
                case 0:
                    Niveau = Niveau.Facile;
                    break;
                case 1:
                    Niveau = Niveau.Moyen;
                    break;
                case 2:
                    Niveau = Niveau.Difficile;
                    break;
            }

            if (Niveau == Niveau.Facile)
            {
                Experience = random.Next(10, 31);
                Prix = 200;
                NiveauMinimum = 1;
            }
            else if (Niveau == Niveau.Moyen)
            {
                Experience = random.Next(60, 81);
                Prix = 400;
                NiveauMinimum = random.Next(2, 4);
            }
            else
            {
                Experience = random.Next(100, 151);
                Prix = 600;
                NiveauMinimum = random.Next(4, 6);
            }
        }
    }
}
