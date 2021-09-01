using ShitStain.Other;
using ShitStain.Utils;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class NoExhaust : Module
    {
        public NoExhaust() : base("NoExhaust", "Player", "Never lose stamina")
        {

        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
            PlayerStatus status = PrivateAccess.GetPrivateProperty(movement, "playerStatus") as PlayerStatus;
            status.stamina = status.maxStamina;
        }
    }
}
