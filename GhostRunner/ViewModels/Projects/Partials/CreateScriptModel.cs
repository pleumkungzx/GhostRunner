﻿using GhostRunner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GhostRunner.ViewModels.Main.Partials
{
    public class CreateScriptModel
    {
        public Project Project { get; set; }

        public Script Script { get; set; }
    }
}