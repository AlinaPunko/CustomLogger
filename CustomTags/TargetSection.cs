using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace CustomTags
{
    public class TargetSection : ConfigurationSection
    {
        [ConfigurationProperty("targets", IsDefaultCollection = true)]
        public TargetCollection Targets
        {
            get { return (TargetCollection)this["targets"]; }
            set { this["targets"] = value; }
        }
    }
}
