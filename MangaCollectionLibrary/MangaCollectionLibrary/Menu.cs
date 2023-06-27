using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MangaCollectionLibrary
{
    public class Menu
    {
        public MangaVolumeInfo NewVolume = new MangaVolumeInfo() { Genre = new List<string>() };

        public void MainMenu()
        {
            Console.Title = "Manga Collection Record";
            Console.WriteLine("1. Insert new Volume");
            Console.WriteLine("2. Search for Existing Volume");
            Console.WriteLine("3. List current library");
            int userInput;
            try
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.Clear();

                    GetMangaNameByUserInput();
                    GetMangaSeriesByUserInput();
                    GetMangaMagazineByUserInput();
                    GetGenreByUserInput();
                    GetMangaDemographic();
                    DisplayCollectedMangaAndCheckForModifications();
                    UploadFinalizedManga();
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                }
                else if (userInput == 3)
                {
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public void GetMangaNameByUserInput()
        {
            Console.WriteLine("What is the title of the Manga Volume?: ");
            string userInput = Console.ReadLine(); 
            NewVolume.MangaName= userInput;
        }
        public void GetMangaSeriesByUserInput()
        {
            Console.WriteLine("What series is this Manga in?: ");
            string userInput = Console.ReadLine();
            NewVolume.MangaSeries = userInput;
        }
        public void GetMangaMagazineByUserInput()
        {
            Console.WriteLine("What magazine was this Manga published in?: ");
            string userInput = Console.ReadLine();
            NewVolume.MangaMagazine = userInput;
        }
        public void GetGenreByUserInput()
        {
            Console.WriteLine("What Genre is this Manga?: ");
            string userInput = Console.ReadLine();
            NewVolume.Genre.Add(userInput);
            Console.WriteLine("Does this have another Genre? Y/N: ");
            string yesOrNoInput = Console.ReadLine().ToUpper();

            if (yesOrNoInput == "Y")
            {
                GetGenreByUserInput();
            }
        }
        public void GetMangaDemographic()
        {
            Console.WriteLine("What demographic is this volume? Input corresponding number: ");
            foreach (KeyValuePair<int, string> kvp in MangaVolumeInfo.MangaDemographicChoice)
            {
                Console.WriteLine($"{kvp.Key}. {kvp.Value} ");
            }
            int userInput = int.Parse(Console.ReadLine());
            NewVolume.Demographic = MangaVolumeInfo.MangaDemographicChoice[userInput];
        }
        public void DisplayCollectedMangaAndCheckForModifications()
        {
            Console.Clear();
            string genreNames = "";
            foreach (string element in NewVolume.Genre)
            {
                genreNames += $"{element}, ";

            }
            Console.WriteLine($"Here is the proposed information: " +
                $"{NewVolume.MangaName}, {NewVolume.MangaSeries}, {NewVolume.MangaMagazine}, {genreNames}{NewVolume.Demographic} Do you have to change anything? Y/N");
            string yesOrNoInput = Console.ReadLine().ToUpper();
            
            if(yesOrNoInput == "Y")
            {
                Console.WriteLine($"What needs to be changed? \n 1. Name \n 2.Series \n 3. Magazine \n 4. Genre \n 5. Demographic");
                int userInput = int.Parse(Console.ReadLine());

                if(userInput == 1)
                {
                    GetMangaNameByUserInput();
                }
                else if(userInput == 2)
                {
                    GetMangaSeriesByUserInput();
                }
                else if(userInput == 3)
                {
                    GetMangaMagazineByUserInput();
                }
                else if(userInput == 4)
                {
                    GetGenreByUserInput();
                }
                else if(userInput == 5)
                {
                    GetMangaDemographic();
                }
                DisplayCollectedMangaAndCheckForModifications();
            }
        }
        public void UploadFinalizedManga()
        {
            Writer.WriteToMangaCollectionLog(NewVolume);
        }

        public void DisplayEntireStoredLibrary()
        {
            Reader.OpenReader();
        }
    }
}
