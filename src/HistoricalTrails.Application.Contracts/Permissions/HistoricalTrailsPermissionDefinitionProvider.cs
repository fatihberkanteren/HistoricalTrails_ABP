using HistoricalTrails.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HistoricalTrails.Permissions;

public class HistoricalTrailsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var historicalTrailsGroup = context.AddGroup(HistoricalTrailsPermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = historicalTrailsGroup.AddPermission(HistoricalTrailsPermissions.HistoricalPlaces.Default, L("Permission:Books"));
        booksPermission.AddChild(HistoricalTrailsPermissions.HistoricalPlaces.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(HistoricalTrailsPermissions.HistoricalPlaces.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(HistoricalTrailsPermissions.HistoricalPlaces.Delete, L("Permission:Books.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HistoricalTrailsResource>(name);
    }
}
