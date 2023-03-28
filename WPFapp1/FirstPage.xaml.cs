using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        colorsTableAdapter colours = new colorsTableAdapter();
        int a;
        public FirstPage()
        {
            InitializeComponent();
            ColoursDataGrid.ItemsSource = colours.GetData();
            ColoursDataGrid.DisplayMemberPath = "color_name";
        }

        private void AddColour_Button_Click(object sender, RoutedEventArgs e)
        {
            object color_id = (ColoursDataGrid.SelectedItem as DataRowView).Row[0]; 
            colours.DeleteQuery(Convert.ToInt32(color_id));
        }

        private void MyInputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Convert.ToString(a);
            //MyInputBox.Text = a;
        }
    }
}
