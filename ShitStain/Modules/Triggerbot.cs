using UnityEngine;
using ShitStain.Other;
using ShitStain.Utils;

namespace ShitStain.Modules {
    class Triggerbot : Module
    {
		public Triggerbot() : base("Triggerbot", "Combat", "Automatically hits mobs you're looking at") {

		}

		public override void onUpdate() {
			PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

			RaycastHit raycastHit;
			if (Physics.Raycast(movement.transform.position, movement.transform.forward, out raycastHit)) {
				Mouse.MouseEvent(Mouse.MouseFlags.LeftUp | Mouse.MouseFlags.LeftDown); // shoots anything, we'll figure that out
			}
		}
    }
}
