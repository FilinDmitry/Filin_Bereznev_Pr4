using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_работа_4_Филин_Березнев.pages
{
    /// <summary>
    /// Логика взаимодействия для it_page1.xaml
    /// </summary>
    public partial class it_page1 : Page
    {
        List<TextBox> textBoxes;

        public it_page1()
        {
            InitializeComponent();
            textBoxes = new List<TextBox> { x_znach, y_znach, z_znach, otvet};
        }

        private void otchistit_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox tb in textBoxes)
            {
                tb.Text = "";
            }
        }

        private void vichislit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(x_znach.Text);
                double y = double.Parse(y_znach.Text);
                double z = double.Parse(z_znach.Text);
                if (-1 == x * Math.Abs(y - Math.Tan(z)))
                {
                    MessageBox.Show("Произошло деление на 0, вселенная начинает схлопываться");
                    return;
                }
                otvet.Text = Formula.first(x, y, z).ToString();
            }
            catch 
            {
                MessageBox.Show("У тебя была одна задача ввести целое число в каждое поле и ты ее провалил");
            }
        }
    }
}
