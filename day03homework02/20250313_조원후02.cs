namespace day03homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)// 1
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)//2
            {
                for (int j = 0; j < 5 - i; j++)
                    Console.Write(" ");
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)//3
            {
                for (int j = 0; j < 5 - i; j++)
                    Console.Write("*");
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i <= 5; i++)//4
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k < 5; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
