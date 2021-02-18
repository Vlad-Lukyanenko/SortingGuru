using log4net;
using log4net.Config;
using System.IO;
using System.Reflection;

namespace SortingGuru.UI
{
    public abstract class Logger
    {
        private const string _configFile = "log4net.config";

        public static ILog CreateInstance()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo(_configFile));

            return LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}
