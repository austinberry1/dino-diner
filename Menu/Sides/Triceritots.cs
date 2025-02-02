﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{

    /// <summary>
    /// Class for the side Triceritots
    /// </summary>
    public class Triceritots : Side
    {

        private List<string> ingredients;


        /// <summary>
        /// Shows discription in a tostring
        /// </summary>
        public string Description
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
                special.Add("Size/Price Change");




                return special.ToArray();
            }
        }


        public override double Price
        {
            get
            {
                if (size == Size.Large) return 1.95;
                if (size == Size.Medium) return 1.45;
                return .99;
            }
        }

        public override uint Calories
        {
            get
            {
                if (size == Size.Large) return 590;
                if (size == Size.Medium) return 410;
                return 352;
            }
        }


        public override List<string> Ingredients
        {
            get
            {

                List<string> ingredients = new List<string>();

                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");


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
                return "Large Triceritots";
            }
            if (size == Size.Medium)
            {
                return "Medium Triceritots";
            }

            return "Small Triceritots";


        }



        /// <summary>
        /// This defigns the price, calories, and Ingredients of  Triceritots

        /// </summary>
        public Triceritots()
        {


            this.Price = 0.99;
            this.Calories = 352;
            ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }

        /// <summary>
        /// variable to accsess Size
        /// </summary>
        public Size size;

        /// <summary>
        /// Checks to see what size of side then add the new price and calories
        /// </summary>
        public override Size Size
        {

            set
            {

                size = value;
                switch (size)
                {

                    case Size.Large:
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Price/Size");
                        base.Size = value;
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Price/Size");
                        base.Size = value;
                        Price = 1.45;
                        Calories = 410;
                        break;

                }
            }



        }

    }
}