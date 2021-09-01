﻿using System;
using UnityEngine;
using System.Collections.Generic;
using ShitStain.Other;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitStain.Modules
{
    class Nuker : Module
    {
        public Nuker() : base("Nuker", "World", "Break every destructable object")
        {

        }

        public override void onUpdate()
        {
            Hitable[] objects = UnityEngine.Object.FindObjectsOfType(typeof(Hitable)) as Hitable[];
            foreach (Hitable obj in objects)
                ClientSend.PlayerHitObject(1000, obj.GetId(), 3, new Vector3(0, 0, 0), 3);
        }
    }
}