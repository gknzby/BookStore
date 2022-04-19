using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Book : Product
    {
        private long isbn;
        private string author;
        private string publisher;
        private int pageNumber;

        // Isbn - Getter / Setter
        public long Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }
        // Author - Getter / Setter
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        // Publisher - Getter / Setter
        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }
        // PageNumber - Getter / Setter
        public int PageNumber
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
            }
        }

        private static Book book; // Singleton Class Object.
        private static List<Book> books; // All Books.

        // Default Constructor - Start
        public Book()
        {

        }
        // Default Constructor - End

        // Singleton Patern Constructor - Start
        public static Book BookX()
        {
            if (book == null)
            {
                book = new Book();
                books = new List<Book>();
            }
            return book;
        }
        // Singleton Patern Constructor - End

        // Print All Details Of Product - Start
        public override string[] printProperties()
        {
            string[] propers = new string[9];

            propers[0] = Id.ToString();
            propers[1] = Name.ToString();
            propers[2] = Price.ToString();
            propers[3] = ProductType.ToString();
            propers[4] = CoverPagePicture;
            propers[5] = author;
            propers[6] = publisher;
            propers[7] = pageNumber.ToString();
            propers[8] = isbn.ToString();

            return propers;
        }
        // Print All Details Of Product - End

        // Clear Books List - Start
        public void clearBooks()
        {
            books.Clear();
        }
        // Clear Books List - End

        // List All Books - Start
        public List<Book> listAllBooks()
        {
            return books;
        }
        // List All Books - End

        // Sync All Books With Database - Start
        public void syncAllBooks(List<Book> x)
        {
            books.Clear();
            books = x;
        }
        // Sync All Books With Database - End

        // Add Book To List - Start
        public void addBook(long idX,string nameX,double priceX,long isbnX,string authorX,string publisherX,int pageNumberX,string coverPagePictureX)
        {
            books.Add(new Book
            {
                Id = idX,
                Name = nameX,
                Price = priceX,
                Isbn = isbnX,
                Author = authorX,
                Publisher = publisherX,
                PageNumber = pageNumberX,
                CoverPagePicture = coverPagePictureX
            });
        }
        // Add Book To List - End

        // Remove Book From List - Start
        public void removeBook(long idX)
        {
            int index = -1;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }
            books.RemoveAt(index);
        }
        // Remove Book From List - End

        // Update Book At List - Start
        public void updateBook(long idX, string nameX, double priceX, long isbnX, string authorX, string publisherX, int pageNumberX)
        {
            int index = -1;
            for(int i=0;i<books.Count;i++)
            {
                if(books[i].Id==idX)
                {
                    index = i;
                    break;
                }
            }
            books[index].Name = nameX;
            books[index].Price = priceX;
            books[index].Isbn = isbnX;
            books[index].Author = authorX;
            books[index].Publisher = publisherX;
            books[index].PageNumber = pageNumberX;
        }
        // Update Book At List - End

        // Add Or Update Cover Page Picture Of Product - Start
        public void AddCoverPagePicture(long idX,string pictureNameX)
        {
            int index = -1;
            for(int i=0;i<books.Count;i++)
            {
                if(books[i].Id==idX)
                {
                    index = i;
                    break;
                }
            }
            books[index].CoverPagePicture = pictureNameX;
        }
        // Add Or Update Cover Page Picture Of Product - End
    }
}