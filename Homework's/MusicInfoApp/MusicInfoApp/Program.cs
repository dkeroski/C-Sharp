using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = from list1 in Artist.GetAllArtists()
                         join list2 in Album.GetAllAlbums() on list1.IDArtist equals list2.IDArtist
                         select new { list1.Name, list2.AlbumName, list2.Year, list2.IDAlbum } into intermediate
                         join list3 in Songs.GetAllSongs() on intermediate.IDAlbum equals list3.IDAlbum
                         select new
                         {
                             ArtistName = intermediate.Name,
                             ArtistAlbum =intermediate.AlbumName,
                             AlbumYear = intermediate.Year,
                             Songs = list3.Name,
                             SongsDuration = list3.Duration
                         };

            //foreach (var item in result)
            //{
            //   Console.WriteLine("Artist :" + item.ArtistName + "\n \n " + "Albums :"  + item.ArtistAlbum + "\n " + "\t" + "Year :" + item.AlbumYear + "\n \t " + "Songs : " + item.Songs +  "\t" +"Duration :" + item.SongsDuration);
            //}
            //Console.ReadLine();



            //// Artist long name
            //var artistLongName =result.OrderByDescending(s => s.ArtistName.Length).First();
            //Console.WriteLine("The longest name is: {0}" , artistLongName.ArtistName);
            //Console.ReadLine();


            ////first artist album
            //var firstArtistAlbum = result.OrderBy(s => s.AlbumYear).First();
            //Console.WriteLine("First Album is: {0} ,artist:{2} in year:{1}" ,firstArtistAlbum.ArtistAlbum, firstArtistAlbum.AlbumYear , firstArtistAlbum.ArtistName);
            //Console.ReadLine();

            ////last album
            //var lastArtistAlbum = result.OrderByDescending(s => s.AlbumYear).First();
            //Console.WriteLine("Last Album is: {0} ,artist:{2} in year:{1}", lastArtistAlbum.ArtistAlbum, lastArtistAlbum.AlbumYear, lastArtistAlbum.ArtistName);
            //Console.ReadLine();

            ////longest song
            //var longSong = result.Select(x => x.SongsDuration).Max();
            //Console.WriteLine("The long song is {0} " ,longSong);
            //Console.ReadLine();


            //longest album duration
            var longestAlbum = from x in result
                               group x by x.ArtistAlbum into grAlb
                               select new
                               {
                                   Name = grAlb.Key,
                                   SumDur = grAlb.Sum(p => p.SongsDuration),

                               };

            foreach (var item in longestAlbum)
            {
               
                Console.WriteLine("Longest Album is {0} , duration : {1}" , item.Name , item.SumDur);
            }

            Console.ReadLine();
        }
    }
}
