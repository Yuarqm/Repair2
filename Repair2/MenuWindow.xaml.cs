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
using System.Windows.Shapes;

namespace Repair2
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void EnterOrder_Click(object sender, RoutedEventArgs e)
        {
            new NewOrderWindow().Show();    
            this.Close();
        }

        private void EditOrder_Click(object sender, RoutedEventArgs e)
        {
            new EditOrderWindow().Show();
            this.Close();
        }

        private void ProccesOrder_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
