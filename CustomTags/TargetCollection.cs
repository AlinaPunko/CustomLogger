using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace CustomTags
{
        [ConfigurationCollection(typeof(Target), AddItemName = "target")]
        public class TargetCollection : ConfigurationElementCollection
        {
            protected override ConfigurationElement CreateNewElement()
            {
                return new Target();
            }

            protected override object GetElementKey(ConfigurationElement element)
            {
                return ((Target)element).Name;
            }

        }
}
