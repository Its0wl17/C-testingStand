using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class CheeseBurgerDirector
    {
        private readonly IBurgerBuilder _burgerBuilder;

        public CheeseBurgerDirector(IBurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }

        public void Build()
        {
            _burgerBuilder.BuildUpBun();
            _burgerBuilder.BuildCheese();
            _burgerBuilder.BuildMeatCutlet();
            _burgerBuilder.BuildCheese();
            _burgerBuilder.BuildMeatCutlet();
            _burgerBuilder.BuildDownBun();
        }
    }
}
