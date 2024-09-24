using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public interface IMenuBuilder
    {
        IMenuBuilder BuildHeader();

        IMenuBuilder BuildBody();

        IMenuBuilder BuildFooter();
    }
}
