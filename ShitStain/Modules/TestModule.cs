﻿using System;
using ShitStain.Other;
using ShitStain.Utils;
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
    }
}