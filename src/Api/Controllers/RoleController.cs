using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using be_patient_api;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/role")]
public class RoleController : ControllerBase
{
    private RoleManager<IdentityRole> _roleManager; 

    public RoleController(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }

    [HttpGet]
    public async Task<IActionResult> GetRoles()
    {
        return Ok(_roleManager.Roles.ToList());
    }
}