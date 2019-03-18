using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LambdaForum.Localization
{
    public static class LambdaForumLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LambdaForumConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LambdaForumLocalizationConfigurer).GetAssembly(),
                        "LambdaForum.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
