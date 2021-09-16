using ShitStain.Other;
using UnityEngine;

namespace ShitStain.Modules
{
    class Zoom : Module
    {
        public Zoom() : base("Zoom", "Visual", "Look at things that are far away")
        {
            
        }

        float orig;

        public override void onEnable()
        {
            base.onEnable();
            orig = Camera.current.fieldOfView;
            Camera.current.fieldOfView = 30.0f;
        }

        public override void onDisable()
        {
            base.onDisable();
            Camera.current.fieldOfView = orig;
        }
    }
}