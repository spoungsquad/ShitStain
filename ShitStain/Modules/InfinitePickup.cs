using System;
using ShitStain.Other;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class InfinitePickup : Module
    {
        public InfinitePickup() : base("InfinitePickup", "Player", "Automatically picks up items")
        {

        }

        public override void onUpdate()
        {
            Item[] test2 = UnityEngine.Object.FindObjectsOfType(typeof(Item)) as Item[];

            foreach (Item it in test2)
            {
                ClientSend.PickupItem(it.objectID);
            }
        }
    }
}
