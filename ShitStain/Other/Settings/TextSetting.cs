using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Other.Settings
{
    class TextSetting : ModuleSetting
    {
        public string text;
        public TextSetting(string text, string name, Module module) : base(name, module)
        {
            this.text = text;
        }
    }
}
