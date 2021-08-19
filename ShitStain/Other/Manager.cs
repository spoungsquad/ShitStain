using System.Collections.Generic;

namespace ShitStain.Other
{
    class Manager
    {
        public static List<Module> modules;
        public static List<string> categories;

        public static void InitModules()
        {
            // add module

            foreach (Module module in modules)
            {
                if (!categories.Contains(module.category))
                    categories.Add(module.category); // gang shit

                if (module.name == "ClickGUI" || module.name == "Arraylist")
                    module.onEnable();
            }
        }
    }
}
