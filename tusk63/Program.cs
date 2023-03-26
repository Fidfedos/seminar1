Console.Clear();
int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
GetResult(n);


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

void GetResult(int n)
{
    if (n == 0) return;
    else
    {
       
        GetResult(n - 1);
        Console.Write($"{n},");
    }
}