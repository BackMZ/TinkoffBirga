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

            Sber = new Companies("Сбер", "Вологда", "sber@ya.ru", "1234567890");
            SberStock = new Stocks(Sber.CompanyID, Sber.NameCompany, 100);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(
                $"ID компании: {SberStock.CompanyID}\n" +
                $"Название компании: {Sber.NameCompany}\n" +
                $"Цена акции: {SberStock.Cost}\n" +
                $"Динамика: {SberStock.Dynamic}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SberStock.ChangeCost(20);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SberStock.ChangeCost(-20);
        }
    }
}
