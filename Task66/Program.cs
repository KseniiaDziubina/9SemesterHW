Console.Write("Введите число M: ");
int NumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int NumberN = Convert.ToInt32(Console.ReadLine());

int count = NumberM;

PrintSumOfNumbers(NumberM, NumberN, count = 0);

void PrintSumOfNumbers(int NumberM, int NumberN, int Sum)
{
  Sum = Sum + NumberN;
  if (NumberN <= NumberM)
  {
    Console.Write($"Сумма чисел равна: {Sum} ");
    return;
  }
  PrintSumOfNumbers(NumberM, NumberN - 1, Sum);
}
