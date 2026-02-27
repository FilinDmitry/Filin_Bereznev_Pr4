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

        public it_pages3()
        {
            InitializeComponent();
            ChartPayments.ChartAreas.Add(new ChartArea("main"));

            
        }


        private void UpdateChart(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}


