using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public interface IBurgerBuilder
    {
        void BuildUpBun();
        void BuildTomatoes();
        void BuildCheese();
        void BuildOnion();
        void BuildCucumber();
        void BuildCabbage();
        void BuildMeatCutlet();
        void BuildDownBun();
        
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
        
    }
}
