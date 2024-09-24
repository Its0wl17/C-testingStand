using Burgers;
using System.IO;

List<BurgersMenu> burgersMenus = new()
{
    new BurgersMenu { Name = "Flopper", Price = 250 },
    new BurgersMenu { Name = "CheesBurger", Price = 450 },
    new BurgersMenu { Name = "MeatBurger", Price = 650}
};

var builderBurger = new BurgerBuilder();

var builderMenu = new MenuBuilder(burgersMenus);

var director = new BurgersMenuDirector(builderMenu);
director.Build();
var menu = builderMenu.GetMenu();
Console.WriteLine($" {menu} ");

int Answer = Convert.ToInt32(Console.ReadLine());

switch (Answer)
{
    case 1:
        {
            Flopper flopperBurger = new Flopper(builderBurger);
            flopperBurger.BuildFlopperBurger();
            var buildflopper = builderBurger.GetBurger();
            Console.WriteLine(buildflopper);
            break;
        }

    case 2:
        {
            CheeseBurger cheeseBurger = new CheeseBurger(builderBurger);
            cheeseBurger.BuildCheeseBurger();
            var buildcheese = builderBurger.GetBurger();
            Console.WriteLine(buildcheese);
            break;
        }
}


