// // задача 1 - HARD необязательная. На вход программы подаются одно целое число. Составьте список чисел Фибоначчи,
// //  в том числе для отрицательных индексов. Это по сути последовательность Негафибоначчи.


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
// int size = n * 2 + 1;

// Fibonacci(n);
NegaFibonacci(n);

// Числа Фибонначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i <= n; i++)
// {
//     Console.Write($"{Fibonacci(i)} ");
// }

double NegaFibonacci(int n)
{
    if (n == -1) return 1;
    else if (n == -2) return -1;
    else return NegaFibonacci(n + 2) - NegaFibonacci(n + 1);
}
for (int j = -n; j <= -1; j++)
{
    Console.Write($"{NegaFibonacci(j)} ");
}

