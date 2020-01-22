using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace CustomTags
{
    public class Target : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("loggerType", DefaultValue = "", IsRequired = true)]
        public string LoggerType
        {
            get { return (string)this["loggerType"]; }
            set { this["loggerType"] = value; }
        }

        [ConfigurationProperty("fileName", DefaultValue = "", IsRequired = false)]
        public string FileName
        {
            get { return (string)this["fileName"]; }
            set { this["fileName"] = value; }
        }
    }
}
