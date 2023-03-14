
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace HBIC_Official.Code
{
    public static class Extensions
    {
        public static void AddUpdateClaim(this IPrincipal currentPrincipal, ClaimsPrincipal principal, string key, string value)
        {
            var identity = currentPrincipal.Identity as ClaimsIdentity;
            if (identity == null)
                return;

            var existingClaim = identity.FindFirst(key);
            if (existingClaim != null)
                identity.RemoveClaim(existingClaim);

            identity.AddClaim(new Claim(key, value));

            principal.AddIdentity(identity);

        }
    }
}
