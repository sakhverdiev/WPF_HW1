using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF_HW1 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            if (sender is Button btn)
            {
                Brush brush = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 255), (byte)random.Next(1, 255), (byte)random.Next(1, 255)));
                btn.Background = brush;
                string msg = $"Button {btn.Content}'s color code is {btn.Background}.";
                MessageBox.Show(msg, "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                grid.Children.Remove(btn);
                Title += $"{btn.Content} ";

            }
        }
    }
}