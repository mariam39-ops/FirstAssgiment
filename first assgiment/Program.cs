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
            //answer 7

            string pagesText = "464";
            Console.WriteLine(Convert.ToInt32(pagesText));
            //answer 8
            string yeartext = "2023";
            int year = int.Parse(yeartext);
            string badText = "abc";
            int bad;
            bool flag = int.TryParse(badText, out bad);


            if (flag)
            {
                Console.WriteLine("valid num");
            }
            else
            {
                Console.WriteLine("invalid num");
            }

            //answer 9
            int pagess = 464;
            string pag = pages.ToString();
            Console.WriteLine(pag);
            Console.WriteLine(pag.GetType());
            //answer 10
            int copies = 100;
            object og = copies;
            int cop = (int)og;
            Console.WriteLine(og);
            Console.WriteLine(cop);
            //answer 11
            int? Year = null;
            Console.WriteLine(Year.HasValue);
            Year = 2023;
            Console.WriteLine(Year);

        }

    }
}
