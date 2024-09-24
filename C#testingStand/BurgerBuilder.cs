using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public BurgerBuilder()
        {
            _burger = new();
        }

        public IBurgerBuilder BuildUpBun()
        {
            _burger.UpBun =
                $"\nToasted bun with sesame";
            return this;
        }

        public IBurgerBuilder BuildTomatoes()
        {
            _burger.Tomatoes =
                $"\nRed spice tomatoes";
            return this;
        }

        public IBurgerBuilder BuildCheese()
        {
            _burger.Cheese =
                "\nCheese";

            return this;
        }

        public IBurgerBuilder BuildOnion()
        {
            _burger.Onion =
                $"\nOnion rings";
            return this;
        }

        public IBurgerBuilder BuildCucumber()
        {
            _burger.Cucumber =
                $"\nCucumber slices";
            return this;
        }

        public IBurgerBuilder BuildCabbage()
        {
            _burger.Cabbage =
                $"\nCabbage";

            return this;
        }

        public IBurgerBuilder BuildMeatCutlet()
        {
            _burger.MeatCutlet =
                $"\nBeef cutlet";
            return this;
        }
        
        public IBurgerBuilder BuildDownBun()
        {
            _burger.DownBun =
                $"\nToasted down bun";
            return this;
        }

        public Burger GetBurger()
        {
            Burger burger = _burger;

            _burger = new();

            return burger;
        }
    }
}
