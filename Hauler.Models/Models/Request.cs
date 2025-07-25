using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.API
{
    public class Request(int choice = 0)
    {
        public int Choice { get; set; } = choice;
    }
}
