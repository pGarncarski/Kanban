using Kanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Common
{
    public class Consts
    {
        public static Dictionary<IssueState, string> IssueStates { get; } = new Dictionary<IssueState, string>
        {
            {IssueState.Todo, "do zrobienia" },
            {IssueState.Doing, "robione" },
            {IssueState.Done, "zrobione" }
        };
    }
}
