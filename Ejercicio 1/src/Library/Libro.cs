using System;

namespace SRP
{
    public class Book
    {
        /* El metodo ShelveBook y las propiedades LibrarySector y LibraryShelve, deberian estar en otra clase. La clase 
        Libro solo deberia ocuparse de lo relacionado al libro, y otra clase Libreria para los distintos sectores y estantes.*/
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

    }
}
