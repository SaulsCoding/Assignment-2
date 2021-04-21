using System;
using System.Text;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song drink = new Song();
            string displayBeerSong = drink.BeerSong();
            Console.WriteLine(displayBeerSong);
        }
    }
}
