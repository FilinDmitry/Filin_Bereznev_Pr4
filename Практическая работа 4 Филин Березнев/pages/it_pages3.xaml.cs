using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_работа_4_Филин_Березнев.pages
{
    
public partial class it_pages3 : Page
    {
        List<TextBox> textBoxes;
        Series currentSeries = new Series("Функция");
        public it_pages3()
        {
            InitializeComponent();
            textBoxes = new List<TextBox> { b_znach, x0_znach, xk_znacht, dx_znach, otvet };
            ChartF.ChartAreas.Add(new ChartArea("Main"));
            ChartF.Series.Add(currentSeries);
            currentSeries.IsValueShownAsLabel = false;
            currentSeries.ChartType = SeriesChartType.Spline;
            currentSeries.Color = System.Drawing.Color.Red;
            currentSeries.BorderWidth = 8;

        }

        private void vichislit_Click(object sender, RoutedEventArgs e)
        {
            switch(check_valid_data(b_znach.Text, dx_znach.Text, x0_znach.Text, xk_znacht.Text))
            {
                case 1:
                    MessageBox.Show("Ты ошибся тестировщик, баг в другом замке \n\nP.S. Если что ввод дробного числа через запятую");
                    break;
                case 2:
                    MessageBox.Show("атата, чо думал самый умный, dx = 0 низя");
                    break;
                case 3:
                    MessageBox.Show("Ты хочешь войти в бесконечный цикл, а ещё чего? Ищи баги в другом месте");
                    break;
                case 4:
                    MessageBox.Show("Я запрещаю вам делать пустой график\n@Джейсон Стэйтем");
                    break;
                case -1:
                    MessageBox.Show("Что-то пошло не так в вычислениях");
                    break;
            }
        }

        private void otchistit_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox tb in textBoxes)
            {
                tb.Text = "";
            }
        }

        public int check_valid_data(string b_znach, string dx_znach, string x0_znach, string xk_znach)
        {
            Series ourSeries = currentSeries;
            currentSeries.Points.Clear();
            double b, dx, x0, xk;
            bool b_, dx_, x0_, xk_;
            b_ = double.TryParse(b_znach, out b);
            dx_ = double.TryParse(dx_znach, out dx);
            x0_ = double.TryParse(x0_znach, out x0);
            xk_ = double.TryParse(xk_znach, out xk);
            if (!b_ || !dx_ || !x0_ || !xk_)
            {
                return 1;
            }
            if (dx == 0)
            {
                return 2;
            }

            if ((dx > 0 && x0 > xk) || (dx < 0 && x0 < xk))
            {
                return 3;
            }

            try
            {
                List<string> lst_y = new List<string>();
                double y;
                if (x0 > xk)
                {
                    if (x0 + dx < xk)
                    {
                        return 4;
                    }
                    while (x0 >= xk)
                    {
                        if (b != x0)
                        {
                            y = Formula.third_func(x0, b);
                            currentSeries.Points.AddXY(x0, y);
                            lst_y.Add(y.ToString());
                        }
                        else
                        {
                            y = Formula.third_func(x0 + 0.0001, b);
                            currentSeries.Points.AddXY(x0 + 0.0001, y);
                            lst_y.Add(y.ToString());
                            y = Formula.third_func(x0 - 0.0001, b);
                            currentSeries.Points.AddXY(x0 - 0.0001, y);
                            lst_y.Add(y.ToString());
                        }
                        x0 += dx;
                    }
                }
                else
                {
                    if (x0 + dx > xk)
                    {
                        return 4;
                    }
                    while (x0 <= xk)
                    {
                        if (b != x0)
                        {
                            y = Formula.third_func(x0, b);
                            currentSeries.Points.AddXY(x0, y);
                            lst_y.Add(y.ToString());
                        }
                        else
                        {
                            y = Formula.third_func(x0 + 0.0001, b);
                            currentSeries.Points.AddXY(x0 + 0.0001, y);
                            lst_y.Add(y.ToString());
                            y = Formula.third_func(x0 - 0.0001, b);
                            currentSeries.Points.AddXY(x0 - 0.0001, y);
                            lst_y.Add(y.ToString());
                        }
                        x0 += dx;
                    }
                }
                otvet.Text = String.Join("\n", lst_y);
                return 0;
            }
            catch {
                return -1;
            }

        }


    }
}


