using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TurAppen.Model;
using TurAppen.ViewModel;

namespace TurAppen.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        private readonly TurDBContext dbContext;


         
        [BindProperty]
        public RegisterViewModel registerViewModel { get; set; }
        
        public RegisterModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, TurDBContext db_c)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;

            dbContext = db_c;
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var u = new ApplicationUser()
                {
                    UserName = registerViewModel.Email,
                    Email = registerViewModel.Email
                };

                var result = await userManager.CreateAsync(u, registerViewModel.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(u, false);
                    return RedirectToPage("Index");
                }
            }
            return Page();
            
        }
        public void OnGet()
        {
            
        }
    }
}
