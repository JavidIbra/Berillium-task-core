using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerilliumTask.Models.Entity
{
    public class News : BaseEntity
    {
        public DateTime Time { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string BtnText { get; set; }
        public string BtnLink { get; set; }

    }
}
