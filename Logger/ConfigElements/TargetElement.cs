using System.Configuration;

namespace Logger.ConfigElements
{
    public class TargetElement : ConfigurationElement
    {
        private const string LoggerTypePropertyName = "loggerType";
        private const string FileNamePropertyName = "fileName";

        [ConfigurationProperty(LoggerTypePropertyName, DefaultValue = "Console", IsRequired = true)]
        public string LoggerType => (string)this[LoggerTypePropertyName];

        [ConfigurationProperty(FileNamePropertyName, DefaultValue = "", IsRequired = false)]
        public string FileName => (string)this[FileNamePropertyName];
    }
}
