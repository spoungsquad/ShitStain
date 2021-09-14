using UnityEngine;
using ShitStain.Other;
using ShitStain.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class AutoSprint : Module
    {
        public AutoSprint() : base("AutoSprint", "Movement", "Automatically sprint")
        {

        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

            PrivateAccess.SetPrivateProperty(movement, "sprinting", true);
        }
    }
}
