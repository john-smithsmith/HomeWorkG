namespace day02homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("정수1번 입력: ");
            int num1;
            int.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("정수2번 입력: ");
            int num2;
            int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("연산자 (+, -, *, /, %) 입력: ");
            string cal = Console.ReadLine();

            switch (cal)
            {
                case "+":
                    Console.WriteLine($"결과: {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"결과: {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"결과: {num1 * num2}");
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("2번 정수가 0입니다");
                        return;
                    }
                    Console.WriteLine($"결과: {num1 / num2}");
                    break;

                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine("2번 정수가 0입니다");
                        return;
                    }
                    Console.WriteLine($"결과: {num1 % num2}");
                    break;

                default:
                    Console.WriteLine("연산자 오류");
                    return;
            
            
            }

        }
    }
}



//프로그램 사용자의 입력을 받아 계산을 수행하는 계산기를 구현하시오
//프로그램 실행 시 정수를 두 개 입력받습니다.
//두 번째 줄에는 +, -, *, /, % 중 하나를 입력받도록 하며, 이외의 문자 입력 시 프로그램이 종료되도록 구성합니다
//각 연산자는 아래와 같은 결과를 출력하도록 소스코드를 구성합니다.
//+ : 두 수를 더한 값을 출력한다
//- : 두 수를 뺀 값을 출력한다
//* : 두 수를 곱한 값을 출력한다
/// : 두 수를 나눈 값을 출력한다(단, 두 번째 숫자가 0인 경우 프로그램을 종료한다)
//% : 두 수를 나눈 값의 나머지를 출력한다(단, 두 번째 숫자가 0인 경우 프로그램을 종료한다)