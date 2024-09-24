using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class MenuBuilder : IMenuBuilder
    {
        private Menu _burgerMenu;

        private readonly IEnumerable<BurgersMenu> _infos;

        public MenuBuilder(IEnumerable<BurgersMenu> info)
        {
            _burgerMenu = new();
            _infos = info;
        }
        public IMenuBuilder BuildHeader()
        {
            _burgerMenu.Header =
                $"BURGERS MENU - {DateTime.Now}\n\n";

            _burgerMenu.Header +=
                "\n--------------------------------------------------------------------------------------";
            return this;
        }

        public IMenuBuilder BuildBody()
        {
            _burgerMenu.Body =
                string.Join(Environment.NewLine,
                _infos.Select( i =>
                $"\nBurger: {i.Name} \t\tPrice: {i.Price} \t"));

            return this;
        }

        public IMenuBuilder BuildFooter()
        {
            _burgerMenu.Footer =
                "\n--------------------------------------------------------------------------------------\n";

            _burgerMenu.Footer +=
                "Choose a burger: \n1.Flopper\n2.CheeseBurger\n3.MeatBurger\n4.PersonalBurger ";

            return this;
        }

        public Menu GetMenu()
        {
            Menu menu = _burgerMenu;

            _burgerMenu = new();

            return menu;
        }
    }
}
