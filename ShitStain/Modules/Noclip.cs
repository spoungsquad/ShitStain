using ShitStain.Other;
using UnityEngine;

namespace ShitStain.Modules
{
    class Noclip : Module
    {
        public Noclip() : base("Noclip", "Player", "Disables your collision")
        {
            
        }

        public override void onUpdate() {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

            movement.GetRb().detectCollisions = false;
        }

        public override void onDisable()
        {
            base.onDisable();
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

            movement.GetRb().detectCollisions = true;
        }
    }
}