using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrokiLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //            //1.Составить программу вывода на экран в одну строку
            //            //трех любых чисел с двумя пробелами между ними.
            //            int a = 1;
            //            int b = 2;
            //            int c = 3;

            //            Console.WriteLine(@"1  2  3");
            //            Console.WriteLine("{0}  {1}  {2}",a,b,c);
            //            Console.WriteLine(a+"  "+b+"  "+c);
            //            Console.WriteLine("\n\n");
            //            //2.Вывести на экран числа 5, 10 
            //            //и 21 одно под другим.
            //            Console.WriteLine(@"1  
            //2 
            //3");
            //            Console.WriteLine("{0} \n{1} \n{2}\n", a, b, c);
            //            Console.WriteLine(a + "\n" + b + "\n" + c);

            //            //3.Дано расстояние в сантиметрах. Найти число 
            //            //полных метров в нем.
            //            int Santim;
            //            Console.WriteLine("Введите число в сантиметрах что бы получить число полных метров в нем!");
            //            Santim = Convert.ToInt32(Console.ReadLine());
            //            Santim /= 100;
            //            Console.WriteLine("Число полных метров = "+Santim+"\n");

            //            //4.С некоторого момента прошло 234 дня.
            //            //Сколько полных недель прошло за этот период ?
            //            Console.WriteLine("C некоторого дня прошло 234 дня!");
            //            int Day = 234;
            //            int Nedely = 7;
            //            int Week;
            //            Week = Day / Nedely;
            //            Console.WriteLine("Кол-во полных недель = "+Week+" !");

            //5.Дано двузначное число. Найти:
            //a.число десятков в нем;
            //b.число единиц в нем;
            //c.сумму его цифр;
            //d.произведение его цифр
            //    Console.WriteLine("Введите двузначное число! ");
            //    int Chislo;
            //    int A,B,C,D;
            //    Chislo = Convert.ToInt32(Console.ReadLine());
            //    A = Chislo;
            //    A /= 10;
            //    Console.WriteLine("Кол-во десятков в нем = "+A);
            //    B = Chislo;
            //    Console.WriteLine("Кол-во едениц в нем = " + B);           
            //    C=B%10+A;
            //    Console.WriteLine("Сумма его цифр = "+C);
            //    D =B % 10 * A;
            //    Console.WriteLine("Произведение его цифр = " + D);
            //    Console.ReadLine();


            //6.Вычислить значение логического выражения при следующих 
            //значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            //bool A=true;
            //bool B=false;
            //bool C=false;

            //Console.WriteLine(A || B);

            //Console.WriteLine(A && B);

            //Console.WriteLine(C || B);

            //7.Даны радиус круга и сторона 
            //квадрата.У какой фигуры площадь больше ?

            //double SKvadrat;
            //double RKruga;

            //Console.WriteLine("Введи сторону квадрата");
            //SKvadrat =Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Радиус круга");
            //RKruga = Convert.ToDouble(Console.ReadLine());
            //if (SKvadrat * SKvadrat > 3.14 * RKruga * RKruga)
            //{
            //    Console.WriteLine("Сторона квадрата больше");
            //}
            //else
            //{
            //    Console.WriteLine("Радиус круга больше");
            //}

            //8.Даны объемы и массы двух тел из разных материалов. 
            //Материал какого из тел имеет большую плотность ?

            //int MassaPT;//Масса первого тела
            //int MassaVT;//Масса воторого тела
            //int VolumePT;//Обьем первого тела
            //int VolumeVT;//Обьем воторого тела
            //int Example1;//Решение для первого тела
            //int Example2;//Решение для второго тела

            //Console.WriteLine("Введите массу первого тела");
            //MassaPT = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите массу воторого тела");
            //MassaVT = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите обьем первого тела");
            //VolumePT = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите обьем воторого тела");
            //VolumeVT = Convert.ToInt32(Console.ReadLine());
            //Example1 = MassaPT / VolumePT;
            //Example2 = MassaVT / VolumeVT;

            //if (Example1 > Example2)
            //{
            //    Console.WriteLine("Плотность первого тела больше");
            //}
            //else
            //{
            //    Console.WriteLine("Плотность воторого тела больше");
            //}

            //9.Известны сопротивления двух несоединенных друг с другом 
            //участков электрической цепи и напряжение на каждом из них.
            //По какому участку протекает меньший ток
            //int U1;//Напряжение первого участка
            //int R1;//Сопротивление первого участка

            //int U2;//Напряжение второго участка
            //int R2;//Сопротивление второго участка

            //int Example1;//Решение для первого участка
            //int Example2;//Решение для второго участка

            //Console.WriteLine("Напряжение первого участка");
            //U1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Сопротивление первого участка");
            //R1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Напряжение второго участка");
            //U2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Сопротивление второго участка");
            //R2 = Convert.ToInt32(Console.ReadLine());

            //Example1 = U1 / R1;
            //Example2 = U2 / R2;

            //if (Example1 < Example2)
            //{
            //    Console.WriteLine("По первому участку протикает меньший ток");
            //}
            //else
            //{
            //    Console.WriteLine("По второму участку протикает меньший ток");

            //}

            //10.Напечатать "столбиком": 
            //a.все целые числа от 20 до 35;
            //b.квадраты всех целых чисел от 10 до b
            //(значение b вводится с клавиатуры; b > 10);
            //c.третьи степени всех целых чисел от a до 50
            //(значение a вводится с клавиатуры; a < 50);
            //d.все целые числа от a до b(значения a и b
            //вводятся с клавиатуры; b > a).

            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            int B;
            B = Convert.ToInt32(Console.ReadLine());
             
            
        }

    }
}
