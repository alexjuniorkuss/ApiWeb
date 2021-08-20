using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Teacher : BaseModel
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
    }
}
