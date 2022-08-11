// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// Например: 4 -> Четное

int Prompt(string message)
{
    System.Console.Write(message);    // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);    // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int число = Prompt($"Введите число ");
int результат = число%2;
if (результат == 0)
{
    Console.WriteLine ($"{число} - четное число");
}
else 
{
    Console.WriteLine ($"{число} - нечетное число");
}