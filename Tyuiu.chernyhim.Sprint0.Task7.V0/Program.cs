using Tyuiu.chernyhim.Sprint0.Task7.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Sprint #0 | Made by Chernyh I. M. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #0                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнил: Черных Илья Максимович | ПКТб-25-1                            *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на С#, которая суммирует значения двух    *");
        Console.WriteLine("* одинаковых массивов по длине.                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Значение массива №1");
        for (int i = 0; i < arrayNums1.Length; i++)
        {
            Console.WriteLine(arrayNums1[i] + ", ");
        }

        Console.WriteLine();


        int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Значение массива №2");
        for (int i = 0; i < arrayNums2.Length; i++)
        {
            Console.WriteLine(arrayNums2[i] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (arrayNums1.Length == arrayNums2.Length)
        {
            int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

            Console.WriteLine("Сумма элементов масссива равна:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i] + ", ");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
        Console.ReadKey();
    }
}