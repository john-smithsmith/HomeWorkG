namespace day03homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("끝 수를 입력해주세요");
            int n2 = int.Parse(Console.ReadLine());

            int n3 = 0;

            for (int i = n1; i <= n2; i++)
            {
                n3 += i;
            }
            Console.WriteLine($"{n1}과 {n2}사이 숫자의 합은 {n3}입니다");
        }
    }
}
