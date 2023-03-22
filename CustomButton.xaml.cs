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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CustomButton.xaml
    /// </summary>
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Alert("You have clicked button");
        }

        public string Title { get; set; }
        public string Description { get; set; }

        public Brush BackgroundColor { get; set; } = new SolidColorBrush(Colors.Black);
        public Brush ForeGroundBrush { get; set; } = Brushes.White;
    }
}
