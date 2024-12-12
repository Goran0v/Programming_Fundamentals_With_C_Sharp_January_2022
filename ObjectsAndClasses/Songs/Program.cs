using System;
using System.Linq;
using System.Collections.Generic;

namespace Songs
{
    class Program
    {
        class Song
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] types = Console.ReadLine().Split('_');
                string type = types[0];
                string name = types[1];
                string time = types[2];
                Song song = new Song();
                song.Type = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
            string typeLine = Console.ReadLine();
            if (typeLine == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.Type == typeLine)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            //List<Song> filtered = songs.Where(s => s.Type == typeLine).ToList();

            //foreach (Song song in filtered)
            //{
            //    Console.WriteLine(song.Name);
            //}
        }
    }
}
