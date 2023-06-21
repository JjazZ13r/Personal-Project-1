using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MangaCollectionLibrary
{
    public class Writer
    {
        public static void WriteToMangaCollectionLog()
        {
            string director = Environment.CurrentDirectory;
            string fileName = "MangaLibrary";
            string destinationPath = Path.Combine(director, fileName);

        }
    }
}
