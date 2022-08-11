// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// Например: a = 5; b = 7 -> max = 7, min = 5

int Prompt(string message)
{
    System.Console.Write(message);    // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);    // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int число1 = Prompt($"Введите число1 ");
int число2 = Prompt($"Введите число2 ");
if (число1 < число2)
{
    Console.WriteLine($"max = {число2}");
    Console.WriteLine($"min = {число1}");
}
if (число1 == число2)
{
    Console.WriteLine($"max=min= {число1}");
}
if (число1 > число2)
{
    Console.WriteLine($"max = {число1}");
    Console.WriteLine($"min = {число2}");
}
