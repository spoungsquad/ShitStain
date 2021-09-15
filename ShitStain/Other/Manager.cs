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
            modules.Add(new InfinitePickup());
            modules.Add(new Killaura());
            modules.Add(new LongJump());
            modules.Add(new NoExhaust());
            modules.Add(new NoHunger());
            modules.Add(new Nuker());
            modules.Add(new TestModule());
            modules.Add(new Aimbot());
            modules.Add(new TabGUI());
            modules.Add(new Arraylist());
            modules.Add(new Stuck());
            modules.Add(new AutoSprint());
            modules.Add(new Bhop());
            modules.Add(new Fly());
            modules.Add(new ChestAura());

            foreach (Module module in modules)
            {
                if (!categories.Contains(module.category))
                    categories.Add(module.category); // gang shit

                if (module.name == "TabGUI" || module.name == "Arraylist")
                    module.onEnable();

            }
            DebugConsole.Write("All modules initialized successfully. (" + modules.Count + " in total)");
        }

        public static Module[] GetModulesFromCategory(string category)
        {
            List<Module> temp = new List<Module>();
            foreach (Module module in modules)
            {
                if (module.category == category)
                    temp.Add(module);
            }
            return temp.ToArray();
        }
    }
}
