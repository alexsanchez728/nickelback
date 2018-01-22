using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nickelback
{
    class Program
    {
        static void Main(string[] args)
        {

            //Define a List, named goodSongs, that will hold instances of Song.
            var goodSongs = new List<Song>();

            //Define a HashSet, named allSongs, that contains 7 instances of Song.
            //Make sure that some of the songs are from the band Nickelback.
            var allSongs = new HashSet<Song>();
            allSongs.Add(new Song { Artist = "Nickleback", Name = "Figured You Out" });
            allSongs.Add(new Song { Artist = "The Who", Name = "Baba O'reily" });
            allSongs.Add(new Song { Artist = "Sufjan Stevens", Name = "Impossible Soul" });
            allSongs.Add(new Song { Artist = "Nickelback", Name = "How You Remind Me" });
            allSongs.Add(new Song { Artist = "Bahamas", Name = "All The Time" });
            allSongs.Add(new Song { Artist = "Iron and Wine", Name = "Time After Time" });
            allSongs.Add(new Song { Artist = "Nickelback", Name = "When We Stand Together" });

            //Once the set is populated with 7 instances, iterate over the set of songs, and check if the band name is "Nickelback".
            foreach (var song in allSongs)
            {
            //If the band is not Nickelback, then add it to the goodSongs list.
                if (song.Artist != "Nickleback")
                {
                    goodSongs.Add(song);
                }
            }

            //Use another foreach loop to print out all the good songs.
            foreach (var goodOne in goodSongs)
            {
                Console.WriteLine($"The song {goodOne.Name} is by {goodOne.Artist} and is NOT by Nickelback thus it is a good song");
            }
            Console.ReadKey();
        }
    }
}
