using System;
/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значения A, B и C:");

        int A = ReadIntValue("A");
        int B = ReadIntValue("B");
        int C = ReadIntValue("C");

        int squaresCount = CalculateSquaresCount(A, B, C);
        int unusedArea = CalculateUnusedArea(A, B, C, squaresCount);

        Console.WriteLine($"Количество квадратов: {squaresCount}");
        Console.WriteLine($"Площадь незанятой части: {unusedArea}");
    }

    static int ReadIntValue(string name)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write($"Введите значение {name}: ");
            isValid = int.TryParse(Console.ReadLine(), out value);

            if (!isValid || value <= 0)
            {
                Console.WriteLine("Некорректное значение. Введите положительное целое число.");
                isValid = false;
            }

        } while (!isValid);

        return value;
    }

    static int CalculateSquaresCount(int A, int B, int C)
    {
        int maxPossibleSquares = Math.Min(A / C, B / C);
        return maxPossibleSquares;
    }

    static int CalculateUnusedArea(int A, int B, int C, int squaresCount)
    {
        int totalArea = A * B;
        int occupiedArea = squaresCount * C * C;
        int unusedArea = totalArea - occupiedArea;
        return unusedArea;
    }
}
*/
// 2 задача

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение P (процент увеличения вклада):");

        double P = ReadDoubleValue("P");
        double initialDeposit = 10000;
        double targetDeposit = 11000;
        int months = CalculateMonthsToReachTargetDeposit(initialDeposit, P, targetDeposit);
        double finalDeposit = CalculateFinalDeposit(initialDeposit, P, months);

        Console.WriteLine($"Количество месяцев: {months}");
        Console.WriteLine($"Итоговый размер вклада: {finalDeposit}");
    }

    static double ReadDoubleValue(string name)
    {
        double value;
        bool isValid;

        do
        {
            Console.Write($"Введите значение {name}: ");
            isValid = double.TryParse(Console.ReadLine(), out value);

            if (!isValid || value <= 0 || value >= 25)
            {
                Console.WriteLine("Некорректное значение. Введите число от 0 до 25.");
                isValid = false;
            }

        } while (!isValid);

        return value;
    }

    static int CalculateMonthsToReachTargetDeposit(double initialDeposit, double P, double targetDeposit)
    {
        int months = 0;
        double currentDeposit = initialDeposit;

        while (currentDeposit < targetDeposit)
        {
            currentDeposit += currentDeposit * P / 100;
            months++;
        }

        return months;
    }

    static double CalculateFinalDeposit(double initialDeposit, double P, int months)
    {
        double finalDeposit = initialDeposit;

        for (int i = 0; i < months; i++)
        {
            finalDeposit += finalDeposit * P / 100;
        }

        return finalDeposit;
    }
}