using Tyuiu.AtakishievRS.Sprint2.Task0.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService(); 

        Console.Title = "Спринт #2 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
        Console.WriteLine("* последовательность операций не должна нарушаться)                       *");
        Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность*");
        Console.WriteLine("* (массив): (False, True, True, True, True, False), при x = 5105, y = 475 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* x = 5105, y = 475                                                       *");
        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        int x = 5105;
        int y = 475;

        bool[] res = new bool[6];

        res = ds.GetCompareOperations(x, y);

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}