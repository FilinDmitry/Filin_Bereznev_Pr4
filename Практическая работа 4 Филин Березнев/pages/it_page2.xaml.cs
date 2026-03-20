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
    /// Логика взаимодействия для it_page2.xaml
    /// </summary>
    public partial class it_page2 : Page
    {
        List<TextBox> textBoxes;
        int selected_func = 1;
        public it_page2()
        {
            InitializeComponent();
            textBoxes = new List<TextBox> { x_znach, i_znach, otvet };
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
            if(check_valid_data(x_znach.Text, i_znach.Text, selected_func) == 1)
            {
                MessageBox.Show("Чтобы понять что ты сделал не так, то прочитай всплывающие подсказки, а лучше документацию");
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Content)
            {
                case "sh(x)":
                    selected_func = 1;
                    break;
                case "x^2":
                    selected_func = 2;
                    break;
                case "e^x":
                    selected_func = 3;
                    break;
            }
        }

        public int check_valid_data(string x_znach, string i_znach, int selected_func)
        {
            try
            {
                double x = double.Parse(x_znach);
                double i = double.Parse(i_znach);
                otvet.Text = Formula.second(x, i, selected_func).ToString();
                return 0;
            }
            catch
            {
                return 1;
            }
        }
    }
}
