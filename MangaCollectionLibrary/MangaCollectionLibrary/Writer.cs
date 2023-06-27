using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MangaCollectionLibrary
{
    public static class Writer
    {
        public static void WriteToMangaCollectionLog(MangaVolumeInfo manga)
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "Manga_Library.csv";
            string destinationPath = Path.Combine(directory, fileName);
            try
            {
                using (StreamWriter sw = new StreamWriter(destinationPath))
                {
                    List<string> mangaProperties = new List<string>
                    {
                        manga.MangaName,
                        manga.MangaSeries,
                        manga.MangaMagazine,
                        string.Join("~", manga.Genre),
                        manga.Demographic
                    };
                    sw.WriteLine(string.Join("|", mangaProperties));
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Sorry, there was an error logging the volume to the library");
            }
        }
    }
}
