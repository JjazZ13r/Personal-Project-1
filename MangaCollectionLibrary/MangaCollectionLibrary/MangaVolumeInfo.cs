using System;
using System.Collections.Generic;
using System.Text;

namespace MangaCollectionLibrary
{
    public class MangaVolumeInfo 
    {
        Demographic mangaDemographic;
        //use a switch 
        public string MangaName { get; set; }
        public string MangaMagazine { get; set; }
        public string Genre { get; set; }

        public void GetDemographic()
        {
            int userInput = int.Parse(Console.ReadLine());
            mangaDemographic = (Demographic)userInput;


        }
    }
}
