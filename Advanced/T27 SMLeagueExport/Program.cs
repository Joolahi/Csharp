using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T27_SMLeagueExport
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GameLocation { get; set; }
        public int Number { get; set; }
    }
    class Team
    {
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public List<Player> Players { get; set; }

        public Team(string name)
        {
            Name = name;
            HomeTown = HomeTown;
            Players = new List<Player>();
            switch (name)
            {
                case "Lukko":
                    HomeTown = "Rauma";
                    Players.Add(new Player { FirstName = "Otto", LastName = "Somppi", GameLocation = "Center forward", Number = 24 });
                    Players.Add(new Player { FirstName = "Kim", LastName = "Nieminen", GameLocation = "Left forward", Number = 93 });
                    Players.Add(new Player { FirstName = "Kalle", LastName = "Ervasti", GameLocation = "Right defender", Number = 71 });
                    Players.Add(new Player { FirstName = "Julius", LastName = "Mattila", GameLocation = "Center forward", Number = 63 });

                    break;

                case "Tappara":
                    HomeTown = "Tampere";
                    Players.Add(new Player { FirstName = "Jori", LastName = "Lehterä", GameLocation = "Center forward", Number = 21 });
                    Players.Add(new Player { FirstName = "Christian", LastName = "Heljanko", GameLocation = "Goalie", Number = 30 });
                    Players.Add(new Player { FirstName = "Veli-Matti", LastName = "Viitasmäki", GameLocation = "Left defender", Number = 33 });
                    Players.Add(new Player { FirstName = "Petteri", LastName = "Puhakka", GameLocation = "Left forward", Number = 91 });

                    break;

                case "Pelicans":
                    HomeTown = "Lahti";
                    Players.Add(new Player { FirstName = "Jaakko", LastName = "Rissanen", GameLocation = "Center forward", Number = 28 });
                    Players.Add(new Player { FirstName = "Lasse", LastName = "Lappalainen", GameLocation = "Right defender", Number = 55 });
                    Players.Add(new Player { FirstName = "Joona", LastName = "Riekkinen", GameLocation = "Left defender", Number = 9 });
                    Players.Add(new Player { FirstName = "Robin", LastName = "Rahm", GameLocation = "Goalie", Number = 30 });

                    break;

                case "HIFK":
                    HomeTown = "Helsinki";
                    Players.Add(new Player { FirstName = "Roope", LastName = "Taponen", GameLocation = "Goalie", Number = 30 });
                    Players.Add(new Player { FirstName = "Kristian", LastName = "Vesalainen", GameLocation = "Left forward", Number = 10 });
                    Players.Add(new Player { FirstName = "Victor", LastName = "Berglund", GameLocation = "Right defender", Number = 62 });
                    Players.Add(new Player { FirstName = "Otto", LastName = "Paajanen", GameLocation = "Center forward", Number = 13 });
                    break;

                default:
                    Console.WriteLine("Team does not exist.");
                    break;


            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            while (true)
            {
                Console.WriteLine("Write an option:");
                Console.WriteLine("add (for adding teams)");
                Console.WriteLine("delete (for deleting team in list)");
                Console.WriteLine("show players (for showing all players and teams that exist in list)");
                Console.WriteLine("exit (to exiting program)");
                Console.WriteLine("save (to save infos in csv file");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "add":
                        Console.WriteLine("Enter team name: ");
                        string inputName = Console.ReadLine();
                        teams.Add(new Team(inputName));
                        Console.WriteLine("Team added.");
                        break;

                    case "delete":
                        Console.WriteLine("Enter team name: ");
                        string deleteName = Console.ReadLine();
                        teams.RemoveAll(removedTeam => removedTeam.Name == deleteName);
                        Console.WriteLine("Team removed.");
                        break;


                    case "exit":
                        Environment.Exit(0);
                        break;

                    case "save":
                        Console.WriteLine("Enter the name of the team you want to save: ");
                        string teamName = Console.ReadLine();
                        Team team = teams.FirstOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));
                        if (team == null)
                        {
                            Console.WriteLine("Team  not found.");
                            break;
                        }

                        string filename = teamName;                      
                        string filepath = $"{filename}.csv";
                        using (var writer = new StreamWriter(filepath))
                        {
                      
                            foreach (var player in team.Players)
                            {
                                writer.WriteLine($"{player.FirstName};{player.LastName};{player.GameLocation};{player.Number}");
                            }
                        }

                        Console.WriteLine($"Team {teamName} saved in {filepath}");
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
