﻿using Volo.Abp.Settings;

namespace ToApp.Settings;

public class ToAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ToAppSettings.MySetting1));
    }
}
