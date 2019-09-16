using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает
//среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
//Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. 
namespace Task3
{
    delegate int innerdlg();
    delegate double result(innerdlg[] array);
    class Program
    {
        static void Main(string[] args)
        {
            Random count = new Random();
            innerdlg[] innerdlgs = new innerdlg[count.Next(2, 10)];
            for (var i = 0; i < innerdlgs.Length; i++)
            {
                innerdlgs[i] = () => new Random().Next(0, 1000);
            }
            result result = new result((innerdlg[] Array) =>
            {
                double A = 0;
                for (var i = 0; i < Array.Length; i++)
                {
                    if (i == Array.Length - 1)
                        Console.Write(Array[i].Invoke().ToString());
                    else
                        Console.Write(Array[i].Invoke().ToString() + "+");
                    A += Convert.ToUInt32(Array[i].Invoke().ToString());
                }
                Console.WriteLine("=" + A / Array.Length);
                return A / Array.Length;
            });
            result.Invoke(innerdlgs);
            Console.ReadKey();
        }
    }
}
