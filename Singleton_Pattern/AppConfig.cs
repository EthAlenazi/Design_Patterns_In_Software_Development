using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class AppConfig
    {
        private static AppConfig _instance;

        public string Environment { get; private set; }
        public string ConnectionString { get; private set; }

        // Prevent creating an instance from outside the class
        private AppConfig()
        {
            Environment = "Production";
            ConnectionString = "Server=DB01;Database=AppDB;";
        }

        // The single access point to the instance
        public static AppConfig Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppConfig();

                return _instance;
            }
        }
    }
}
