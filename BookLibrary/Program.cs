using BookLibrary;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Book book2 = new Book("Dracula", "Bram Stoker", 54637283, "Horror Fiction", 1897, "Penguin Shop");

        book1.DisplayDetails();
        book2.DisplayDetails();
    }
}