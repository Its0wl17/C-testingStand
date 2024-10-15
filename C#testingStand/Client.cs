using Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class Client
    {
        public void TestBurger()
        {

            List<BurgersMenu> burgersMenus = new()
            {
                new BurgersMenu { Name = "Flopper", Price = 250 },
                new BurgersMenu { Name = "CheesBurger", Price = 450 },
                new BurgersMenu { Name = "MeatBurger", Price = 650}
            };

            StringBurgerBuilder stringbuilder = new StringBurgerBuilder(burgersMenus);

            BurgerBuilder builder = new BurgerBuilder(burgersMenus);

            ClientBurgerDirector client = new ClientBurgerDirector();

            var FlopperDirector = new FlopperDirector(builder);
            FlopperDirector.Build();
            var flopperburger = builder.GetBurger();

            var CheeseDirector = new CheeseBurgerDirector(stringbuilder);
            CheeseDirector.Build();
            var cheeseburger = stringbuilder.BuildBurger();

            Console.WriteLine(cheeseburger);



        }


    }
}
