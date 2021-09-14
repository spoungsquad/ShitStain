using UnityEngine;
using ShitStain.Other;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class Stuck : Module
    {
        public Stuck() : base("Stuck", "Movement", "Become stuck")
        {

        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

            movement.GetRb().velocity = new Vector3(0, -10, 0);
            movement.GetRb().useGravity = false;
        }
    }
}
