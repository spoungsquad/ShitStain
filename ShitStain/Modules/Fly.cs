using UnityEngine;
using ShitStain.Other;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class Fly : Module
    {
        public Fly() : base("Fly", "Movement", "...")
        {

        }

        public override void onEnable()
        {
            base.onEnable();
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
            movement.transform.position = movement.transform.position + new Vector3(0, 10, 0);
        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
            movement.grounded = false;
            movement.GetRb().useGravity = false;

            Vector2 move = new Vector2(Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));

            float calcYaw = (Camera.current.transform.eulerAngles.y + 90) * (Mathf.PI / 180);

            Vector3 moveVec3;
            float c = Mathf.Cos(calcYaw);
            float s = Mathf.Sin(calcYaw);
            move = new Vector2(move.x * c - move.y * s, move.x * s + move.y * c);

            float yVel = 0;

            if (Input.GetKey(KeyCode.Space))
                yVel = 1;
            else if (Input.GetKey(KeyCode.LeftControl))
                yVel = -1;
            else
                yVel = 0;

            moveVec3 = new Vector3(move.x * -50, yVel * 50, move.y * 50);
            movement.GetRb().velocity = moveVec3;
        }
    }
}
