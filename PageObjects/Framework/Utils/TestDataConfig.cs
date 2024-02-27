using Microsoft.Extensions.Configuration;

namespace PageObjects.Framework.Utils
{
    public class TestDataConfig
    {
        private IConfigurationRoot _configData;

        private void Initialize() => _configData = new ConfigurationBuilder().AddJsonFile("testData.json").Build();

        public IConfigurationRoot Data
        {
            get
            {
                if (_configData == null)
                {
                    Initialize();
                }
                return _configData;
            }
        }
    }
}
