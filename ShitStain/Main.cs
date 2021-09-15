using UnityEngine;
using ShitStain.Utils;
using ShitStain.Other;

namespace ShitStain
{
    class Main : MonoBehaviour
    {
        private void Start()
        {
            if (DebugConsole.IsDevEnvironment())
                DebugConsole.Write("A developer environment was detected, so a console was allocated for debug purposes.");

            DebugConsole.Write("Injected! Initializing modules...");
            Manager.InitModules();
        }

        private void Update()
        {
            foreach (Module module in Manager.modules)
            {
                module.forever();
                if (module.enabled)
                {
                    module.onUpdate();
                }
            }
        }

        private void OnGUI()
        {
            foreach (Module module in Manager.modules)
            {
                if (module.enabled)
                    module.onRender();
            }
        }
    }
}
