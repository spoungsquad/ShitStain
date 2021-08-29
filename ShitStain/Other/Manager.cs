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
            modules.Add(new TestModule());

            foreach (Module module in modules)
            {
                if (!categories.Contains(module.category))
                    categories.Add(module.category); // gang shit

                if (module.name == "ClickGUI" || module.name == "Arraylist")
                    module.onEnable();

            }
            DebugConsole.Write("All modules initialized successfully.");
        }
    }
}
