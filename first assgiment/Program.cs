namespace first_assgiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer1 
            Book book1 = new Book();
            object obj = book1;
            Console.WriteLine(obj);
            //answer 2
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.GetType());

        }

    }
}
