using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public LoginModel(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string? ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            public bool RememberMe { get; set; }
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                var roles = await _userManager.GetRolesAsync(user);

                // Chuyển hướng theo vai trò
                if (roles.Contains("Manager"))
                    return RedirectToPage("/Manager/Dashboard");
                else if (roles.Contains("Waiter"))
                    return RedirectToPage("/Waiter/Home");
                else if (roles.Contains("Chef"))
                    return RedirectToPage("/Chef/Home");
                else if (roles.Contains("Cashier"))
                    return RedirectToPage("/Cashier/Home");
                else if (roles.Contains("Customer"))
                    return RedirectToPage("/Customer/Home");
                else
                    return RedirectToPage("/Index"); // fallback

            }

            ErrorMessage = "Login failed. Please check your credentials.";
            return Page();
        }
    }
}
