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
        List<string> Ingridients = new List<string> { "Cheese", "Tomatoes", "Onion", "Cucumbers", "Cabbage", "MeatCutlet" };

        List<string> ClientBurger = new List<string>();

        public void BuildClientBurger(BurgerBuilder burger)
        {
            foreach (var ingridient in Ingridients)
            {
                Console.WriteLine($"Wanna add {ingridient} in your burger? (yes or no)");

                string Answer = Console.ReadLine();

                if (Answer == "yes") 
                {
                    switch (ingridient)
                    {
                        case "Cheese":
                            {
                                burger.BuildCheese();
                                ClientBurger.Add(ingridient);
                                break;
                            }
                        case "Tomatoes":
                            {
                                burger.BuildTomatoes();
                                ClientBurger.Add(ingridient);
                                break;
                            }
                        case "Onion":
                            {
                                burger.BuildOnion();
                                ClientBurger.Add(ingridient);
                                break;
                            }
                        case "Cucumbers":
                            {
                                burger.BuildCucumber();
                                ClientBurger.Add(ingridient);
                                break;
                            }
                        case "Cabbage":
                            {
                                burger.BuildCabbage();
                                ClientBurger.Add(ingridient);
                                break;
                            }
                        case "MeatCutlet":
                            {
                                burger.BuildMeatCutlet();
                                ClientBurger.Add(ingridient);
                                break;
                            }
                    }
                }

            }
        }

        public List<string> GetCookedClientBruger()
        {
            return ClientBurger;
        }
    }
}
