using System;
using System.Collections.Generic;
using System.Text;

namespace MangaCollectionLibrary
{
    public class Menu
    {
        public void MainMenu()
        {
            Console.Title = "Manga Collection Record";
            Console.WriteLine("1. Insert new Volume");
            Console.WriteLine("2. Search for Existing Volume");
            Console.WriteLine("3. List current library");
            int userInput;
            MangaVolumeInfo newManga = new MangaVolumeInfo();
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
            this.MangaName= userInput;
            GetMangaMagazineByUserInput();
        }
        public void GetMangaMagazineByUserInput()
        {
            Console.WriteLine("What magazine was this Manga published in?: ");
            string userInput = Console.ReadLine();
            this.MangaMagazine = userInput;
            GetGenreByUserInput();
        }
        public void GetGenreByUserInput()
        {
            Console.WriteLine("What Genre is this Manga?: ");
            string userInput = Console.ReadLine();
            this.Genre = userInput;
            Console.WriteLine("Does this have another Genre? Y/N: ");
            string yesOrNoInput = Console.ReadLine().ToUpper();

            if (yesOrNoInput == "Y")
            {
                GetGenreByUserInput();
            }
        }
    }
}
