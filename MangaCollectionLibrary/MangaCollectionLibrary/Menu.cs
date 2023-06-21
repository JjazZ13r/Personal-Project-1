using System;
using System.Collections.Generic;
using System.Text;

namespace MangaCollectionLibrary
{
    public class Menu
    {
        public MangaVolumeInfo NewVolume = new MangaVolumeInfo();
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
            GetMangaMagazineByUserInput();
        }
        public void GetMangaMagazineByUserInput()
        {
            Console.WriteLine("What magazine was this Manga published in?: ");
            string userInput = Console.ReadLine();
            NewVolume.MangaMagazine = userInput;
            GetGenreByUserInput();
        }
        public void GetGenreByUserInput()
        {
            Console.WriteLine("What Genre is this Manga?: ");
            string userInput = Console.ReadLine();
            NewVolume.Genre = userInput;
            Console.WriteLine("Does this have another Genre? Y/N: ");
            string yesOrNoInput = Console.ReadLine().ToUpper();

            if (yesOrNoInput == "Y")
            {
                GetGenreByUserInput();
            }
        }
        public void GetMangaDemographic()
        {
            Console.WriteLine("What demographic is this volume? Input number: ");
            foreach (KeyValuePair<int, string> kvp in MangaVolumeInfo.MangaDemographicChoice)
            {
                Console.WriteLine($"{kvp.Key}. {kvp.Value}");
                string userInput = Console.ReadLine();

            }
        }
    }
}
