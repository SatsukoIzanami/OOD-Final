﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Final.Interfaces;

namespace OOD_Final.Actions
{
    public class SneakAttack : IAction
    {
        public string Attack() => "Makes a sneak attack from behind!";
    }
}
