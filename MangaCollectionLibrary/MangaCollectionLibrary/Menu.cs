using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace MangaCollectionLibrary
{
    public class Menu
    {
        public MangaVolumeInfo NewVolume = new MangaVolumeInfo() { Genre = new List<string>() };

        public void MainMenu()
        {
            Console.Title = "Manga Collection Record";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Manga Collection Library");
            Console.ResetColor();
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Insert new Volume");
            Console.WriteLine("2. Search for Existing Volume");
            Console.WriteLine("3. List current library");
            Console.WriteLine("4. Exit");
            Console.WriteLine("------------------------");
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
                    ThankUserForUsage();
                    ReturnToMainMenu();
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    Console.WriteLine("What is the name of the volume you are looking for?");
                    string mangaVolume = Console.ReadLine();
                    Reader.OpenReaderForSpecificVolume(mangaVolume);
                    PromptUserForMenu();
                }
                else if (userInput == 3)
                {
                    Console.Clear();
                    Reader.OpenReader();
                    PromptUserForMenu();
                    
                }
                else if (userInput == 4)
                {
                    Goodbye();
                    Environment.Exit(0);
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
                $"{NewVolume.MangaName}, {NewVolume.MangaSeries}, {NewVolume.MangaMagazine},\n{genreNames}{NewVolume.Demographic}.\nDo you have to change anything? Y/N");
            string yesOrNoInput = Console.ReadLine().ToUpper();
            
            if(yesOrNoInput == "Y")
            {
                Console.WriteLine($"What needs to be changed? \n 1. Name \n 2. Series \n 3. Magazine \n 4. Genre \n 5. Demographic");
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
                    NewVolume.Genre.Clear();
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

        public void PromptUserForMenu()
        {
            Console.WriteLine("Press enter when ready to return to Main Menu: ");
            string input = Console.ReadLine();
            if(input == "")
            {
                Console.Clear();
                MainMenu();
            }
        }

        public void DisplayEntireStoredLibrary()
        {
            Reader.OpenReader();
        }
        public void ThankUserForUsage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your volume has been added to the library!");
            Thread.Sleep(1500);
        }
        public void ReturnToMainMenu()
        {
            Console.Clear();
            MainMenu();
        }
        public void Goodbye()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Goodbye! See you later!");
            Console.ResetColor();
            Thread.Sleep(2000);
        }
    }
}
