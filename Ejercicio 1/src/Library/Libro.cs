using System;

namespace SRP
{
    public class Book
    {
        /* Las propiedades LibrarySector y LibraryShelve, deberian estar en otra clase. La clase 
        Libro solo deberia ocuparse de lo relacionado al libro, y otra clase Libreria para los distintos sectores y estantes.
        De esta forma el metodo shelveBook puede guardar el libro directemente en la biblioteca.*/
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Library libreria; 
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(Library libreria){
            this.libreria = libreria;
        }

    }
}
