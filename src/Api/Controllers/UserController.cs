using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace be_patient_api;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private UserManager<User> _userManager;

    private RoleManager<IdentityRole> _roleManager;

    private PasswordHasher<User> passwordHasher = new();

    public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }

    [HttpPost("register")]
    public async Task<IdentityResult> RegisterUser([FromBody] RegistrationRequest registration)
    {
        User newUser = new User();
        newUser.UserName = registration.Email;
        newUser.Email = registration.Email;
        newUser.PasswordHash = passwordHasher.HashPassword(newUser, registration.Password);

        await _userManager.CreateAsync(newUser);

        return await _userManager.AddToRoleAsync(newUser, registration.Role);        
    }
}
