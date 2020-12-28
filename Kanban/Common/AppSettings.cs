using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Common
{
    public class AppSettings
    {
        public bool ResetDatabase { get; set; } = false;
        public string SqlProvider { get; set; } = "sqlserver";
    }
}
