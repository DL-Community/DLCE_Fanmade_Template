using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DancingLine
{
    public static class UserDataManager
    {
        #region Save Data
        public static void Save(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }

        public static void Save(string key, int value) 
        { 
            PlayerPrefs.SetInt(key, value);
        }

        public static void Save(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
        }

        public static void Save(string key, bool value)
        {
            Save(key, value ? 1 : 0);
        }
        #endregion


        #region Load Data
        public static string LoadString(string key) 
        { 
            return PlayerPrefs.GetString(key);
        }
        public static string LoadString(string key, string defaultValue)
        {
            return PlayerPrefs.GetString(key, defaultValue);
        }


        public static int LoadInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }
        public static int LoadInt(string key, int defaultValue)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }


        public static float LoadFloat(string key)
        {
            return PlayerPrefs.GetFloat(key);
        }
        public static float LoadFloat(string key, float defaultValue)
        {
            return PlayerPrefs.GetFloat(key, defaultValue);
        }


        public static bool LoadBool(string key)
        {
            return PlayerPrefs.GetInt(key) == 1;
        }
        public static bool LoadBool(string key, bool defaultValue)
        {
            return LoadInt(key, defaultValue ? 1 : 0) == 1;
        }
        #endregion
    }
}
