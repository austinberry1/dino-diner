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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {

        public NavigationService NavigationService {get;set;}
        public OrderControl()
        {            
            InitializeComponent();
        }

        /// <summary>
        /// for  seeing selection changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (OrderItems.SelectedItems is Side side)
            {    
                NavigationService?.Navigate(new SideSelection(side));
            }


        }


        public void OnRemoveItem(object sender, RoutedEventArgs args)
        {
          if(DataContext is Order order)
            {
                if(OrderItems.SelectedItem is IOrderItem item)
                {
                    order.Remove(item);
                }
            }
            

        }

        
    }
}
