using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public DateTime DateTime{ get; set; }
        public int Importance { get; set; }
        public int Status { get; set; }
    }
}
