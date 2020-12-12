using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRFVideogames.Entities
{
    public class GameData
    {
        public string Name { get; set; }
        public double CopiesSold { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Multiplayer { get; set; }
        public double IGNRating { get; set; }
    }
}
