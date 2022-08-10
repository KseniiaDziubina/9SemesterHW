Console.Write("Введите число M: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

void printNumbers(int SecondNumber, int count = 1)
{
    if (count == SecondNumber)
    {
        Console.Write(SecondNumber);
    }
    else
    {
        Console.Write($"{count}, ");
        printNumbers(SecondNumber, count + 1);
    }
}
Console.Write($"В промежутке от {FirstNumber} до {SecondNumber}   ---> ");
printNumbers(SecondNumber, FirstNumber);