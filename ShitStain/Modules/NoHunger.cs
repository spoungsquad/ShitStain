using ShitStain.Other;
using ShitStain.Utils;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class NoHunger : Module
    {
        public NoHunger() : base("NoHunger", "Player", "Never starve")
        {

        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
            PlayerStatus status = PrivateAccess.GetPrivateProperty(movement, "playerStatus") as PlayerStatus;
            status.hunger = status.maxHunger;
        }
    }
}
