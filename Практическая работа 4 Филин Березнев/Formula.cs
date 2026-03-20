using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Практическая_работа_4_Филин_Березнев
{
    public static class Formula
    {
        /// <summary>
        /// Этот метод рассчитывает значение 1-й функции
        /// </summary>
        /// <param name="x">Значение x</param>
        /// <param name="y">Значение y</param>
        /// <param name="z">Значение z</param>
        /// <returns>Значение функции</returns>
        public static double first(double x, double y, double z)
        {
            double num_1 = (Math.Pow(x, y + 1) + Math.Pow(Math.E, y - 1))
                /
            (1 + x * Math.Abs(y - Math.Tan(z)));

            double num_2 = (1 + Math.Abs(y - x));

            double num_3 = Math.Pow(Math.Abs(y - x), 2) / 2;

            double num_4 = Math.Pow(Math.Abs(y - x), 3) / 3;

            double result = num_1 * num_2 + num_3 - num_4;

            return Math.Round(result, 4);
        }

        /// <summary>
        /// Этот метод рассчитывает значение 2-й функции
        /// </summary>
        /// <param name="x">Значение x</param>
        /// <param name="i">Значение i</param>
        /// <param name="func">Код функции f(x)</param>
        /// <returns>Значение функции</returns>
        public static double second(double x, double i, int func)
        {
            double fx;
            switch (func)
            {
                case 1:
                    fx = Math.Sinh(x);
                    break;
                case 2:
                    fx = Math.Pow(x, 2);
                    break;
                case 3:
                    fx = Math.Pow(Math.E, x);
                    break;
                default:
                    MessageBox.Show("Ошибка в номере функции");
                    return -1;
            }

            if (x > 0 && Math.Abs(i) % 2 == 1)
            {
                return second_cond_1(fx, i);
            }
            else if (x < 0 && i % 2 == 0)
            {
                return second_cond_2(fx, i);
            } 
            else
            {
                return second_cond_3(fx, i);
            }
        }

        static double second_cond_1(double fx, double i)
        {
            return Math.Round(i * Math.Abs(Math.Sqrt(fx)), 4);
        }

        static double second_cond_2(double fx, double i)
        {
            return Math.Round(i / 2 * Math.Sqrt(Math.Abs(fx)), 4);
        }

        static double second_cond_3(double fx, double i)
        {
            return Math.Round(Math.Sqrt(Math.Abs(i * fx)), 4);
        }
        /// <summary>
        ///  рассчитывает значение 3-й функции
        /// </summary>
        /// <param name="b_znach">Значение b</param>
        /// <param name="dx_znach">Значение dx</param>
        /// <param name="x0_znach">Значение x0</param>
        /// <param name="xk_znach">Значение  xk</param>
        /// <returns>Значение функции</returns>
        public static double third_func(double x, double b)
        {
            return Math.Round(0.001 * Math.Pow(Math.Abs(x), 2.5) + Math.Log(Math.Abs(x - b)), 4);
        }

    }
}
