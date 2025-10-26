using System.Configuration;
namespace ACrazyCatsExample
{
    public class CatLadyConfigurationSection : ConfigurationSection
    {
        private const string XmlnsKey = "xmlns";
        private const string NameKey = "name";
        private const string CatsKey = "cats";

        [ConfigurationProperty(XmlnsKey, IsRequired = false)]
        public string XmlNamespace => (string)this[XmlnsKey];

        [ConfigurationProperty(NameKey, IsRequired = true)]
        public string Name => (string)this[NameKey];

        [ConfigurationProperty(CatsKey, IsRequired = true)]
        public CatConfigurationCollection Cats => (CatConfigurationCollection)this[CatsKey];
    }
}
