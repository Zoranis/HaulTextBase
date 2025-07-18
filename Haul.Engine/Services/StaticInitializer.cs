using Haul.Engine.Interfaces;
using HaulTextBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Services
{
    internal static class StaticInitializer : IInitializer
    {
        private IInitializer _initializer;

        public StaticInitializer(IInitializer initializer)
        {
            _initializer = initializer ?? throw new ArgumentNullException(nameof(initializer));
        }
        public static Place InitializePlace()
        {
            return _initializer.InitializePlace();
        }



    }
}
