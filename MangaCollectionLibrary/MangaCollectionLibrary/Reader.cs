using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MangaCollectionLibrary
{
    public static class Reader
    {
        public static void OpenReader()
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "Manga_Library.csv";
            string destinationPath = Path.Combine(directory, fileName);
            string completePath = "\"C:\\Users\\Student\\workspace\\Personal-Project-1\\MangaCollectionLibrary\\MangaCollectionLibrary\\bin\\Debug\\netcoreapp3.1\\Manga_Library.csv\"";
            try
            {
                using (StreamReader reader = new StreamReader(destinationPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split('~');
                        string fixedLine = "";
                        foreach (string item in split)
                        {
                            line = "";
                            string newLine = item.Replace("~", " ");
                            fixedLine += newLine;
                        }
                        Console.WriteLine(fixedLine);
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("There was an error displaying the library", ex);
                Menu newMenu = new Menu();
                
            }
        }
        public static void OpenReaderForSpecificVolume(string userInput)
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "Manga_Library.csv";
            string destinationPath = Path.Combine(directory, fileName);

            try
            {
                int lineCount = 0;
                using (StreamReader rd = new StreamReader(destinationPath))
                {
                    Console.Clear();
                    while(!rd.EndOfStream)
                    {
                        lineCount++;
                        string lineOfText = rd.ReadLine();
                        string[] split = lineOfText.Split('~');
                        string fixedLine = "";
                        foreach(string item in split)
                        {
                            string newLine = item.Replace("~", " ");
                            fixedLine += newLine;
                        }
                        if(fixedLine.ToLower().Contains(userInput.ToLower()))
                        {
                            Console.WriteLine(fixedLine);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("There was an error displaying the library", ex);
                Menu newMenu = new Menu();
                newMenu.MainMenu();
            }
        }
    }
}
