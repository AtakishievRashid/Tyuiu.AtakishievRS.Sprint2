using Tyuiu.AtakishievRS.Sprint2.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        int x;
        Console.WriteLine("Введите номер масти:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Масть карты - " + ds.FindCardSuit(x));
        Console.ReadKey();
    }
}