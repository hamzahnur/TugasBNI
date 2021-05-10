﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class ResponseVM<Entity>
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public Entity Result { get; set; }
    }
}
