using ShitStain.Other;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class Aimbot : Module
    {
        public Aimbot() : base("Aimbot", "Combat", "If you don't know what this does, stop cheating")
        {
            
        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
            Mob[] mobList = Object.FindObjectsOfType(typeof(Mob)) as Mob[];
            Vector3 pos = movement.transform.position;
            Mob currentMob = mobList[0];

            foreach (Mob nextMob in mobList)
            {
                if ((nextMob.transform.position - pos).sqrMagnitude < (currentMob.transform.position - pos).sqrMagnitude)
                {
                    currentMob = nextMob;
                }
            }

            Vector3 lookPos = currentMob.transform.position;
            movement.transform.LookAt(lookPos);
        }
    }
}
