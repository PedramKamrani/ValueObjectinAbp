using avv.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace avv.Permissions;

public class avvPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(avvPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(avvPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<avvResource>(name);
    }
}
