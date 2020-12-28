using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Deadline { get; set; }
        public IssueState State { get; set; }
        public bool IsUrgent { get; set; }

        public int? AssignedToId { get; set; }
        public Person AssignedTo { get; set; }
    }

    public enum IssueState { Todo, Doing, Done }
}
