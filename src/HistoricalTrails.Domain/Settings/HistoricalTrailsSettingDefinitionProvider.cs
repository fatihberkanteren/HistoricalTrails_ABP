using Volo.Abp.Settings;

namespace HistoricalTrails.Settings;

public class HistoricalTrailsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HistoricalTrailsSettings.MySetting1));
    }
}
