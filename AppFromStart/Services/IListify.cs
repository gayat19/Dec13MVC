using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Services
{
    public interface IListify
    {
        ICollection<SelectListItem> GetList();
    }
}
