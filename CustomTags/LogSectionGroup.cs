using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace CustomTags
{
    public class LogSectionGroup : ConfigurationSectionGroup
    {
        [ConfigurationProperty("targets", IsRequired = false)]
        public TargetSection GeneralSettings
        {
            get { return (TargetSection)base.Sections["targets"]; }
        }

        //[ConfigurationProperty("companySection", IsRequired = false)]
        //public CompanySection ContextSettings
        //{
        //    get { return (CompanySection)base.Sections["companySection"]; }
        //}
    }
}
