﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            InnerFrame.Navigate(typeof(DonutPage));
        }

        private void Donuts_Click(object sender, RoutedEventArgs e)
        {
            InnerFrame.Navigate(typeof(DonutPage));
        }

        private void Coffee_Click(object sender, RoutedEventArgs e)
        {
            InnerFrame.Navigate(typeof(CoffeePage));
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            InnerFrame.Navigate(typeof(SchedulePage));
        }

        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            InnerFrame.Navigate(typeof(CompletePage));
        }
    }
}
