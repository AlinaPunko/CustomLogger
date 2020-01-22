using System.Configuration;

namespace Logger.ConfigElements
{
    public class LevelElement : ConfigurationElement
    {
        const string MIN_LEVEL = "minLevel";

        [ConfigurationProperty(MIN_LEVEL, DefaultValue = "Info", IsRequired = true)]
        public string MinLevel
        {
            get { return (string)this[MIN_LEVEL]; }
        }
    }
}
