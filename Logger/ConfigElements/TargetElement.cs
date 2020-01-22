using System.Configuration;

namespace Logger.ConfigElements
{
    public class TargetElement : ConfigurationElement
    { 
        const string LOGGER_TYPE = "loggerType";
        const string FILE_NAME = "fileName";

        [ConfigurationProperty(LOGGER_TYPE, DefaultValue = "", IsRequired = true)]
        public string LoggerType
        {
            get { return (string)this[LOGGER_TYPE]; }
        }

        [ConfigurationProperty(FILE_NAME, DefaultValue = "", IsRequired = false)]
        public string FileName
        {
            get { return (string)this[FILE_NAME]; }
        }
    }
}
