

using System;

char input = ' ';

while (input != 'S')
{
    Console.WriteLine("Enter");
    Console.WriteLine("F for odd number range");
    Console.WriteLine("W for even number range");
    Console.WriteLine("Q for prime number range");
    Console.WriteLine("N for fibonacci number range");
    Console.WriteLine("A for Armstrong number range");
    Console.WriteLine("S to stop");

    input = char.Parse(Console.ReadLine()!);

    switch (input)
{
    case 'F':
            Console.WriteLine("Odd number range:");

            for (int i = 100; i < 120; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{input}{i}");
                }
            }
            
            break;
    case 'W':
            Console.WriteLine("Even number range:");

            for (int i = 100; i < 120; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{input}{i}");
                }
            }
            break;
    case 'Q':
            Console.WriteLine("Prime number range:");
            int count = 0;
            int flag = 0;

            for (int i = 100; i < 150; i++)
            {
                flag = 0;
                    for (int j = 2; j < i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine($"{input}{i}");
                        count++;
                    }
            }
            break;
    case 'N':
            Console.WriteLine("Fibonacci number range:");

            int number1 = 55;
            int number2 = 89;
            int s = 0;

            for (int i = 0; i < 5; i++)
            {
                s = number1 + number2;

                Console.WriteLine($"{input}{s}");

                number1 = number2;
                number2 = s;
            }
            break;
    case 'A':
            Console.WriteLine("Armstrong number range:");

            for (int i = 100; i < 1000; i++)
            {
                int temp = i;
                int res = 0;
                int rem = 0;
                while (temp != 0)
                {
                    rem = temp % 10;
                    res = res + (rem * rem * rem);
                    temp = temp / 10;
                }
                if (res == i)
                {
                    Console.WriteLine($"{input}{i}");
                }
            }

            break;
    case 'S':
            Console.WriteLine("End!");
            break;
    default:
        Console.WriteLine("Invalid Entry (Case Sensitive)");
        break;
}
}