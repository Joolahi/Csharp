using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace T11_CD
{
    class CD
    {
        public string albumName { get; set; }
        public string artistName { get; set; }
        public string genre { get; set; }
        public List<string> songs = new List<string>();
        public double prize { get; set; }
        public int published { get; set; }
        public void SongName(string song)
        {
            songs.Add("Name: " + song);
        }
        public string PrintSongs()
        {
            string results = "";
            foreach (string songName in songs)
            {
                results += " ---" + songName + "\n";
            }
            return results;

        }
       

    
    }
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            cd.albumName = "Vahtikoiran vapaapäivä";
            cd.artistName = "Tuija Rantalainen";
            cd.prize = 10.99;
            cd.genre = "Kids songs";
            cd.published = 2010;
            cd.SongName("Vahtikoiran vapaapäivä");
            cd.SongName("Sutinaa tutinaa kutinaa");
            cd.SongName("Ihmeellinen maa");
            cd.SongName("Mandi Merihevonen");
            cd.SongName("Mersuelefantit");
            cd.SongName("Eläinvauvoja");
            cd.SongName("Korkkis");
            cd.SongName("Pullakeisari");
            cd.SongName("Elokuvasuudelma");
            cd.SongName("Nuku nuku");
            cd.SongName("Taivaan alla");
            cd.SongName("Katulaulu");
            cd.SongName("Iltalaulu");

            Console.WriteLine($"CD:\n -Artist: {cd.artistName}\n -Album Name: {cd.albumName}\n -Genre: {cd.genre}\n -Price: {cd.prize}\n -Published: {cd.published}");
            Console.WriteLine(cd.PrintSongs());
   

        }
    }
}


