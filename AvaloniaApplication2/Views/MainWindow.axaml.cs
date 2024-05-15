using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace AvaloniaApplication2.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ButtonClicked(object source, RoutedEventArgs args)
        {
            Debug.WriteLine($"Click!   Celsius={celsius.Text}");

            if (Double.TryParse(celsius.Text, out double C))
            {
                var F = C * (9d / 5d) + 32;
                fahrenheit.Text = F.ToString("0.0");
            }
            else
            {
                celsius.Text = "0";
                fahrenheit.Text = "0";
            }
        }
        public void CelTextChanged(object source, RoutedEventArgs args)
        {
            Debug.WriteLine($"cel!   Celsius={celsius.Text}");

            if (Double.TryParse(celsius.Text, out double C))
            {
                var F = C * (9d / 5d) + 32;
                fahrenheit.Text = F.ToString("0.0");
            }
            else
            {
                celsius.Text = "0";
                fahrenheit.Text = "0";
            }
        }
        public void CelTextChanged2(object source, KeyEventArgs  args)
        {
            Debug.WriteLine("skokjjisisd");
            
            CelTextChanged(source, args);
        }
        public void TitleSytleEvent_Enter(object source, PointerEventArgs args)
        {

            var random = new Random();
            var Str_color = String.Format("#{0:X6}", random.Next(0x1000000));
            // Example output: "#A197B9"

            title.Foreground = new SolidColorBrush(Color.Parse(Str_color));
        }
        public void TitleSytleEvent_Exit(object source, PointerEventArgs args)
        {
            title.Foreground = new SolidColorBrush(Color.Parse("#ff0ff0"));

        }

    }
}