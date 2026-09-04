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
            //answer 3
            //int pages = "464"; compile time erro
            int pages = 464;
            //answer 4

            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (Exception)
            {
                Console.WriteLine("cannt divided by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            //answer 5
            int Pages = 300;
            double pages1 = pages;//implict casting save casting
            //answer 6
            double price2 = 49.99;
            int p = (int)price2;//explicit casting unsafe cast;
        }

    }
}
