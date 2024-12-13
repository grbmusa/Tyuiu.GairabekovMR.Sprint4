using Tyuiu.GairabekovMR.Sprint4.Task2.V19.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new();
        Console.Title = "Спринт #4 | Выполнил: Гайрабеков | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                                ");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                             ");
        Console.WriteLine("* Задание #2                                                               ");
        Console.WriteLine("* Вариант #19                                                              ");
        Console.WriteLine("* Выполнил: Гайрабеков | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный          ");
        Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму нечетных               ");
        Console.WriteLine("* элементов массива.                                                       ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите длину массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            array[i] = rnd.Next(4, 9);
        }
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(array));
        Console.ReadKey();
    }
}