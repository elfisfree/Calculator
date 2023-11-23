class Calculator
{
    static void Main()
    {
        Console.WriteLine("Введите выражение (например, 2 + 3 * 5):");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');
        if (parts.Length % 2 == 0)
        {
            Console.WriteLine("Некорректное выражение");
            return;
        }

        double result = double.Parse(parts[0]);
        for (int i = 1; i < parts.Length; i += 2)
        {
            string op = parts[i];
            double operand = double.Parse(parts[i + 1]);

            switch (op)
            {
                case "+":
                    result += operand;
                    break;
                case "-":
                    result -= operand;
                    break;
                case "*":
                    result *= operand;
                    break;
                case "/":
                    if (operand == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно");
                        return;
                    }
                    result /= operand;
                    break;
                default:
                    Console.WriteLine("Неподдерживаемая операция");
                    return;
            }
        }

        Console.WriteLine("Результат: " + result);
    }
}
