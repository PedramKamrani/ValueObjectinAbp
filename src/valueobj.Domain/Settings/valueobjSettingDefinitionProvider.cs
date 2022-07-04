using Volo.Abp.Settings;

namespace valueobj.Settings;

public class valueobjSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(valueobjSettings.MySetting1));
    }
}
