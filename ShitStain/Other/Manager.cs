using System.Collections.Generic;
using ShitStain.Utils;
using ShitStain.Modules;

namespace ShitStain.Other
{
    class Manager
    {
        public static List<Module> modules;
        public static List<string> categories;

        public static void InitModules()
        {
            modules = new List<Module>();
            categories = new List<string>();
            modules.Add(new AutoPickup());
            modules.Add(new Killaura());
            modules.Add(new LongJump());
            modules.Add(new NoExhaust());
            modules.Add(new NoHunger());
            modules.Add(new Nuker());
            modules.Add(new TestModule());
            modules.Add(new Aimbot());

            foreach (Module module in modules)
            {
                if (!categories.Contains(module.category))
                    categories.Add(module.category); // gang shit

                if (module.name == "ClickGUI" || module.name == "Aimbot")
                    module.onEnable();

            }
            DebugConsole.Write("All modules initialized successfully.");
        }
    }
}
