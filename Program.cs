using System;
using System.Linq;

namespace LINQ_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("Cult of the Lamb", 'T', "Action-Adventure"),
                new Game("The Stanley Parable", 'NR', "First Person Exploration"),
                new Game("Superliminal", 'E', "Puzzle"),
                new Game("Gone Home", 'M', "Adventure"),
                new Game("Portal", 'T', "Action-Adventure"),
                new Game("Killer Frequency", 'T', "Horror"),
                new Game("The Last Campfire", 'E', "Puzzle Adventure"),
                new Game("Metamorphosis", 'T', "Adventure"),
                new Game("Badland", 'E', "Action-Adventure"),
            };

            var shortGames = from game in games;
        }
    }
}