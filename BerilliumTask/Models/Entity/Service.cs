﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerilliumTask.Models.Entity
{
    public class Service : BaseEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink{ get; set; }
    }
}
