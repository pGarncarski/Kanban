using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanban.Data;
using Kanban.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Kanban.Filters
{
    public class AuditLogFilterAttribute : Attribute, IActionFilter
    {
        private readonly KanbanContext _kanbanContext;

        public AuditLogFilterAttribute(KanbanContext kanbanContext)
        {
            _kanbanContext = kanbanContext;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var identity = context.HttpContext.User.Identity;
            var request = context.HttpContext.Request;

            _kanbanContext.AuditLogs.Add(new AuditLog()
            {
                IP = context.HttpContext.Connection.RemoteIpAddress.ToString(),
                Url = request.Path + request.QueryString,
                Timestamp = DateTime.Now,
                User = identity.IsAuthenticated ? identity.Name : "Anonymous",
            });
            _kanbanContext.SaveChanges();
        }
    }
}
