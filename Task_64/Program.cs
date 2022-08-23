// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

PrintNumber(m, n);

void PrintNumber(int m, int n)
{
    if (m > n) return;
    PrintNumber(m, n - 1);
    Console.Write(n + ", ");
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}