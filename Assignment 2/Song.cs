using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Song
    {
        public string BeerSong()
        {
            StringBuilder lyrics = new StringBuilder();

            //string lyrics = string.Empty;


            for (int index = 99; index > 0; index--)
            {
                //if (index == 0)//ahead when I use the variables
                // break; //determinated a block of code that is running

                StringBuilder line = new StringBuilder(); //append is like +=

                if (index != 1)
                {
                    if (index == 2)
                    {
                        line.AppendLine($"{index} bottles of beer on the wall, {index} bottles of beer.");
                        line.AppendLine($"Take one down and pass it around, {index - 1} bottle of beer on the wall.");

                    }
                    else
                    {
                        line.AppendLine($"{index} bottles of beer on the wall, {index} bottles of beer.");
                        line.AppendLine($"Take one down and pass it around, {index - 1} bottles of beer on the wall.");
                    }

                }
                else
                {
                    line.AppendLine($"{index} bottle of beer on the wall, {index} bottle of beer.");
                    line.AppendLine($"Take one down and pass it around, {index - 1} bottles of beer on the wall.");
                }
                lyrics.AppendLine(line.ToString());
                //lyrics += line + "\n";
            }
            return lyrics.ToString();
        }
    }
}
