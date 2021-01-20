using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string IP { get; set; }
        public string Url { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
