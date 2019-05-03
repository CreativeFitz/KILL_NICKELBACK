using System;
using System.Collections.Generic;

namespace Chapter8_KillNickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string,string>> goodSongs = new List<Dictionary<string, string>>();
            Dictionary<string, string> kryptonite = new Dictionary<string, string>(){
                {"3 Doors Down", "Kryptonite"}
            };
            Dictionary<string, string> photograph = new Dictionary<string, string>(){
                {"Nickelback", "Photograph"}
            };
            Dictionary<string, string> animals = new Dictionary<string, string>(){
                {"Nickelback", "Animals"}
            };
            Dictionary<string, string> composure = new Dictionary<string, string>(){
                {"August Burns Red", "Composure"}
            };

            HashSet<Dictionary<string, string>> allSongs = new HashSet<Dictionary<string, string>>();
            allSongs.Add(kryptonite);
            allSongs.Add(photograph);
            allSongs.Add(animals);
            allSongs.Add(composure);

            foreach(Dictionary<string, string> songBook in allSongs){
                foreach(KeyValuePair<string, string> song in songBook){
                    if(song.Key != "Nickelback"){
                        goodSongs.Add(songBook);
                    }
                }

            };

            foreach(Dictionary<string, string> songBook in goodSongs){
                foreach(KeyValuePair<string, string> song in songBook){
                    Console.WriteLine($"{song.Key}:{song.Value}");
                }
            }

        }
    }
}
