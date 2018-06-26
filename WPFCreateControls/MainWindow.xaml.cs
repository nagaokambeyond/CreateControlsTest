using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFCreateControls
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Height = SystemParameters.PrimaryScreenHeight - 100;
            Width = SystemParameters.PrimaryScreenWidth - 50;
            Left = (SystemParameters.PrimaryScreenWidth - Width) / 2;
            Top = (SystemParameters.PrimaryScreenHeight - Height) / 2;
            int count = 1;
            const double hh = 20;
            double xMax = Width / hh - 3;
            double yMax = Height / hh - 4;
            for (var y = 1; y <= yMax; y += 1)
                for (var x = 1; x <= xMax; x += 1)
                {
                    var ctl = new Button();
                    ctl.Width = hh;
                    ctl.Height = hh;
                    ctl.SetValue(Canvas.LeftProperty, x * hh);
                    ctl.SetValue(Canvas.TopProperty, y * hh);
                    ctl.Click += btn_click;
                    var tip = new ToolTip();
                    tip.Content = count.ToString();
                    ctl.SetValue(Canvas.ToolTipProperty, tip);
                    canv.Children.Add(ctl);
                    count += 1;
                }
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            var ctl = (Button)sender;
            ctl.Background = new SolidColorBrush(Colors.Black);
        }
    }
}
