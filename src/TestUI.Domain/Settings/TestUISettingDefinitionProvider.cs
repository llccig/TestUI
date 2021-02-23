using Volo.Abp.Settings;

namespace TestUI.Settings
{
    public class TestUISettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TestUISettings.MySetting1));
        }
    }
}
