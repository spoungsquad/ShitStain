using ShitStain.Other;
using ShitStain.Utils;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class LongJump : Module
    {
        public LongJump() : base("LongJump", "Movement", "Jump really far")
        {

        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

            if (Input.GetAxisRaw("Vertical") == 0f || Input.GetAxisRaw("Horizontal") == 0f)
            {
                movement.GetRb().AddForce(movement.orientation.forward * Input.GetAxisRaw("Vertical") * 200);
                movement.GetRb().AddForce(movement.orientation.right * Input.GetAxisRaw("Horizontal") * 200);
            }
        }
    }
}
