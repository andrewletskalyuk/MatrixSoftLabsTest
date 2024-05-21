using Microsoft.AspNetCore.Identity;

namespace MatrixSoft.Core.Models;


//TODO: we can add all props what need's
public class AspNetUser : IdentityUser
{
    public int UserType { get; set; }

    public int ConfirmedTerms { get; set; }
}
