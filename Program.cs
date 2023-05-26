using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 1");
        
            string s1 = "Hello";
            string s2 = "World";
            Console.WriteLine(s1 + s2);

            Console.WriteLine("Номер 2");

            Console.WriteLine("Введите первое число");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int p2 = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            Console.WriteLine("Введите знак");
            string znak = Console.ReadLine();
            if (znak == "+")
            {
                r = p1 + p2;
            }
            if (znak == "-")
            {
                r = p1 - p2;
            }
            if (znak == "*")
            {
                r = p1 * p2;
            }
            if (znak == "/")
            {
                r = p1 / p2;
            }
            Console.WriteLine(r);

            Console.ReadKey();

            Console.WriteLine("Номер 3");

            Console.WriteLine("Введите Имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string fam = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string otch = Console.ReadLine();
            Console.Write(name + " " + fam + " " + otch);

            Console.ReadKey();

            Console.WriteLine("Номер 4");

            int hp_p = 100;
            int hp_m = 65;
            int def_p = 15;
            int def_m = 10;
            int atk_p = 30;
            int atk_m = 20;


            Console.WriteLine("Ваше здоровье " + hp_p);
            Console.WriteLine("Здоровье монстра " + hp_m);

            Console.WriteLine("Время удара");
            Console.ReadKey();
            int atk2p = atk_p / def_m;
            hp_m = hp_m - atk2p;
            int atk2m = atk_m / def_p;
            hp_p = hp_p - atk2m;
            Console.WriteLine("Ваше здоровье " + hp_p);
            Console.WriteLine("Здоровье монстра " + hp_m);
            Console.WriteLine("Нанесено монстру " + atk2p);
            Console.WriteLine("Нанесено вам " + atk2m);
            Console.ReadKey();
        }
    }
}
