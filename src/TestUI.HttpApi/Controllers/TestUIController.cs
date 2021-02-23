using TestUI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestUI.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TestUIController : AbpController
    {
        protected TestUIController()
        {
            LocalizationResource = typeof(TestUIResource);
        }
    }
}