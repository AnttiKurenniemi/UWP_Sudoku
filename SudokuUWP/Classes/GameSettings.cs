using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace SudokuUWP.Classes
{
    /// <summary>
    /// A class used to read and store settings. Also handles license information (trial / purchased)
    /// </summary>
    public static class GameSettings
    {
        /// <summary>
        /// Local settings 
        /// </summary>
        private static ApplicationDataContainer LocalSettings;


        /// <summary>
        /// Constructor. Loads 
        /// </summary>
        static GameSettings()
        {
            LocalSettings = ApplicationData.Current.LocalSettings;
        }



        public static void SaveValue(string Key, string Value)
        {
            LocalSettings.Values[Key] = Value;
        }

        public static void SaveValue(string Key, double Value)
        {
            LocalSettings.Values[Key] = Value;
        }

        public static void SaveValue(string Key, int Value)
        {
            LocalSettings.Values[Key] = Value;
        }

        public static void SaveValue(string Key, bool Value)
        {
            LocalSettings.Values[Key] = Value;
        }


        public static string GetStringValue(string Key)
        {
            object tmp = LocalSettings.Values[Key];
            if (tmp != null)
                return tmp.ToString();
            else
                return "";
        }

        public static double GetDoubleValue(string Key, double DefaultValue)
        {
            object tmp = LocalSettings.Values[Key];
            if (tmp != null)
                return (double)tmp;
            else
                return DefaultValue;
        }

        public static int GetIntValue(string Key, int DefaultValue)
        {
            object tmp = LocalSettings.Values[Key];
            if (tmp != null)
                return (int)tmp;
            else
                return DefaultValue;
        }

        public static bool GetBoolValue(string Key, bool DefaultValue)
        {
            object tmp = LocalSettings.Values[Key];
            if (tmp != null)
                return (bool)tmp;
            else
                return DefaultValue;
        }

    }
}
