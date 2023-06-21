using System;
using System.Collections.Generic;
using System.Text;

namespace MangaCollectionLibrary
{
    public class LibraryApplication
    {
        Menu menuDisplay = new Menu();

        MangaVolumeInfo currentManga = new MangaVolumeInfo();

        public void StartProgram()
        {
            menuDisplay.MainMenu();

        }
    }
}
