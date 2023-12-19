using HistoricalTrails.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HistoricalTrails.Permissions;

public class HistoricalTrailsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var historicalTrailsGroup = context.AddGroup(HistoricalTrailsPermissions.GroupName, L("Permission:HistoricalTrails"));

        var historicalPlacesPermission = historicalTrailsGroup.AddPermission(HistoricalTrailsPermissions.HistoricalPlaces.Default, L("Permission:HistoricalPlaces"));
        historicalPlacesPermission.AddChild(HistoricalTrailsPermissions.HistoricalPlaces.Create, L("Permission:HistoricalPlaces.Create"));
        historicalPlacesPermission.AddChild(HistoricalTrailsPermissions.HistoricalPlaces.Edit, L("Permission:HistoricalPlaces.Edit"));
        historicalPlacesPermission.AddChild(HistoricalTrailsPermissions.HistoricalPlaces.Delete, L("Permission:HistoricalPlaces.Delete"));

        var customersPermission = historicalTrailsGroup.AddPermission(HistoricalTrailsPermissions.Customers.Default, L("Permission:Customers"));
        customersPermission.AddChild(HistoricalTrailsPermissions.Customers.Create, L("Permission:Customers.Create"));
        customersPermission.AddChild(HistoricalTrailsPermissions.Customers.Edit, L("Permission:Customers.Edit"));
        customersPermission.AddChild(HistoricalTrailsPermissions.Customers.Delete, L("Permission:Customers.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HistoricalTrailsResource>(name);
    }
}
