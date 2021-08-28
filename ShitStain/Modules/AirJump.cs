using ShitStain.Other;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShitStain.Modules
{
    class AirJump : Module
    {
        public AirJump() : base("AirJump", "Movement", "Jump in the air")
        {

        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

            PlayerManager manager = Object.FindObjectOfType(typeof(PlayerManager)) as PlayerManager;
            manager.DamagePlayer(1);
        }
    }
}
