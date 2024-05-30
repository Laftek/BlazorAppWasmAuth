using Microsoft.AspNetCore.Identity;

namespace BlazorAppWasmAuth.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<IdentityRoleClaim<string>> Claims { get; set; }
    }
}
