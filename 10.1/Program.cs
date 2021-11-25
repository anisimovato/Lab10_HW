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
            double grad;
            double min;
            double sec;
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
            public Ugol(double grad, double min, double sec)
            {
                Grad = grad;
                Min = min;
                Sec = sec;
                //Console.WriteLine("Угол {0} градусов, {1} минут,{2} секунд", Grad, Min, Sec);
                
            }
            public void ToRadians()
            {
                rad = (Grad * Math.PI / 180 + Min * Math.PI / (180*60) + Sec * Math.PI /(180*3600));
                Console.WriteLine($"Угол в радианах= {rad}");
            }

            
        }

    }
}

            

        

