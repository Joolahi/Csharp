using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_NewCD
{
    class Song
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public Song(string name, int length)
        {
            Name = name;
            Length = length;
        }

        public override string ToString()
        {
            int minutes = Length / 60;
            int seconds = Length % 60;
            return $"{Name} ({minutes}:{seconds})";
        }
    }
        class CD
        {
            public string AlbumName { get; set; }
            public string ArtistName { get; set; }
            public string Genre { get; set; }
            public List<Song> Songs { get; set; }
            public double Prize { get; set; }
            public int Published { get; set; }


            public CD(string albumName, string artistName, string genre, double prize, int published, List<Song> songs)
            {
                AlbumName = albumName;
                ArtistName = artistName;
                Genre = genre;
                Prize = prize;
                Published = published;
                Songs = songs;
            }
            public int NumberOfSongs
            {
                get { return Songs.Count; }
            }

            public int TotalLength
            {
                get
                {
                    int sum = 0;
                    foreach (Song song in Songs)
                    {
                        sum += song.Length;
                    }
                    return sum;
                }

            }

            public override string ToString()
            {
                string result = $"CD:\n -Artist: {ArtistName}\n -Album Name: {AlbumName}\n -Genre: {Genre}\n -Price: {Prize}\n -Published: {Published}\n -Number of Songs: {NumberOfSongs}\n -Total Length: {TotalLength / 60}:{TotalLength % 60:D2}\n -Songs:\n";
                foreach (Song song in Songs) 
                {
                    result += $" -{song.ToString()}\n";
                }
                return result ;
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Vahtikoiran vapaapäivä", 184);
            Song song2 = new Song("Sutinaa tutinaa kutinaa", 162);
            Song song3 = new Song("Ihmeellinen maa", 223);
            Song song4 = new Song("Mandi Merihevonen", 261);
            Song song5 = new Song("Mersuelefantit", 156);
            Song song6 = new Song("Eläinvauvoja", 134);
            Song song7 = new Song("Korkkis", 120);
            Song song8 = new Song("Pullakeisari", 100);
            Song song9 = new Song("Elokuvasuudelma", 194);
            Song song10 = new Song("Nuku nuku", 85);
            Song song11 = new Song("Taivaan alla", 142);
            Song song12 = new Song("Katulaulu", 130);
            Song song13 = new Song("Iltalaulu", 261);

            List<Song> songs = new List<Song>();
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);
            songs.Add(song5);
            songs.Add(song6);
            songs.Add(song7);
            songs.Add(song8);
            songs.Add(song9);
            songs.Add(song10);
            songs.Add(song11);
            songs.Add(song12);
            songs.Add(song13);

            CD cd = new CD("Vahtikoiran vapaapäivä" , "Tuija Rantalainen", "Kids songs", 10.99, 2010, songs);

            Console.WriteLine($"CD:\n -Artist: {cd.ArtistName}\n -Album Name: {cd.AlbumName}\n -Genre: {cd.Genre}\n -Price: {cd.Prize}\n -Published: {cd.Published}\n -Number of songs: {cd.NumberOfSongs}\n -Total length: {cd.TotalLength / 60}:{cd.TotalLength % 60:00}");
            Console.WriteLine("Songs:");
            foreach (Song song in songs)
            {
                Console.WriteLine($" -{song.Name}, {song.Length / 60}:{song.Length % 60}");
            }


        }
    }
}

