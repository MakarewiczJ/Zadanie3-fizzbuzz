using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Zadanie3.Models;

namespace Zadanie3.Pages
{
    public class SessionModel : PageModel
    {
        public Class Class { get; set; }
        public void OnGet()
        {
            var SessionClass = HttpContext.Session.GetString("SessionClass");
            if (SessionClass != null)
                Class = JsonConvert.DeserializeObject<Class>(SessionClass);
        }
    }
}
