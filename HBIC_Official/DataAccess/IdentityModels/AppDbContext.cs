using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.IdentityModels
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        
    }
}
