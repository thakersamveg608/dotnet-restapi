using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LandonApi.Filters
{
    public class RequireHttpsOrClassAttribute : RequireHttpsAttribute
    {
        public RequireHttpsOrClassAttribute()
        {
        }

        protected override void HandleNonHttpsRequest(AuthorizationFilterContext filterContext)
        {
            base.HandleNonHttpsRequest(filterContext);
            filterContext.Result = new StatusCodeResult(400);
        }
    }
}
