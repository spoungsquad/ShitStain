using System;
using UnityEngine;
using ShitStain.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Other.Settings
{
    class ModuleSetting
    {
        public string name;
        public Module module;
        public ModuleSetting(string name, Module module)
        {
            this.name = name;
            this.module = module;
            DebugConsole.Write("Created " + name + " setting for " + module.name);
        }
    }

    public enum SettingType
    {
        Toggle,
        Text,
        Slider
    } // nice
}
