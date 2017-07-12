using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSong = new List<(string, string)>();
            HashSet<(string artist, string song)> allSongs = new HashSet<(string artist, string song)>();

            allSongs.Add(("Nickelback", "How You Remind Me"));
            allSongs.Add(("Nickelback", "Photograph"));
            allSongs.Add(("One", "Rockstar"));
            allSongs.Add(("Two", "Far Away"));
            allSongs.Add(("Three", "Too Bad"));
            allSongs.Add(("Four", "Someday"));
            allSongs.Add(("Nine", "Never Again"));

            foreach (var item in allSongs)
            {
                if(item.Item1 != "Nickelback")
                {
                    goodSong.Add(item);
                }
            }
            foreach (var item in goodSong)
            {
                Console.WriteLine($"{item.Item2} by {item.Item1}");
            }
        }
    }
}
