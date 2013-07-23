﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coob.CoobEventArgs
{
    public class WorldUpdateEventArgs : ScriptEventArgs
    {
        public float DeltaTime { get; private set; }

        public WorldUpdateEventArgs(float dt) : base(null)
        {
            DeltaTime = dt;
        }
    }
}