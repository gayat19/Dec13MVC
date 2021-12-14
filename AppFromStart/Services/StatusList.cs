using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Services
{
    public class StatusList : IListify
    {
        public ICollection<SelectListItem> GetList()
        {
            return new List<SelectListItem>
           {
               new SelectListItem{Text="Enrolled Already",Value="Enrolled"},
               new SelectListItem{Text="Registered> But yet to enrol",Value="Registered"},
               new SelectListItem{Text="Completed Course",Value="Completed"}
           };
        }
    }
}
