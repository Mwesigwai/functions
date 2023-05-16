using System;

namespace functions
{
    class MainClass
    {
        public static void Main()
        {
            Sum();
        }

        public static void Sum()
        {
            int x;
            int y;
            try
            {
                Console.WriteLine("Enter a number");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You entered..{0} and {1}", x, y);
                Console.WriteLine("Their sum is.. {0} ", x + y);

                Console.Read();
            }
            catch(Exception)
            {
                Console.WriteLine("Bad input format");
            }

        }
    }
}
