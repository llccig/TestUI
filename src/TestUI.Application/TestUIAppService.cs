using System;
using System.Collections.Generic;
using System.Text;
using TestUI.Localization;
using Volo.Abp.Application.Services;

namespace TestUI
{
    /* Inherit your application services from this class.
     */
    public abstract class TestUIAppService : ApplicationService
    {
        protected TestUIAppService()
        {
            LocalizationResource = typeof(TestUIResource);
        }
    }
}
