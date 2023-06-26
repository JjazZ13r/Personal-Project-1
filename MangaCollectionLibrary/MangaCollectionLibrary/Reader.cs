using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MangaCollectionLibrary
{
    public class Reader
    {
        public void OpenReader()
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "Manga_Library.txt";
            string destinationPath = Path.Combine(directory, fileName);
            try
            {
                using (StreamReader reader = new StreamReader(destinationPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("There was an error displaying the library", ex);
                Menu newMenu = new Menu();
                newMenu.MainMenu();
            }
        }
    }
}
