﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    
    public static class NumberTypes
    {
        private static int[] Reds = {1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36};
        /// <summary>
        /// Gives answer whether a number is red number or not
        /// </summary>
        /// <param name="num">Number to be check if it is red</param>
        /// <returns>True if red, otherwise False</returns>
        public static bool isRed(int num)
        {
            if (Reds.Contains(num)) return true;
            return false;
        }

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RowDefinition gridRow1 = new RowDefinition();
            RowDefinition gridRow2 = new RowDefinition();
            RowDefinition gridRow3 = new RowDefinition();
            this.dynamicGrid.RowDefinitions.Add(gridRow1);
            this.dynamicGrid.RowDefinitions.Add(gridRow2);
            this.dynamicGrid.RowDefinitions.Add(gridRow3);

            for (int i = 0; i < 8; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                this.dynamicGrid.ColumnDefinitions.Add(colDef);
            }

            for (int i = 0; i < 36; i++)
            {
                this.dynamicGrid.Children.Add(CreateElementToGrid(i));
            }

        }

        /// <summary>
        /// Everything that is connected to creatng number elements
        /// </summary>
        /// <param name="index">index of the element. Note that actual number is index + 1</param>
        /// <returns>Border element that contains button. This can be added to dynamicGrid</returns>
        private static CustomButton CreateElementToGrid(int index)
        {
            var button = new CustomButton
            {
                Title = (index + 1).ToString(),
                BackgroundColor = GetBackgroundColor(index),
                ForeGroundBrush = GetForegroundBrush(index)
            };

            Grid.SetColumn(button, getColumnNumber(index));
            Grid.SetRow(button, getRowNumber(index));
            return button;
        }

        public static SolidColorBrush GetBackgroundColor(int index)
        {
            if(NumberTypes.isRed(index+1)) return new SolidColorBrush(Colors.Red);
            else return new SolidColorBrush(Colors.Black);
        }

        public static Brush GetForegroundBrush(int index)
        {
            if (NumberTypes.isRed(index + 1)) return Brushes.Black;
            else return Brushes.White;
        }

        public static int getRowNumber(int index)
        {
            if (index % 3 == 0) return 2;
            if (index % 3 == 1) return 1;
            else return 0;
        }
        public static int getColumnNumber(int index)
        {
            return (int)(index / 3);
        }
    }
}
