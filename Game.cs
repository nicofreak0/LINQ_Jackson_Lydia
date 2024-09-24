using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Jackson_Lydia
{
    internal class Game
    {
        //property to store the title of the game
        public string Title { get; }

        //property to store the age rating of the game
        public char Esrb {  get; }

        //property to store the genre of the game
        public string Genre { get; }

        //constructor to initialize a new game object
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            // assigns the provided parameters to the properties
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }


    }
}
