using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LPSDocument.Localization
{
    public static class LPSDocumentLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LPSDocumentConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LPSDocumentLocalizationConfigurer).GetAssembly(),
                        "LPSDocument.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
