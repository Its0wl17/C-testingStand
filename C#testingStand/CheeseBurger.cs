using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class CheeseBurger
    {
        private readonly IBurgerBuilder _burgerBuilder;

        public CheeseBurger(IBurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }

        public void BuildCheeseBurger()
        {
            _burgerBuilder.BuildUpBun()
                          .BuildCheese()
                          .BuildMeatCutlet()
                          .BuildCheese()
                          .BuildMeatCutlet()
                          .BuildDownBun();
        }
    }
}
