﻿using System;
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
using DinoDiner.Menu;



namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderList.NavigationService = OrderUI.NavigationService;
            

        }


        public void OnLoadCompleted(object sender,NavigationEventArgs args)
        {
            SetFrameContext();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameContext();
        }
        

        

        private void SetFrameContext()
        {
            FrameworkElement content = OrderUI.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderUI.DataContext;
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
          if(OrderUI.NavigationService.CanGoBack)
            {
                OrderUI.NavigationService.GoBack();
            }
            else
            {

                OrderUI.NavigationService.Navigate(new MenuCategorySelection());

            }
           
        }
    }
}
