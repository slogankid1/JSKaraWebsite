using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace JSKaraWebsite.Pages
{
    public class AboutModel : PageModel
    {
        private readonly IConfiguration _config;
        public string Message { get; set; }
        public string otherMessage { get; set; }

        public AboutModel(IConfiguration config)
        {
            this._config = config;
        }

        public void OnGet()
        {
            Message = "Your application description page.";
            otherMessage = _config["Message"];
        }
    }
}
