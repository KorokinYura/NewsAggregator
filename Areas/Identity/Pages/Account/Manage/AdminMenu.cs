using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsAggregator.Data;
using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregator.Areas.Identity.Pages.Account.Manage
{
    public class AdminMenu : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public AdminMenu(ApplicationDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public List<AppUser> Moderators { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            List<AppUser> moders = new List<AppUser>();

            foreach (var user in _db.AppUsers)
            {
                if (await _userManager.IsInRoleAsync(user, "Moderator"))
                    moders.Add(user);
            }

            Input = new InputModel
            {
                Moderators = moders
            };

            return Page();
        }
    }
}
