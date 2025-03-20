using Microsoft.AspNetCore.Identity;

namespace be_patient_api;

public class User : IdentityUser
{
    public string FirstName {get; set;}

    public string LastName {get; set;}
}
