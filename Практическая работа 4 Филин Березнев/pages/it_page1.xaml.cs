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
            switch(check_valid_data(x_znach.Text, y_znach.Text, z_znach.Text))
            {
                case 1:
                    MessageBox.Show("Произошло деление на 0, вселенная начинает схлопываться");
                    break;
                case 2:
                    MessageBox.Show("У тебя была одна задача ввести число в каждое поле и ты ее провалил");
                    break;
                
            }
        }

        /// <summary>
        /// Этот метод преобразует введеные данные на 1-й странице для их дальнейшего рассчета и в случае успеха записывает ответ в поле с ответом
        /// </summary>
        /// <param name="x_znach">Значение текста введеное в поле x</param>
        /// <param name="y_znach">Значение текста введеное в поле y</param>
        /// <param name="z_znach">Значение текста введеное в поле z</param>
        /// <returns>Код выполнения функции (если 0, то все успешно; если > 0 то код завершения функции)</returns>
        public int check_valid_data(string x_znach, string y_znach, string z_znach)
        {
            try
            {
                double x = double.Parse(x_znach);
                double y = double.Parse(y_znach);
                double z = double.Parse(z_znach);
                if (-1 == x * Math.Abs(y - Math.Tan(z)))
                {
                    return 1;
                }
                otvet.Text = Formula.first(x, y, z).ToString();
                return 0;
            }
            catch
            {
                return 2;
            }
            
        }

    }
}
