﻿using Microsoft.Extensions.Configuration;

namespace PageObjects.Framework.Utils
{
    public class LoggingSettingsConfig
    {
        private IConfigurationRoot _configData;

        private void Initialize() => _configData = new ConfigurationBuilder().AddJsonFile("loggingSettings.json").Build();

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