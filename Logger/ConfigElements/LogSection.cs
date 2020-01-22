using System.Configuration;

namespace Logger.ConfigElements
{
    public class LogSection : ConfigurationSection
    {
        const string TARGET = "target";
        const string LEVEL = "level";

        [ConfigurationProperty(TARGET, IsDefaultCollection = false)]
        public TargetElement Target
        {
            get { return (TargetElement)this[TARGET]; }
        }

        [ConfigurationProperty(LEVEL, IsDefaultCollection = false)]
        public LevelElement Level
        {
            get { return (LevelElement)this[LEVEL]; }
        }
    }
}
