using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TestUI
{
    [Dependency(ReplaceServices = true)]
    public class TestUIBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TestUI";
    }
}
