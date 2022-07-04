using valueobj.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace valueobj.Permissions;

public class valueobjPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(valueobjPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(valueobjPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<valueobjResource>(name);
    }
}
