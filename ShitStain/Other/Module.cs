using ShitStain.Other.Settings;
using ShitStain.Utils;
using System.Collections.Generic;

namespace ShitStain.Other
{
    class Module
    {
        public string name;
        public string category;
        public string description;
        public bool enabled = false;

        // settings
        public List<ModuleSetting> settings = new List<ModuleSetting>();

        // for arraylist
        public bool animating = false;
        public int progress = 1;

        public Module(string name, string category, string description)
        {
            this.name = name;
            this.category = category;
            this.description = description;
            DebugConsole.Write("Registered " + this.name);
        }

        public virtual void onEnable()
        {
            enabled = true;
            DebugConsole.Write(name + " was enabled");
        }
        public virtual void onDisable()
        {
            enabled = false;
            DebugConsole.Write(name + " was disabled");
        }
        public virtual void onUpdate() { }
        public virtual void onRender() { }

        public virtual void forever() { }

        public void registerSetting(ModuleSetting setting)
        {
            settings.Add(setting);
            DebugConsole.Write("Registered setting: " + setting);
        }
    }
}