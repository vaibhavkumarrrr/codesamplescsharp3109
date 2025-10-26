using System.Configuration;
namespace AppConfigWithSections
{
    public sealed class SQLiteSettings: ConfigurationSection   
    {
        [ConfigurationProperty("folder", IsRequired = true)]
        public string Folder
        {
            get => (string)this["folder"];
            set => this["folder"] = value;
        }

        [ConfigurationProperty("db", IsRequired = true)]
        public string Db
        {
            get => (string)this["db"];
            set => this["db"] = value;
        }
        public string GetConnectionString()
        {
            //return $"Server={Server};Database={Db};Initial Catalog={Db};Trusted_Connection=true;User Id={User};Password={Password};";
            return $"Data Source=={Folder}{Path.PathSeparator}{Db}";
        }

    }

}
