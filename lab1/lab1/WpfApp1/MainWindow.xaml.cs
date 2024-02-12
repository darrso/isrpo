using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WpfApp1.Classes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int deposit;
        private string deposit_string= "Your deposit: {0}$";
        private string change_string = "Change: {0}$";
        private string result_string = "Beverage cost: {0}$";

        private string americano_image_path = @"/Images/Americano-ru.svg.png";
        private string capuchino_image_path = @"/Images/72621930_1301144383_63932230_Cappuccino.gif";
        private string espresso_image_path = @"/Images/Kofe-espresso.jpg";
        private string cocoa_image_path = @"/Images/b9c23b2b.jpg";

        Beverage beverage = null;
        public MainWindow()
        {
            InitializeComponent();
            deposit= 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox1.Text;
            try
            {
                int dep = int.Parse(text);
                deposit += dep;
                depositLabel.Content = String.Format(deposit_string, deposit);
            }
            catch(System.FormatException ex){
                MessageBox.Show("Error! Enter number");
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            coffeeImage.Source = new BitmapImage(new Uri(americano_image_path, UriKind.Relative));
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            coffeeImage.Source = new BitmapImage(new Uri(capuchino_image_path, UriKind.Relative));
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            coffeeImage.Source = new BitmapImage(new Uri(espresso_image_path, UriKind.Relative));
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            coffeeImage.Source = new BitmapImage(new Uri(cocoa_image_path, UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (AmericanoRadioButton.IsChecked == true) beverage = new Americano();
            else if (CappuccinoRadioButton.IsChecked == true) beverage = new Cappuchino();
            else if (EspressoRadioButton.IsChecked == true) beverage = new Espresso();
            else if (CocoaRadioButton.IsChecked == true) beverage = new Cocoa();

            if (SugarCheckBox.IsChecked == true) beverage = new Sugar(beverage);
            if (MilkCheckBox.IsChecked == true) beverage = new Milk(beverage);
            if (CinnamonCheckBox.IsChecked == true) beverage = new Cinnamon(beverage);

            double cost = beverage.cost();
            double change = deposit - cost;
            if(change < 0)
            {
                MessageBox.Show($"Not enough money\nResult price: {cost}$\nDeposit: {deposit}$", "Error");
                return;
            }
            changeLabel.Content = String.Format(change_string, deposit - cost);
            resultLabel.Content = String.Format(result_string, cost);
        }
    }
}
