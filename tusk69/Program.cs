Console.Clear();
int a = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  
int b = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  
int result = GetResult(a, b);
Console.Write($"A = {a}; B = {b} -> {result}");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetResult(int a, int b)
{
    if (b == 1) return a;
    {
        return a*GetResult(a, b-1);
    }
}