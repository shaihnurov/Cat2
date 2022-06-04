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

namespace Cat2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            cb1.Text = "1";
            cb2.Text = "1";
        }

        /// <summary>
        /// загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>


        private void bt(object sender, RoutedEventArgs e)
        {

            try
            {

                int inf = Convert.ToInt32(cb1.Text);
                int inf2 = Convert.ToInt32(cb2.Text);

                int Sum2 = inf * 20;
                int asd = Sum2 % 12;
                int asd2 = Sum2 / 12;
                int Sum1 = 24 + (inf - 2) * 4 + asd2;

                lgbt.Content = $"{Sum1} лет и {asd} месяцев";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
