using System;
using System.Linq;

namespace LINQ_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize an array of game objects with their titles, ESRB ratings, and genres
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("Cult of the Lamb", 'T', "Action-Adventure"),
                new Game("The Stanley Parable", 'T', "First Person Exploration"),
                new Game("Superliminal", 'E', "Puzzle"),
                new Game("Gone Home", 'M', "Adventure"),
                new Game("Portal", 'T', "Action-Adventure"),
                new Game("Killer Frequency", 'T', "Horror"),
                new Game("The Last Campfire", 'E', "Puzzle Adventure"),
                new Game("Metamorphosis", 'T', "Adventure"),
                new Game("Badland", 'E', "Action-Adventure"),
            };

            //LINQ to filter games with titles shorter than 9 characters
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            //output the filtered dhort game titles
            foreach(var game in shortGames)
            {
                Console.WriteLine(game);
            }


            //use LINQ to find the game minecraft and select its details
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            //display the details of minecraft if it exists
            Console.WriteLine(mineCraft.FirstOrDefault());

            //LINQ to find all games rated T
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            //output the titles of the T rated games
            Console.WriteLine("T Rated Games:");
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }

            //LINQ to find all games rated E that are Action games
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            //output the titles of the E rated action game
            Console.WriteLine("E Rated Action Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}