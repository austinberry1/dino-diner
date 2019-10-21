using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }





        [Fact]
        public void HoldOnionShouldNotifyOfSpecialChanged()
        {
            
            SteakosaurusBurger pbj = new SteakosaurusBurger();

            System.Action p = () =>
            {
                pbj.HoldMustard();
            };


        }

        [Fact]
        public void HoldPepperShouldNotifyOfSpecialChanged()
        {
            SteakosaurusBurger pbj = new SteakosaurusBurger();

            System.Action p = () =>
               {
                   pbj.HoldMustard();
               };
            
        }


        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {

            SteakosaurusBurger pbj = new SteakosaurusBurger();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            SteakosaurusBurger pbj = new SteakosaurusBurger();
            pbj.HoldKetchup();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                }



                );
        }



        [Fact]
        public void SpecialShouldHoldMustaed()
        {
            SteakosaurusBurger pbj = new SteakosaurusBurger();
            pbj.HoldMustard();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }



                );
        }

        [Fact]
        public void SpecialShouldHoldPickle()
        {
            SteakosaurusBurger pbj = new SteakosaurusBurger();
            pbj.HoldPickle();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Pickles", item);
                }



                );
        }


        [Fact]
        public void SpecialShouldHoldALl()
        {
            SteakosaurusBurger pbj = new SteakosaurusBurger();
            pbj.HoldPickle();
            pbj.HoldMustard();
            pbj.HoldKetchup();

            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Pickles", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }



                );
        }


    }




}
