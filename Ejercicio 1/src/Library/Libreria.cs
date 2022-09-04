using System;

namespace SRP
{
    public class Library {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Library(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}