using UnityEngine;
using ShitStain.Other;
using ShitStain.Other.Settings;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class Killaura : Module
    {
        public Killaura() : base("Killaura", "Combat", "Hits enemies around you (extremely fast)")
        {
            
        }

        public override void onUpdate()
        {
            PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
            Mob[] mobList = Object.FindObjectsOfType(typeof(Mob)) as Mob[];
            Vector3 pos = movement.transform.position;
            foreach (Mob mob in mobList)
            {
                Vector3 mobpos = mob.transform.position;

                Vector3 distanceVector = pos - mobpos;

                if (distanceVector.sqrMagnitude < 100.0f)
                {
                    ClientSend.PlayerDamageMob(mob.id, 10, 1.0f, 1, pos, 0);
                }
            }
        }
    }
}
