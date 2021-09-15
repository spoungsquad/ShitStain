using UnityEngine;
using ShitStain.Other;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class ChestAura : Module
    {
        public ChestAura() : base("ChestAura", "Player", "Automatically open chests in a set radius")
        {

        }

        List<Chest> chestList = new List<Chest>();

        public override void onUpdate()
        {
            Chest[] chests = Object.FindObjectsOfType(typeof(Chest)) as Chest[];

            if (chests.Length != 0 && chests.Length != chestList.Count)
            {
                PlayerMovement movement = Object.FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
                Vector3 pos = movement.transform.position;

                Chest current = chests[0];
                foreach (Chest next in chests)
                {
                    Vector3 currentVector = pos - current.transform.position;
                    Vector3 nextVector = pos - next.transform.position;

                    if (nextVector.sqrMagnitude < currentVector.sqrMagnitude && !chestList.Contains(next))
                    {
                        current = next;
                        chestList.Add(current);
                    }
                }

                if ((pos - current.transform.position).sqrMagnitude < 100)
                    ClientSend.RequestChest(current.id, true);
            }
        }
    }
}
