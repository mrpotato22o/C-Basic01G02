
//QUESTION 1

//namespace C_Basic01G02
//{
//    internal class Book
//    {
//        public string Title { get; set; }
//        public int Pages { get; set; }
//        private string password = "secret";
//    }

//    internal class Assingment4
//    {
//        static void Main()
//        {
//            Book book = new Book();
//            Console.WriteLine(book.password); //  This will NOT compile because the password is private string
//                                              // accses only within the class or structre
//        }
//    }
//}

////QUESTION 2

using System.Security.AccessControl;

//namespace C_Basic01G02
//{
//    internal class Book
//    {
//        public string Title { get; set; }
//        public int Pages { get; set; }
//        private string password = "secret";
//        internal int copiesInStock = 5;
//    }

//    internal class Assingment4
//    {
//        static void Main()
//        {
//            Book book = new Book();
//            Console.WriteLine(book.copiesInStock); //private → only accessible inside the exact same class
//                                                   //internal → accessible anywhere within the same project
//        }
//    }
//}

//QUESTION 3 

//    namespace C_Basic01G02
//{
//    internal class Book
//    {
//        public string Title;
//    }

//    internal class Assingment4
//    {
//        static void Main()
//        {
//            Book book = new Book();
//            book.Title = "Clean Code";

//            Console.WriteLine(book.Title);
//        }
//    }
//}

//QUESTION 4

//namespace C_Basic01G02
//{
//    internal enum Genre
//    {
//        Fiction,
//        NonFiction,
//        Science
//    }

//    internal class Book
//    {
//        public string Title { get; set; }
//        public int Pages { get; set; }
//        public Genre Genre { get; set; }
//    }

//    internal class Assingment4
//    {
//        static void Main()
//        {
//            Book book = new Book();
//            book.Genre = Genre.Science;

//            Console.WriteLine(book.Genre);
//        }
//    }
//}

//QUESTION 5

//namespace C_Basic01G02
//{
//    internal enum Genre
//    {
//        Fiction,
//        NonFiction,
//        Science
//    }

//    internal class Assingment4
//    {
//        static void Main(
//        {
//            Console.WriteLine((int)Genre.Fiction);
//            Console.WriteLine((int)Genre.NonFiction);
//            Console.WriteLine((int)Genre.Science);
//        }
//    }
//}

//QUESTION 6

//    namespace C_Basic01G02
//{
//    internal enum Genre
//    {
//        Fiction,
//        NonFiction,
//        Science
//    }

//    internal class Assingment4
//    {
//        static void Main()
//        {
//            int genreNumber = 1;
//            Genre genre = (Genre)genreNumber;

//            Console.WriteLine(genre);
//        }
//    }
//}

//QUESTION 7

//    namespace C_Basic01G02
//{
//    internal enum Genre
//    {
//        Fiction,
//        NonFiction,
//        Science
//    }

//    internal class Assingment4
//    {
//        static void Main()
//        {
//            Genre genre = Genre.Fiction;
//            string genreText = genre.ToString();

//            Console.WriteLine(genreText);
//        }
//    }
//}

//QUESTION 8 

//namespace C_Basic01G02
//{
//    internal enum Genre
//    {
//        Fiction,
//        NonFiction,
//        Science
//    }

//    internal class Assingment4
//    {
//        static void Main()
//        {
//            string genreText = "Science";
//            Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);

//            Console.WriteLine(genre);
//        }
//    }
