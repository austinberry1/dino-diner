﻿using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{

    /// <summary>
    /// THis calls is for water and is used to modify or change the water
    /// </summary>
    public class Water : Drinks
    {




        /// <summary>
        /// this sends the description as a tostring
        /// </summary>
        public string Discription
        {

            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// PropertyChanged event handeler; notifys of changes to the Price,Description,and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        //Helper Function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets any special preperatoin instruction
        /// </summary>
        public string[] Special
        {

            get
            {
                List<string> special = new List<string>();
                
               if(Ice) special.Add("Add Ice");
               if(lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }

        /// <summary>
        /// THis is to indicate wether a lemon is in the drink by default
        /// </summary>
        public bool lemon = false;

        /// <summary>
        /// This is to indicate if ice is in the drink by default
        /// </summary>
        public bool Ice = true;


        private List<string> ingredients;


        public override double Price
        {
            get
            {
                return .10;
            }
        }

        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        public override List<string> Ingredients
        {
            get
            {

                List<string> ingredients = new List<string>();

                ingredients.Add("Water");
                if(lemon) ingredients.Add("Lemon");




                return ingredients;
            }


        }


        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            if (size == Size.Large)
            {
                return "Large Water";
            }
            if (size == Size.Medium)
            {
                return "Medium Water";
            }

            return "Small Water";


        }


        /// <summary>
        /// This is the water constructor to setup def Cal.,Ing., and Price.
        /// </summary>
        public Water()
        {

            this.Calories = 0;
            ingredients = new List<string>() { "Water" };
            this.Price = 0.10;
            

        }



        /// <summary>
        /// Sets up a variable of type Size to access the Size class
        /// </summary>
        public Size size;

        /// <summary>
        /// Public getter and setter for Size
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {

                size = value;



                Price = .10;
                this.Calories = 0;



            }

        }
        /// <summary>
        /// This method Adds lemon to the drink
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            this.Ingredients.Add("Lemon");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");


        }

        /// <summary>
        /// This method Removes the ice from the drink
        /// </summary>
        /// <returns>THis returns a false to show that there is no ice</returns>
        public override bool HoldIce()
        {
            Ice = false;
            return false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");

        }
    }
}
