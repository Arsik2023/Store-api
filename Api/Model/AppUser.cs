using Microsoft.AspNetCore.Identity;

namespace Api;

public class AppUser : IdentityUser
/* класс для доп полей в таблице  */
{
    public string FirstName { get; set; }
}
