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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int need_floor = 0;
        int floors = 0;
        int min_floor = 1;
        int curr_floor = 1;
        bool oppened = true;
        DispatcherTimer timer;
        private enum Sostoyanie
        {
            Up,
            Down,
            Waiting
        }
        Sostoyanie sostoyanie = Sostoyanie.Waiting;
        public MainWindow(int floors)
        {
            InitializeComponent();
            this.floors = floors;
            FloorNumber.Text = "1";

            for(int i = 0; i < floors; i++)
            {
                Button button= new Button();
                button.Content = i + 1;
                button.Click += FloorSelect;
                panelButtons.Children.Add(button); 
            }
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (curr_floor == need_floor)
            {
                ImageElevator.Source = new BitmapImage(new Uri("/Images/elevator_opened.png", UriKind.Relative));
                sostoyanie = Sostoyanie.Waiting;
                return;
            }

            if (sostoyanie == Sostoyanie.Down)
            {
                FloorNumber.Text = (int.Parse(FloorNumber.Text.ToString()) - 1).ToString();
                curr_floor--;
            }
            else if (sostoyanie == Sostoyanie.Up)
            {
                FloorNumber.Text = (int.Parse(FloorNumber.Text.ToString()) + 1).ToString();
                curr_floor++;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void FloorSelect(object sender, EventArgs e)
        {
            need_floor = int.Parse((sender as Button).Content.ToString());
            if(need_floor == curr_floor)
            {
                sostoyanie = Sostoyanie.Waiting;
            }
            else if (need_floor - curr_floor < 0)
            {
                sostoyanie = Sostoyanie.Down;
                ImageElevator.Source = new BitmapImage(new Uri("/Images/elevator_closed.png", UriKind.Relative));
                timer.Start();
            }
            else
            {
                sostoyanie = Sostoyanie.Up;
                ImageElevator.Source = new BitmapImage(new Uri("/Images/elevator_closed.png", UriKind.Relative));
                timer.Start();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(curr_floor < floors && !oppened)
            {
                curr_floor += 1;
                FloorNumber.Text = curr_floor.ToString();
            }
        }
    }
}
