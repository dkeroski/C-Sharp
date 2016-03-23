using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Album
    {
        public int IDArtist { get; set; }
        public string AlbumName { get; set; }
        public int Year { get; set; }
        public int IDAlbum { get; set; }

        public static List<Album> GetAllAlbums()
        {
            List<Album> albumList = new List<Album>()
            {
                new Album { IDArtist = 1 , AlbumName="Nekade vo nokta" ,Year = 1999 , IDAlbum = 1},
                new Album { IDArtist = 1 , AlbumName = "Den za nas" , Year = 2004 ,IDAlbum = 2},
                new Album { IDArtist = 1 , AlbumName = "Po tebe" , Year = 2002 ,IDAlbum = 3},
                new Album { IDArtist = 2 , AlbumName="Ima nesto posilno od se" ,Year= 2002 , IDAlbum=4},
                new Album { IDArtist = 2 , AlbumName="Daleku e neboto" , Year = 1996 , IDAlbum = 5},
                new Album { IDArtist = 2 , AlbumName="Vakov ili takov" , Year = 2004 , IDAlbum = 6},
                new Album { IDArtist = 3 , AlbumName = "Znaes kolku vredam" , Year= 2003 , IDAlbum = 7},
                new Album { IDArtist = 3 , AlbumName = "Makedonsko devojce" , Year=2008, IDAlbum = 8},
                new Album { IDArtist = 3 , AlbumName = "Najubavi pesni" , Year=2012 , IDAlbum = 9},
             

            };

            return albumList;
        }
            

    }

     
}
