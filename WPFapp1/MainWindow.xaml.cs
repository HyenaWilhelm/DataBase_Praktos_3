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
using WPFapp1.fovorite_colorDataSetTableAdapters;

namespace WPFapp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        colorsTableAdapter colours = new colorsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            colours.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPage1_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new FirstPage();
        }

        private void ButtonPage2_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new SecondPage();
        }
    }
}
