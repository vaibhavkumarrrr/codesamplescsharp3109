using System.Configuration;

namespace ACrazyCatsExample
{
    [ConfigurationCollection(typeof(CatConfiguration), AddItemName = CatKey)]
    public class CatConfigurationCollection : ConfigurationElementCollection
    {
        private const string CatKey = "cat";
        protected override ConfigurationElement CreateNewElement()
        {
            return new CatConfiguration();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((CatConfiguration)element).Name;
        }
    }
}
