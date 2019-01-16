using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CengApp.AppSettings
{
    public class LocalStorageSettings
    {
        static ISettings getset = CrossSettings.Current;

        public static string MailKey
        {
            get => CrossSettings.Current.GetValueOrDefault(App.mail_key, "");
            set => CrossSettings.Current.AddOrUpdateValue(App.mail_key, value);
        }

        public static string PasswordKey
        {
            get => CrossSettings.Current.GetValueOrDefault(App.password_key, "");
            set => CrossSettings.Current.AddOrUpdateValue(App.password_key, value);
        }
    }
    
}
