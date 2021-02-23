using TestUI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TestUI.Web.Pages
{
    public abstract class TestUIPageModel : AbpPageModel
    {
        protected TestUIPageModel()
        {
            LocalizationResourceType = typeof(TestUIResource);
        }
    }
}