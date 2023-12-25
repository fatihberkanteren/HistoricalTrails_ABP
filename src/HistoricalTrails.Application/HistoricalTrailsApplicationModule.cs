﻿using HistoricalTrails.HistoricalPlaces;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace HistoricalTrails;

[DependsOn(
    typeof(HistoricalTrailsDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(HistoricalTrailsApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class HistoricalTrailsApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<HistoricalTrailsApplicationModule>();
        });
        //context.Services.AddScoped<IHistoricalPlacesAppService>(
        //   sp => sp.GetRequiredService<HistoricalPlacesAppService>()
    }
}
