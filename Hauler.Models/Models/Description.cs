using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Game
{
    public class Description
    {
        public Dictionary<string,string> Text { get; set; }

        public Description()
        {
            Text = new();
        }
    }
}
