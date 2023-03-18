using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выбирете что хотите сделать:\n" +
                "Добавить элемент - 1\n" +
                "Удалить элемент - 2\n" +
                "Добавить в начало элемент - 3\n" +
                "Вывести все элементы - 4\n" +
                "Проверить наличие элемента - 5\n" +
                "Выйти из программы - 6");
                int operation = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Введите число, которое хотите добавить: ");
                        int num = int.Parse(Console.ReadLine());
                        list.Add(num);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите число, которое хотите удалить: ");
                        int num1 = int.Parse(Console.ReadLine());
                        list.Remove(num1);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Введите число, которое хотите добавить в начало: ");
                        int num2 = int.Parse(Console.ReadLine());
                        list.Add(num2);
                        Console.WriteLine();
                        break;
                    case 4:
                        if (list.IsEmpty == false)
                        {
                            Console.WriteLine("Вот все элементы списка: ");
                            foreach (var item in list)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine();
                        }
                        else Console.WriteLine("В списке нет элементов.");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Введите число, которое хотите проверить в наличии списка: : ");
                        int num3 = int.Parse(Console.ReadLine());
                        if (list.Contains(num3))
                        {
                            Console.WriteLine("Да, он есть.");
                        }
                        else Console.WriteLine("Такого элемента нет.");
                        Console.WriteLine();
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }
            
    }
}
