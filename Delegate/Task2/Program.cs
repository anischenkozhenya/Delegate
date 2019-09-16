using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub –
//вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два
//аргумента и возвращать результат вычисления.Лямбда оператор деления должен делать проверку
//деления на ноль.
//Написать программу, которая будет выполнять арифметические действия, указанные пользователем.
namespace Task2
{
    public delegate double mydlgt(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            bool close = true;
            mydlgt Sum = ((a, b) => a + b);
            mydlgt Sub = ((a, b) => a - b);
            mydlgt Mul = ((a, b) => a * b);
            mydlgt Div = ((a, b) => a / b);
            do
            {
                double a = 0, b = 0;
                Console.WriteLine("Операция:1-Сложение\n2-Вычитание\n3-Умножение\n4-Деление\nДругое-Выход");

                int c = Convert.ToInt32(Console.ReadLine());
                //или
                //int c = Int32.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Сложение\nВведите первое число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0}+{1}=" + Sum(a, b).ToString(), a.ToString(), b.ToString());
                        break;
                    case 2:
                        Console.WriteLine("Вычитание\nВведите первое число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0}-{1}=" + Sub(a, b).ToString(), a.ToString(), b.ToString());
                        break;
                    case 3:
                        Console.WriteLine("Умножени\n" +
                            "Введите первое число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0}*{1}=" + Mul(a, b).ToString(), a.ToString(), b.ToString());
                        break;
                    case 4:
                        Console.WriteLine("Деление" +
                            "Введите первое число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = Convert.ToDouble(Console.ReadLine());
                        if (b == 0)
                        {
                            Console.WriteLine("Второе число =0;\nВВедине новое число");
                            b = Convert.ToDouble(Console.ReadLine());
                            goto case 4;
                        }
                        else
                            Console.WriteLine("{0}/{1}=" + Div(a, b).ToString(), a.ToString(), b.ToString());
                        break;
                    default:
                        close = false;
                        break;
                }
            } while (close == true);
        }
    }
}
