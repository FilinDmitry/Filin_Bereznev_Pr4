using System;
using System.Collections.Generic;
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
        public it_pages3()
        {
            InitializeComponent();
            textBoxes = new List<TextBox> { b_znach, x0_znach, xk_znacht, dx_znach, otvet };
            ChartF.ChartAreas.Add(new ChartArea("Main"));

            Series currentSeries = new Series("Функция")
            {
                IsValueShownAsLabel = true
            };
            ChartF.Series.Add(currentSeries);
            currentSeries.IsValueShownAsLabel = false;
            currentSeries.ChartType = SeriesChartType.Spline;
            currentSeries.Color = System.Drawing.Color.Red;
            currentSeries.BorderWidth = 8;

        }

        private void vichislit_Click(object sender, RoutedEventArgs e)
        {
            
            Series currentSeries = ChartF.Series.FirstOrDefault();
            currentSeries.Points.Clear();
            double b, dx, x0, xk;
            bool b_ = false, dx_ = false, x0_ = false, xk_ = false;
            
            b_ = double.TryParse(b_znach.Text, out b);
            dx_ = double.TryParse(dx_znach.Text, out dx);
            x0_ = double.TryParse(x0_znach.Text, out x0);
            xk_ = double.TryParse(xk_znacht.Text, out xk);
            if (!b_ || !dx_ || !x0_ || !xk_)
            {
                MessageBox.Show("Ты ошибся тестировщик, баг в другом замке \n\nP.S. Если что ввод дробного числа через запятую");
                return;
            }
                
            if (dx == 0)
            {
                MessageBox.Show("атата, чо думал самый умный, dx = 0 низя");
                return;
            }

            if ((dx > 0 && x0 > xk) || (dx < 0 && x0 < xk))
            {
                MessageBox.Show("Ты хочешь войти в бесконечный цикл, а ещё чего? Ищи баги в другом месте");
                return;
            }

            
            try
            {
                List<string> lst_y = new List<string>();
                double y;
                if (x0 > xk)
                {
                    if (x0 + dx < xk)
                    {
                        MessageBox.Show("Я запрещаю вам делать пустой график\n@Джейсон Стэйтем");
                        return;
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
                            y = Formula.third_func(x0 - 0.0001, b);
                            currentSeries.Points.AddXY(x0 - 0.0001, y);
                            lst_y.Add(y.ToString());
                            y = Formula.third_func(x0 + 0.0001, b);
                            currentSeries.Points.AddXY(x0 + 0.0001, y);
                            lst_y.Add(y.ToString());
                        }
                            x0 += dx;
                    }
                }
                else
                {
                    if (x0 + dx > xk)
                    {
                        MessageBox.Show("Я запрещаю вам делать пустой график\n@Джейсон Стэйтем");
                        return;
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
                            currentSeries.Points.AddXY(x0 - 0.0001,  y);
                            lst_y.Add(y.ToString());
                        }
                        x0 += dx;
                    }
                }
                otvet.Text = String.Join("\n", lst_y);
            }
            catch { MessageBox.Show("Что-то пошло не так в вычислениях"); }

        }

        private void otchistit_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox tb in textBoxes)
            {
                tb.Text = "";
            }
        }

        
    }
}


