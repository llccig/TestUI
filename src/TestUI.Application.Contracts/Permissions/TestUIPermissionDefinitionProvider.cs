using TestUI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TestUI.Permissions
{
    public class TestUIPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TestUIPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TestUIPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TestUIResource>(name);
        }
    }
}
