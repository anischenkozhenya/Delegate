using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и
//возвращает среднее арифметическое этих аргументов. 
namespace Task1
{
    public delegate double dlg(int x, int y, int z);
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            dlg mydlg = (x, y, z) => { return (x + y + z) / 3; };
            Console.WriteLine("Среднее арифметическое: "+mydlg(random.Next(),random.Next(),random.Next()));
            Console.ReadKey();
        }
    }
}
