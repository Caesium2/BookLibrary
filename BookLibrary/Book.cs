namespace BookLibrary
{
    internal class Book
    {
        private string title;
        private string author;
        private string genre;
        private int isbn;
        private int year;
        private string publisher;
        private int bookCount = 0;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int ISBN
        {
            get { return isbn; }
            private set { isbn = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public Book()
        {
            title = "The Great Gatsby";
            author = "F. Scott Fitzgerald";
            bookCount++;
            isbn = 23452341;
            genre = "Classic";
            publisher = "Charles Scribner's Sons";

        }

        public Book(string title, string author, int isbn, string genre, string publisher)
        {
            bookCount++;
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.genre = genre;
            this.publisher = publisher;
        }


    }
}
