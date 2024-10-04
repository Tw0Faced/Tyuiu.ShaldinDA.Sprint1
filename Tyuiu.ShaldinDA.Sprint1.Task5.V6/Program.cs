using Tyuiu.ShaldinDA.Sprint1.Task5.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Преобразование типов и класс Convert                                    *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Написать программу, которая решает следующую задачу: Пусть k – целое от  *");
        Console.WriteLine("* 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в зависимости *");
        Console.WriteLine("* от того, на какой день недели (понедельник, вторник,..., воскресенье) пр*");
        Console.WriteLine("*риходится k-й день невисокосного года, в котором 1 января – понедельник. *");
        Console.WriteLine("*                                                                         *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int k;
        Console.WriteLine("Введите номер дня (от 1 до 365):");
        _ = int.TryParse(Console.ReadLine(), out k) && k >= 1 && k <= 365;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
       
        int result = ds.Calculate(k);
        Console.WriteLine($"День недели для {k}-го дня: {result}");
        Console.ReadKey();
    }
}