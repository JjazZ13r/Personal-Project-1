using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MangaCollectionLibrary
{
    public class Writer
    {
        public static void WriteToMangaCollectionLog(MangaVolumeInfo manga)
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "Manga_Library.txt";
            string destinationPath = Path.Combine(directory, fileName);
            try
            {
                using (StreamWriter sw = new StreamWriter(destinationPath))
                {
                    foreach(var item in manga)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Sorry, there was an error logging the volume to the library");
            }

        }
    }
}
