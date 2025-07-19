using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.API
{
    public class Request
    {
        public int choice { get; set; }
        public Request(int choice)
        {
            this.choice = choice;
        }
    }
}
