using Volo.Abp.Settings;

namespace avv.Settings;

public class avvSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(avvSettings.MySetting1));
    }
}
