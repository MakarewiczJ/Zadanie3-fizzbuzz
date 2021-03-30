using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie3.Models;

namespace Zadanie3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Class Class { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            if(ModelState.IsValid)
            {
                if (Class.Liczba%3==0)
                {
                    Class.Wynik += "fizz";
                }
                if (Class.Liczba % 5 == 0)
                {
                    Class.Wynik += "buzz";
                }
                if (Class.Wynik == null)
                    Class.Wynik = String.Format("Liczba {0} nie spełnia kryteriów FizzBuzz", Class.Liczba);
                HttpContext.Session.SetString("SessionClass",
                    JsonConvert.SerializeObject(Class));
            }
        }
    }
}
