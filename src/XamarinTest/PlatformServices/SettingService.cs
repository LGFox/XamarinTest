using System;
using Interfaces.PlatformServices;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace XamarinTest.PlatformServices
{
    public class SettingService : ISettingService
    {
        private ISettings _appSettings;
        private ISettings AppSettings
        {
            get
            {
                if (_appSettings == null)
                {
                    _appSettings = CrossSettings.Current;
                }
                return _appSettings;
            }
        }

        public decimal GetValueOrDefault(string key, decimal defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public bool GetValueOrDefault(string key, bool defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public long GetValueOrDefault(string key, long defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public string GetValueOrDefault(string key, string defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public int GetValueOrDefault(string key, int defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public float GetValueOrDefault(string key, float defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public DateTime GetValueOrDefault(string key, DateTime defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public Guid GetValueOrDefault(string key, Guid defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public double GetValueOrDefault(string key, double defaultValue, string fileName = null)
        {
            return AppSettings.GetValueOrDefault(key, defaultValue, fileName);
        }

        public bool AddOrUpdateValue(string key, decimal value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public bool AddOrUpdateValue(string key, bool value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public bool AddOrUpdateValue(string key, long value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public bool AddOrUpdateValue(string key, string value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public bool AddOrUpdateValue(string key, int value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public bool AddOrUpdateValue(string key, float value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public bool AddOrUpdateValue(string key, DateTime value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public bool AddOrUpdateValue(string key, Guid value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public bool AddOrUpdateValue(string key, double value, string fileName = null)
        {
            return AppSettings.AddOrUpdateValue(key, value, fileName);
        }

        public void Remove(string key, string fileName = null)
        {
            AppSettings.Remove(key, fileName);
        }

        public void Clear(string fileName = null)
        {
            AppSettings.Clear(fileName);
        }

        public bool Contains(string key, string fileName = null)
        {
            return AppSettings.Contains(key, fileName);
        }
    }
}