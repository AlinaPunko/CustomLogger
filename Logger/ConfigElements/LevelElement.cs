using System.Configuration;

namespace Logger.ConfigElements
{
    public class LevelElement : ConfigurationElement
    {
        const string MinLevelPropertyName = "minLevel";

        [ConfigurationProperty(MinLevelPropertyName, DefaultValue = "Info", IsRequired = true)]
        public string MinLevel => (string)this[MinLevelPropertyName];
    }
}
