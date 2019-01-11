using System.Configuration;

namespace ConfigLibrary
{
    public class ConfigLibrary
    {
        string ReturnKeyValue(string key)
        {
            if (key is string)
            {
                string configValue = ConfigurationManager.AppSettings[key];

                return configValue;
            }
            else
            {
                return null;
            }
        }
    }
}
