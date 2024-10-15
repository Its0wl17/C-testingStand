using Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class ClientBurgerDirector
    {
        private List<string> _ingridients = new List<string> { "Cheese", "Tomatoes", "Onion", "Cucumbers", "Cabbage", "MeatCutlet" };

        private List<string> _clientburger { get; set; }

        public ClientBurgerDirector()
        {
            _clientburger = new List<string>();
        }

        

        public void BuildClientBurger(BurgerBuilder burger)
        {
            foreach (var ingridient in _ingridients)
            {
                Console.WriteLine($"Wanna add {ingridient} in your burger? (yes or no)");

                string Answer = Console.ReadLine();

                if (Answer == "yes") 
                {
                    switch (ingridient)
                    {
                        case "Cheese\n":
                            {
                                burger.BuildCheese();
                                _clientburger.Add(ingridient);
                                break;
                            }
                        case "Tomatoes\n":
                            {
                                burger.BuildTomatoes();
                                _clientburger.Add(ingridient);
                                break;
                            }
                        case "Onion\n":
                            {
                                burger.BuildOnion();
                                _clientburger.Add(ingridient);
                                break;
                            }
                        case "Cucumbers\n":
                            {
                                burger.BuildCucumber();
                                _clientburger.Add(ingridient);
                                break;
                            }
                        case "Cabbage\n":
                            {
                                burger.BuildCabbage();
                                _clientburger.Add(ingridient);
                                break;
                            }
                        case "MeatCutlet\n":
                            {
                                burger.BuildMeatCutlet();
                                _clientburger.Add(ingridient);
                                break;
                            }
                    }
                }
            }
            var cookedburger = burger;
            cookedburger.GetBurger();
        }

        public List<string> GetCookedClientBruger()
        {
            return _clientburger;
        }
    }
}
