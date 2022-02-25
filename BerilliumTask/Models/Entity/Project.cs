using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerilliumTask.Models.Entity
{
    public class Project : BaseEntity
    {
        public string img { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
    }
}
