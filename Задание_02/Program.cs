// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел. Пример: 2, 3, 7 -> 7

internal class Program
{
    private static void Main(string[] args)
    {
        int Prompt(string message)
        {
            Console.Write(message);    // Вывести сообщение
            string readValue = Console.ReadLine();   // Считывает с консоли строку
            int result = int.Parse(readValue);    // Преобразует строку в целое число
            return result;                           // Возвращает результат функции
        }

        int max = Prompt($"Введите число1 ");
        int число2 = Prompt($"Введите число2 ");
        int число3 = Prompt($"Введите число3 ");
        
        if (число2 > max)
        {
            max = число2;
        }
        if (число3 > max)
        {
            max = число3;
        }
        Console.WriteLine($"max = {max}");
    }
}