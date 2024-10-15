using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private readonly List<string> _burger;

        private readonly List<string> _burgerMenu;

        private readonly IEnumerable<BurgersMenu> _infos;

        public BurgerBuilder(IEnumerable<BurgersMenu> info)
        {
            _burgerMenu = new List<string>();
            _infos = info;
            _burger = new List<string>();
        }

        public void BuildUpBun()
        {
            _burger.Add($"\nToasted bun with sesame");
        }

        public void BuildTomatoes()
        {
            _burger.Add($"\nRed spice tomatoes");
        }

        public void BuildCheese()
        {
            _burger.Add("\nCheese");
        }

        public void BuildOnion()
        {
            _burger.Add($"\nOnion rings");
        }

        public void BuildCucumber()
        {
            _burger.Add($"\nCucumber slices");
        }

        public void BuildCabbage()
        {
            _burger.Add($"\nCabbage");
        }

        public void BuildMeatCutlet()
        {
            _burger.Add($"\nBeef cutlet");
        }
        
        public void BuildDownBun()
        {
            _burger.Add($"\nToasted down bun");
        }

        public void BuildHeader()
        {
            _burgerMenu.Add($"BURGERS MENU - {DateTime.Now}\n\n");

            _burgerMenu.Add("\n--------------------------------------------------------------------------------------");

        }

        public void BuildBody()
        {
            _burgerMenu.Add(
                string.Join(Environment.NewLine,
                _infos.Select(i =>
                $"\nBurger: {i.Name} \t\tPrice: {i.Price}$ \t")));
        }

        public void BuildFooter()
        {
            _burgerMenu.Add("\n--------------------------------------------------------------------------------------\n");
        }

        public Menu GetMenu()
        {
            return new Menu(_burgerMenu);
        }

        public Burger GetBurger()
        {

            return new Burger(_burger);  
        }
    }
}
