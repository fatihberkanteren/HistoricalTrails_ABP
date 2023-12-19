using System.Threading.Tasks;
using HistoricalTrails.Localization;
using HistoricalTrails.MultiTenancy;
using HistoricalTrails.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace HistoricalTrails.Web.Menus;

public class HistoricalTrailsMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<HistoricalTrailsResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                HistoricalTrailsMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        context.Menu.AddItem(
        new ApplicationMenuItem(
            "HistoricalTrails",
            l["Menu:HistoricalTrails"],
            icon: "fa fa-book"
    ).AddItem(
        new ApplicationMenuItem(
            "HistoricalTrails.HistoricalPlaces",
            l["Menu:HistoricalPlaces"],
            url: "/HistoricalPlaces"
        ).RequirePermissions(HistoricalTrailsPermissions.HistoricalPlaces.Default)
    )
);


        return Task.CompletedTask;
    }
}
