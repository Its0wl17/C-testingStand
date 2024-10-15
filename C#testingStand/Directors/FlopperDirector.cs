using Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class FlopperDirector
    {
        private readonly IBurgerBuilder _burgerBuilder;

        public FlopperDirector(IBurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }

        public void Build()
        {
            _burgerBuilder.BuildUpBun();
            _burgerBuilder.BuildTomatoes();
            _burgerBuilder.BuildOnion();
            _burgerBuilder.BuildCucumber();
            _burgerBuilder.BuildCabbage();
            _burgerBuilder.BuildCheese();
            _burgerBuilder.BuildMeatCutlet();
            _burgerBuilder.BuildDownBun();
        }
    }
}
