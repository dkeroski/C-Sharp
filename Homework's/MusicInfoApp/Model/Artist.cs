using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Artist
    {
        public string Name { get; set; }
        public int IDArtist { get; set; }

        public static List<Artist> GetAllArtists()
        {
            List<Artist> artistList = new List<Artist>()
        {
            new Artist { IDArtist = 1,   Name="Tose Proeski"},
            new Artist { IDArtist = 2 , Name="Vlado Janeski"},
            new Artist { IDArtist = 3 , Name = "Karolina Goceva"},
    
        };
            return artistList;
        }
    }

   
}
