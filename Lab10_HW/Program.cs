using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Ugol ugol = new Ugol(60, 20, 15);
            ugol.ToRadians();
            Console.ReadKey();
        }

        class Ugol

        {
            double grad, min, sec;
            double rad;
            public double Grad
            {
                set
                {
                    if (value < 360)
                    {
                        grad = value;
                    }
                    else
                    {
                        Console.WriteLine("Неверно задан угол");
                    }
                }
                get
                {
                    return grad;
                }
            }
            public double Min
            {
                set
                {
                    if (value < 60)
                    {
                        min = value;
                    }
                    else
                    {
                        Console.WriteLine("Неверно заданы минуты");
                    }
                }
                get
                {
                    return min;
                }
            }
            public double Sec
            {
                set
                {
                    if (value < 60)
                    {
                        sec = value;
                    }
                    else
                    {
                        Console.WriteLine("Неверно заданы секунды");
                    }
                }
                get
                {
                    return sec;
                }
            }
            public double ToRadians
            {
                set
                {
                    rad = value * Math.PI / 2;
                }

                get
                {
                    return rad;
                }
            }

            public Ugol(double grad, double min, double sec)
            {
                Grad = grad;
                Min = min;
                Sec = sec;
                Console.WriteLine("Угол {0} градусов, {1} минут,{2} секунд", Grad, Min, Sec);
                Console.WriteLine("Угол в радианах", Grad, Min, Sec);
            }
            




            //{
            //    Console.WriteLine("Угол {0} градусов, {1} минут,{2} секунд", Grad, Min, Sec);
            //}






            //public static class NumericExtensions
            //{
            //    public static double ToRadians(this double val)
            //    {
            //        return (Math.PI / 180) * val;
            //    }
            //}

        }

    }
}





//class Program
//{
//    static void Main(string[] args)
//    {
//        Cat cat = new Cat("Мурка", "черный", -1);
//        cat.Say();
//        Console.ReadKey();
//    }
//}
//class Cat
//{
//    public string Name { get; set; }
//    public string Color { get; set; }
//    int age;

//    public int Age
//    {
//        set
//        {
//            if (value > 0)
//            {
//                age = value;
//            }
//            else
//            {
//                Console.WriteLine("Возраст должен быть больше 0");
//            }
//        }
//        get
//        {
//            return age;
//        }

//    }
//    public Cat(string name, string color, int age)
//    {
//        Name = name;
//        Color = color;
//        Age = age;

//    }
//    public void Say()
//    {
//        Console.WriteLine("Мяу меня зовут {0}, У меня {1} цвет. Мне {2} год", Name, Color, Age);
//    }
//}
