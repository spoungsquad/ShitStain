using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Other.Settings
{
    class ToggleSetting : ModuleSetting
    {
        public bool toggled;
        public ToggleSetting(bool toggled, string name, Module module) : base(name, module)
        {
            this.toggled = toggled;
        }
    }
}
