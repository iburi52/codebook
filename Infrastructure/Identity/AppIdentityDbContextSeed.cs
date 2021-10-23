using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Test",
                    Email = "test@test.com",
                    UserName = "test@test.com",
                    Address = new Address
                    {
                        FirstName = "test",
                        LastName = "test",
                        Street = "丸の内1丁目",
                        City = "千代田区",
                        State = "東京都",
                        ZipCode = "100-0005"
                    }
                };

                await userManager.CreateAsync(user, "Password1¥");
            }
        }
    }
}