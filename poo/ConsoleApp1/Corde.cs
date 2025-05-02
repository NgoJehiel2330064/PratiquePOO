using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Corde
    {
        public int Resistance { get; set; }
        public int Durabilite { get; set; }

        public Corde() 
        {
            Random random = new Random();
            Resistance = random.Next(1, 10);
            Durabilite = Resistance * 2;
        }

    
    }
}
