using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class Menu
    {
        private readonly List<string> _menusteps;

        public Menu(List<string> menusteps)
        {
            _menusteps = menusteps;
        }

        public override string ToString() =>
           new StringBuilder()
            .Append(_menusteps)
            .ToString();
    }
}
