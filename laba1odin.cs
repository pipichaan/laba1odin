using System;
using System.Linq;

class Program
{
    const int MaxSize = 1000;
    const int MaxValue = 10000;
    const int Divisor = 21;

    static void Main()
    {
        int[] array = new int[MaxSize];
        Random random = new Random();

        // Заполняем массив случайными неотрицательными целыми числами до 10000
        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(0, MaxValue + 1);

        // Используем HashSet для хранения произведений
        HashSet<int> products = new HashSet<int>();

        // Находим произведения 2 различных элементов
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                int product = array[i] * array[j];
                if (product <= MaxValue)
                {
                    products.Add(product);
                }
            }
        }

        // Находим минимальное R, кратное 21
        int minR = int.MaxValue;
        foreach (int product in products)
        {
            if (product % Divisor == 0 && product < minR)
            {
                minR = product;
            }
        }

        // Проверяем найденное значение
        if (minR == int.MaxValue)
        {
            Console.WriteLine(-1); // Если такого R нет
        }
        else
        {
            Console.WriteLine(minR); // Выводим минимальное R
        }
    }
}
