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

using Practica3_changed.Hobby_shopDataSetTableAdapters;

namespace Practica3_changed
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Shop_Employees_ProductsViewTableAdapter adapter = new Shop_Employees_ProductsViewTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            Hobby_shopDataGrid.ItemsSource = adapter.GetData();
        }
        private void OpenNewWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
        }
    }
}
