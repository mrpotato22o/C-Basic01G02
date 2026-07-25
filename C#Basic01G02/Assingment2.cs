//QUESTION 1

//namespace c_basic01g02
//{
//    internal class assingment2
//    {
//        static void main()
//        {
//            string title = "clean code";
//            string uppertitle = title.toupper();

//            console.writeline(title);
//            console.writeline(uppertitle);
//        }
//    }
//}

//QUESTION 2

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string title1 = "Clean Code";
//            string title2 = "Clean Code";

//            bool sameObject = ReferenceEquals(title1, title2);
//            Console.WriteLine(sameObject);
//        }
//    }
//}

//QUESTION 3

//using System.Text;

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append("Book List");
//            sb.Append(" - Updated");

//            Console.WriteLine(sb.ToString());
//        }
//    }
//}

//QUESTION 4

//using System.Text;

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append("Book List");
//            sb.Append(" - Updated");

//            sb.Replace("Book List", "Library");

//            Console.WriteLine(sb.ToString());
//        }
//    }
//} 

//QUESTION 5 

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string title = "Clean Code";
//            int pages = 464;

//            string sentence = "Book: " + title + ", Pages: " + pages;

//            Console.WriteLine(sentence);
//        }
//    }
//}

//QUESTION 6

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string title = "Clean Code";
//            int pages = 464;

//            string sentence = $"Book: {title}, Pages: {pages}";

//            Console.WriteLine(sentence);
//        }
//    }
//}

//QUESTION 7

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string title = "Clean Code";
//            int pages = 464;

//            string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);

//            Console.WriteLine(sentence);
//        }
//    }
//}

//QUESTION 8

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            int pages = 464;

//            if (pages > 300)
//            {
//                Console.WriteLine("Long Book");
//            }
//            else
//            {
//                Console.WriteLine("Short Book");
//            }
//        }
//    }
//}

//QUESTION 9

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            int pages = 464;
//            bool isAvailable = true;

//            if (pages > 300 && isAvailable)
//            {
//                Console.WriteLine("You can borrow this book");
//            }
//        }
//    }
//}

//QUESTION 10

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string title = "Refactoring";

//            switch (title)
//            {
//                case "Clean Code":
//                    Console.WriteLine("Great choice!");
//                    break;

//                case "Refactoring":
//                    Console.WriteLine("Nice pick!");
//                    break;

//                default:
//                    Console.WriteLine("Never heard of it");
//                    break;
//            }
//        }
//    }
//}

//QUESTION 11

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            int pages = 464;

//            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

//            Console.WriteLine(sizeLabel);
//        }
//    }
//}

//QUESTION 12

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

//            for (int i = 0; i < books.Length; i++)
//            {
//                Console.WriteLine((i + 1) + ". " + books[i]);
//            }
//        }
//    }
//} 

//QUESTION 13

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

//            int i = 0; while (i < books.Length)

//            {
//                Console.WriteLine(books[i]);
//                i++;
//            }
//        }
//    }
//}

//QUESTION 14

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main(string[] args)
//        {
//            int count = 0;

//            do {Console.WriteLine("Checking book...");
//                count++;}

//            while (count < 3);
//        }
//    }
//}
//QUESTION 15

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

//            foreach (string book in books)
//            {
//                Console.WriteLine(book);
//            }
//        }
//    }
//}

//QUESTION 16

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

//            foreach (string book in books)
//            {
//                if (book == "Refactoring")
//                {
//                    break;
//                }

//                Console.WriteLine(book);
//            }
//        }
//    }
//}

//QUESTION 17

//namespace C_Basic01G02
//{
//    internal class Assingment2
//    {
//        static void Main()
//        {
//            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

//            foreach (string book in books)
//            {
//                if (book == "The Pragmatic Programmer")
//                {
//                    continue;
//                }

//                Console.WriteLine(book);
//            }
//        }
//    }
//}