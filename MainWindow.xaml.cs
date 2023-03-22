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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xamldsdsads
    /// </summary>dfsfsddsadas
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            ColumnDefinition gridCol3 = new ColumnDefinition();

            this.dynamicGrid.ColumnDefinitions.Add(gridCol1);
            this.dynamicGrid.ColumnDefinitions.Add(gridCol2);
            this.dynamicGrid.ColumnDefinitions.Add(gridCol3);

            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(45);
            RowDefinition gridRow2 = new RowDefinition();
            gridRow2.Height = new GridLength(45);
            RowDefinition gridRow3 = new RowDefinition();
            gridRow3.Height = new GridLength(45);
            this.dynamicGrid.RowDefinitions.Add(gridRow1);
            this.dynamicGrid.RowDefinitions.Add(gridRow2);
            this.dynamicGrid.RowDefinitions.Add(gridRow3);

            TextBlock txtBlock1 = BlackTextBox(1);
            txtBlock1.Text = "Hello";
            Grid.SetRow(txtBlock1, 0);
            Grid.SetColumn(txtBlock1, 0);

            this.dynamicGrid.Children.Add(txtBlock1);


            // Zero Polygon


        }

        private static TextBlock BlackTextBox(int Number)
        {

            TextBlock txtBlock1 = new TextBlock();
            txtBlock1.Text = Number.ToString();
            txtBlock1.FontSize = 16;
            txtBlock1.FontWeight = FontWeights.Bold;
            txtBlock1.Foreground = new SolidColorBrush(Colors.White);
            txtBlock1.VerticalAlignment = VerticalAlignment.Center;
            txtBlock1.HorizontalAlignment = HorizontalAlignment.Center;
            return txtBlock1;
        }


    }

    public class MyMarkupExtension : MarkupExtension
    {
        public MyMarkupExtension() { }
        public String FirstStr { get; set; }
        public String SecondStr { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return FirstStr + " " + SecondStr;
        }
    }

}
