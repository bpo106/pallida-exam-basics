using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class CandyShop
    {
        protected int sugar;
        protected int amount;
        protected int price;
        protected int income = 0;

        public static Candy CANDY = new Candy();
        public static Lollipop LOLLIPOP = new Lollipop();

        public CandyShop()
        {
        }

        public CandyShop(int sugar)
        {
            this.sugar = sugar;
        }

        public virtual void CreateSweets (CandyShop product)
        {
            if (sugar < product.sugar)
            {
                Console.WriteLine("Not enough sugar to produce this many products");
            }
            else
            {
                product.amount++;
                sugar -= product.sugar;
            }
        }

        public void PrintInfo ()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops. Income: {2}$, sugar: {3}gr", CANDY.amount, LOLLIPOP.amount, income, sugar);
        }

        public void Raise(int amount)
        {
            CANDY.price += amount;
            LOLLIPOP.price += amount;
        }
        
        public void Sell (CandyShop product, int amount)
        {
            if (product.amount < amount)
            {
                Console.WriteLine("Not enough products stored");
            }
            else
            {
                product.amount -= amount;
                income += product.amount * product.price;
            }
        }

        public void BuySugar (int amount)
        {
            if (income < (int)(amount * 0.1))
            {
                Console.WriteLine("Not enough money to buy this much sugar");
            }
            else
            {
                income -= (int)(amount * 0.1);
                sugar += amount;
            }
        }
    }
}
