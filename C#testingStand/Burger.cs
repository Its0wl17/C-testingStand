using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class Burger
    {
        private readonly List<string> _ingridients;

        public Burger(List<string> ingridients)
        {
            _ingridients = ingridients;
        }

        public override string ToString() =>
            new StringBuilder()
            .Append(_ingridients)
            .ToString();
    }
}
