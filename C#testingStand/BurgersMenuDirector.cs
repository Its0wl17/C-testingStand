using Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class BurgersMenuDirector
    {
        private readonly IMenuBuilder _menuBuilder;

        public BurgersMenuDirector(IMenuBuilder menuBuilder)
        {
            _menuBuilder = menuBuilder;
        }

        public void Build()
        {
            _menuBuilder
                .BuildHeader()
                .BuildBody()
                .BuildFooter();      
        }
    }
}
