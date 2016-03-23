using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Songs
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int IDAlbum { get; set; }


        public static List<Songs> GetAllSongs()
        {
            List<Songs> songList = new List<Songs>()
        {
            new Songs { IDAlbum = 1, Name = "Tvoite baknezi na moite beli kosuli", Duration = 210 },
            new Songs { IDAlbum = 1, Name = "Eh da sum zlato", Duration = 180 },
            new Songs { IDAlbum = 1, Name = "Go molam neboto da mi te vrati", Duration = 198 },
            new Songs { IDAlbum = 2 , Name="Me sakas so zborovi" , Duration = 165},
            new Songs { IDAlbum = 2 , Name="Ima li den za nas" , Duration = 150},
            new Songs { IDAlbum = 2 , Name="Cija si" , Duration =212 },
            new Songs { IDAlbum = 3 , Name="Rani na usnite" , Duration =240 },
            new Songs { IDAlbum = 3 , Name="Po tebe" , Duration = 215},
            new Songs { IDAlbum = 3 , Name="Naj naj" , Duration = 205},
            new Songs { IDAlbum = 4 , Name="Srce Preku Neboto" , Duration = 189},
            new Songs { IDAlbum = 4 , Name="Nekogaš I Negde" , Duration = 175},
            new Songs { IDAlbum = 4 , Name="Evergrin" , Duration = 250},
            new Songs { IDAlbum = 5 , Name="10 Devojki" , Duration =212 },
            new Songs { IDAlbum = 5 , Name="Zborovi" , Duration = 185},
            new Songs { IDAlbum = 5 , Name="Kompas" , Duration =198 },
            new Songs { IDAlbum = 6 , Name="Lesno Ti E Da Me Ostaviš" , Duration =198 },
            new Songs { IDAlbum = 6 , Name="Dve Duši I Mesečina" , Duration =201 },
            new Songs { IDAlbum = 6 , Name="Ako Ne Te Sakam" , Duration = 152},
            new Songs { IDAlbum = 7 , Name="Stom Sakas" , Duration = 154},
            new Songs { IDAlbum = 7 , Name="Znaes kolku vredam" , Duration = 212},
            new Songs { IDAlbum = 7 , Name="Ljubovta e moja religija" , Duration = 260},
            new Songs { IDAlbum = 8 , Name="Za kogo?" , Duration =160 },
            new Songs { IDAlbum = 8 , Name="Ruža, ružica" , Duration =213 },
            new Songs { IDAlbum = 8 , Name="Ptico malečka" , Duration = 120},
            new Songs { IDAlbum = 9 , Name="Toj" , Duration = 152},
            new Songs { IDAlbum = 9 , Name="Prvi Mart" , Duration = 213},
            new Songs { IDAlbum = 9 , Name="Stom sakas" , Duration = 189},


        };
            return songList;
        }
    }
}
