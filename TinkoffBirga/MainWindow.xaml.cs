using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace TinkoffBirga
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Companies Sber;
        Stocks SberStock;

        public MainWindow()
        {
            InitializeComponent();

            Sber = new Companies("Sber", "Vologda", "Sber@a", "1234567890");
            SberStock = new Stocks(Sber.CompanyID, Sber.NameCompany, 1000);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            int newCost = rnd.Next(100, 2001);

            SberStock.ChangeCost(newCost);

            MessageBox.Show(
                $"Новая цена: {newCost}\n"+
                $"Текущая динамика: {SberStock.Dynamic}");
        }
    }
}
