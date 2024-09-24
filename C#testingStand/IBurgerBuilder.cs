using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder BuildUpBun();

        IBurgerBuilder BuildTomatoes();

        IBurgerBuilder BuildCheese();

        IBurgerBuilder BuildOnion();

        IBurgerBuilder BuildCucumber();

        IBurgerBuilder BuildCabbage();

        IBurgerBuilder BuildMeatCutlet();

        IBurgerBuilder BuildDownBun();
    }
}
