namespace Disaheim
{

    public class Program
    {
        static void Main(string[] args)
        {
            Amulet amulet = new Amulet("1", Level.HIGH, "John");

            Amulet amulet2 = new Amulet("2", Level.MEDIUM);

            Book book = new Book("1");
            Book book2 = new Book("2", "forrest gump");

            book2.Title = "dragon ball z";

            Console.WriteLine(book2.ToString());
        }
    }
}