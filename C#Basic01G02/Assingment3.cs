// QUESTION 1

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            double[] prices = { 25.5, 40.0, 33.75 };

//            Console.WriteLine(prices[1]);
//        }
//    }
//}

//QUESTION 2

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };

//            Console.WriteLine(shelfCopies[1, 0]);
//        }
//    }
//}

//QUESTION 3

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            PrintWelcomeMessage();
//        }

//        static void PrintWelcomeMessage()
//        {
//            Console.WriteLine("Welcome to the Library!");
//        }
//    }
//}

//QUESTION 4

//    namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            PrintBookTitle("Clean Code");
//        }

//        static void PrintBookTitle(string title)
//        {
//            Console.WriteLine("Book title: " + title);
//        }
//    }
//}

//QUESTION 5

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            int pages = 400;
//            AddBonusPages(pages);
//            Console.WriteLine(pages);
//        }

//        static void AddBonusPages(int pages)
//        {
//            pages = pages + 50;
//        }
//    }
//}

//QUESTION 6

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            double[] prices = { 25.5, 40.0 };
//            ApplyDiscount(prices);
//            Console.WriteLine(prices[0]);
//        }

//        static void ApplyDiscount(double[] prices)
//        {
//            prices[0] = prices[0] - 5;

//        }
//    }
//}

//QUESTION 7

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            int pages = 400;
//            AddBonusPagesByRef(ref pages);
//            Console.WriteLine(pages);
//        }

//        static void AddBonusPagesByRef(ref int pages)
//        {
//            pages = pages + 50;
//        }
//    }
//}

//QUESTION 8

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            double[] prices = { 25.5, 40.0 };

//            ReplaceArray(ref prices);

//            Console.WriteLine(prices.Length);
//        }

//        static void ReplaceArray(ref double[] prices)
//        {
//            prices = new double[] { 10.0, 12.5, 15.0 };
//        }
//    }
//}

//QUESTION 9

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            bool found = TryGetPrice("Clean Code", out double price);

//            if (found)
//            {
//                Console.WriteLine("Found! Price: " + price);
//            }
//            else
//            {
//                Console.WriteLine("Not found. Price: " + price);
//            }
//        }

//        static bool TryGetPrice(string title, out double price)
//        {
//            if (title == "Clean Code")
//            {
//                price = 25.5;
//                return true;
//            }
//            else
//            {
//                price = 0;
//                return false;
//            }
//        }
//    }
//}

//QUESTION 10

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            PrintBookInfo("Refactoring");
//            PrintBookInfo("Clean Code", 464);
//        }

//        static void PrintBookInfo(string title, int pages = 300)
//        {
//            Console.WriteLine("Title: " + title + ", Pages: " + pages);
//        }
//    }
//}

//QUESTION 11

//namespace C_Basic01G02
//{
//    internal class Assingment3
//    {
//        static void Main()
//        {
//            PrintBookInfo("Refactoring");
//            PrintBookInfo(pages: 464, title: "Clean Code");
//        }

//        static void PrintBookInfo(string title, int pages = 300)
//        {
//            Console.WriteLine("Title: " + title + ", Pages: " + pages);
//        }
//    }
//}