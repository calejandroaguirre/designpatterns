using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton.Config
{
    public class Singleton
    {
        private static Singleton _singleton;
        protected Singleton() { }

        public static Singleton Instance()
        {
            if(_singleton == null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string singletonClass = config.AppSettings.Settings["Singleton"].Value;

            }
            return _singleton;
        }

        public virtual string DoSomething()
        {
            return "From Singleton";
        }
        
    }
}
