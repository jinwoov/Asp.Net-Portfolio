using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public EmailInfo EmailInfo { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Console.WriteLine(EmailInfo);
        }
    }

    public class EmailInfo
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
