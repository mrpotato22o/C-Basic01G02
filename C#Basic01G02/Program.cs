
// FIRST QUESTION 

//namespace C_Basic01G02
//{
//    public class Book
//    {
//        public override string ToString()
//        {
//            return $"{Title} - {Pages} pages";
//        }
//        public string Title { get; set; }
//        public int Pages { get; set; }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            object myBook = new Book { Title = "The Hobbit", Pages = 310 };

//            Console.WriteLine(myBook);
//        }
//    }
//}

// SECOND QUSTION

//namespace C_Basic01G02
//{
//    internal class Book
//    {
//              public override string ToString()
//              {
//                  return $"{Title} - {Pages} pages";
//              }

//        public string Title { get; set; }
//        public int Pages { get; set; }
//    }

//    internal class Program
//    {
//        static void Main()
//        {
//            Book book = new Book { Title = "The Hobbit", Pages = 310 };

//            Console.WriteLine(book.ToString());
//            Console.WriteLine(book.Equals(book));
//            Console.WriteLine(book.GetHashCode());
//            Console.WriteLine(book.GetType());
//        }
//    }
//}

//THIRD QUSTION 

//namespace C_Basic01G02
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int numerator = 10;
//            int denominator = 0;
//            try
//            {
//                int result = numerator / denominator;
//                Console.WriteLine(result);
//            }
//            catch (Exception )
//            {
//                Console.WriteLine("Cannot divide by zero");
//            }
//            finally
//            {
//                Console.WriteLine("Done");
//            }
//        }
//    }
//}

// FOURTH QUESTION 

//namespace C_Basic01G02
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int pages = 300;
//            double pagesAsDouble = pages;

//            Console.WriteLine(pagesAsDouble);
//        }
//    }
//}

// QUESTION 5 

//namespace C_Basic01G02
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            double price = 49.99;
//            int priceAsInt = (int)price;

//            Console.WriteLine(priceAsInt);
//        }
//    }
//}

// QUESTION 6

//namespace C_Basic01G02
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            string pagesText = "464";
//            int pages = Convert.ToInt32(pagesText);

//            Console.WriteLine(pages);
//        }
//    }
//}

// QUESTION 7

//namespace C_Basic01G02
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            string yearText = "2023";
//            int year = int.Parse(yearText);
//            Console.WriteLine(year);

//           
//            string badText = "abc";
//            bool success = int.TryParse(badText, out int result);
//            if (success)
//            {
//                Console.WriteLine(result);
//            }
//            else
//            {
//                Console.WriteLine("Invalid number");
//            }
//        }
//    }
//}

// QUESTION 8

//namespace C_Basic01G02
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int pages = 464;
//            string pagesText = pages.ToString();

//            Console.WriteLine(pagesText);
//            Console.WriteLine(pagesText.GetType());
//        }
//    }
//}
  





//namespace C_Basic01G2 {


//    internal class C_Basic01G2 {
     
//            public int TotalGrad = 0;
//            public int AverageGrade = TotalGrad \ 4;

//        static void Main() {

//            Console.WriteLine(" Enter Your Name ");
//            string student = Console.ReadLine();

//            Console.WriteLine(" Enter Your Age ");
//            int.TryParse(Console.ReadLine() , out int age);
//            Console.WriteLine(" Enter Your Grade 1 ");
//            double.TryParse(Console.ReadLine(), out double grade1);
//            Console.WriteLine(" Enter Your Grade 2");
//            double.TryParse(Console.ReadLine(), out double grade2);

//            Console.WriteLine(" Enter Your Grade 3");
//            double.TryParse(Console.ReadLine(), out double grade3);



            
//        }

//    }

//}

