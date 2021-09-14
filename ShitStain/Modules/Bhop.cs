using UnityEngine;
using ShitStain.Other;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class Bhop : Module
    {
        public Bhop() : base("Bhop", "Movement", "Hop like a bunny")
        {

        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

            Vector2 move = new Vector2(Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));
            bool moving = move.magnitude > 0.001f;

            if (moving)
                movement.Jump();

            float calcYaw = (Camera.current.transform.eulerAngles.y + 90) * (Mathf.PI / 180);

            Vector3 moveVec3;
            float c = Mathf.Cos(calcYaw);
            float s = Mathf.Sin(calcYaw);
            move = new Vector2(move.x * c - move.y * s, move.x * s + move.y * c);
            moveVec3 = new Vector3(move.x * -50, movement.GetRb().velocity.y, move.y * 50);
            if (moving) movement.GetRb().velocity = moveVec3;
        }
    }
}
