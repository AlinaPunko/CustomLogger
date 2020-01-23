using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingProxy
{
    public interface ICat
    {
        void eat();

        string Name
        {
            get;
            set;
        }
    }
}
