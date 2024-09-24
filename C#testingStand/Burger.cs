using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
    public class Burger
    {
        private string _upbun { get; set; }
        private string _tomatoes { get; set; }
        private string _onion { get; set; }
        private string _cucumber { get; set; }
        private string _cabbage { get; set; }
        private string _cheese { get; set; }
        private string _meatcutlet { get; set; }
        private string _downbun { get; set; }

        public Burger(string upbun, string tomatoes, string onion, string cucumber, string cabbage, string cheese, string meatcutlet, string downbun)
        {
            _upbun = upbun;
            _tomatoes = tomatoes;
            _onion = onion;
            _cucumber = cucumber;
            _cabbage = cabbage;
            _cheese = cheese;
            _meatcutlet = meatcutlet;
            _downbun = downbun;

        }

        public override string ToString() =>
            new StringBuilder()
            .Append(_upbun)
            .Append(_tomatoes)
            .Append(_onion)
            .Append(_cucumber)
            .Append(_cabbage)
            .Append(_cheese)
            .Append(_meatcutlet)
            .Append(_downbun)
            .ToString();
    }
}
