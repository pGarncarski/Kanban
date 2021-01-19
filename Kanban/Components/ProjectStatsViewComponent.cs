using Kanban.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Components
{
    [ViewComponent]
    public class ProjectStatsViewComponent : ViewComponent
    {
        private readonly KanbanContext _context;

        public ProjectStatsViewComponent(KanbanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var q =
                from issue in _context.Issues
                group issue by issue.State into issueStates
                select new { IssueState = issueStates.Key, Count = issueStates.Count() };

            var projectStats = await q.ToListAsync();
            var projectStatsModel = projectStats.ToDictionary(stat => stat.IssueState, stat => stat.Count);

            return View(projectStatsModel);
        }
    }
}
