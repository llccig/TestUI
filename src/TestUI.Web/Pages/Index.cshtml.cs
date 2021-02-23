using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace TestUI.Web.Pages
{
    public class IndexModel : TestUIPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}