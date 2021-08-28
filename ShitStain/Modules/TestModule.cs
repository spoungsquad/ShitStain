using ShitStain.Other;
using ShitStain.Utils;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShitStain.Modules
{
    class TestModule : Module
    {
        public TestModule() : base("TestModule", "Test", "Testing module for testing purposes")
        {

        }

        public override void onEnable()
        {
            base.onEnable();
            DebugConsole.Write("Works!");
        }

        public override void onRender()
        {
            Render.DrawString(new Vector2(0, 0), "Test works!", false);
        }
    }
}
