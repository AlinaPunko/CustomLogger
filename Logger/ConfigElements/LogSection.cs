using System.Configuration;

namespace Logger.ConfigElements
{
    public class LogSection : ConfigurationSection
    {
        private const string TargetPropertyName = "target";
        private const string LevelPropertyName = "level";

        [ConfigurationProperty(TargetPropertyName)]
        public TargetElement Target => (TargetElement)this[TargetPropertyName];

        [ConfigurationProperty(LevelPropertyName)]
        public LevelElement Level => (LevelElement)this[LevelPropertyName];
    }
}
