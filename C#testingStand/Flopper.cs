using Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class Flopper
    {
        private readonly IBurgerBuilder _burgerBuilder;

        public Flopper(IBurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }

        public void BuildFlopperBurger()
        {
            _burgerBuilder.BuildUpBun()
                          .BuildTomatoes()
                          .BuildOnion()
                          .BuildCucumber()
                          .BuildCabbage()
                          .BuildCheese()
                          .BuildMeatCutlet()
                          .BuildDownBun();
        }
    }
}
