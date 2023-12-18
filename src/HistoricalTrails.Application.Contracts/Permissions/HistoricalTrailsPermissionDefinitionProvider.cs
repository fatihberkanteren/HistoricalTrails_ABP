using HistoricalTrails.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HistoricalTrails.Permissions;

public class HistoricalTrailsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HistoricalTrailsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HistoricalTrailsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HistoricalTrailsResource>(name);
    }
}
