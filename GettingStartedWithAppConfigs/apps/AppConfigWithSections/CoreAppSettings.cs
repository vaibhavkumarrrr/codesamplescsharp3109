using System.Configuration;
namespace AppConfigWithSections
{
    public sealed class CoreAppSettings: ConfigurationSection   
    {
        [ConfigurationProperty("dbtype", IsRequired = true)]
        public string DbType 
        {
            get { return (string)this["dbtype"]; }
            set { this["dbtype"] = value; }
        }
    }
}
