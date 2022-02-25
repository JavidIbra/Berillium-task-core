using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerilliumTask.Models.Entity
{
    public class Banner : BaseEntity
    {
        public string Image { get; set; }
        public string Text { get; set; }
    }
}
