using System;
using System.Collections.Generic;
using System.Text;

namespace MangaCollectionLibrary
{
    public class MangaVolumeInfo 
    {
        Genre mangaGenre;
        //use a switch 
        public void Blergh()
        {
            int userInput = int.Parse(Console.ReadLine());
            mangaGenre = (Genre)userInput;


        }
    }
}
