using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BankProject.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BankProjectUser class
public class BankProjectUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

