﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MangaCollectionLibrary
{
    public class MangaVolumeInfo 
    {
        public static Dictionary<int, string> MangaDemographicChoice = new Dictionary<int, string>()
        {
            { 1, "Shonen" },
            { 2, "Seinen" },
            { 3, "Shojo" },
            { 4, "Josei" }

        };
       // Demographic mangaDemographic;
        //use a switch 
        public string MangaName { get; set; }
        public string MangaSeries { get; set; }
        public string MangaMagazine { get; set; }
        public List<string> Genre { get; set; }
        public string Demographic { get; set; }


        //public void GetDemographic()
        //{
        //    int userInput = int.Parse(Console.ReadLine());
        //    mangaDemographic = (Demographic)userInput;


        //}
        //public void GetMangaNameByUserInput()
        //{
        //    Console.WriteLine("What is the title of the Manga Volume?: ");
        //    string userInput = Console.ReadLine();
        //    this.MangaName = userInput;
        //    GetMangaMagazineByUserInput();
        //}
        //public void GetMangaMagazineByUserInput()
        //{
        //    Console.WriteLine("What magazine was this Manga published in?: ");
        //    string userInput = Console.ReadLine();
        //    this.MangaMagazine = userInput;
        //    GetGenreByUserInput();
        //}
        //public void GetGenreByUserInput()
        //{
        //    Console.WriteLine("What Genre is this Manga?: ");
        //    string userInput = Console.ReadLine();
        //    this.Genre = userInput;
        //    Console.WriteLine("Does this have another Genre? Y/N: ");
        //    string yesOrNoInput = Console.ReadLine().ToUpper();

        //    if(yesOrNoInput == "Y")
        //    {
        //        GetGenreByUserInput();
        //    }
            

            

        
    }
}
