using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Util
{
    class DataStore
    {
        private static DataStore m_Instance = null;
        private DataStore()
        {
        }

        public static DataStore getInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new DataStore();
            }

            return m_Instance;
        }

        public string GetStorePath()
        {
            return @"D:\mdt";
        }

        public string GetBackupPath()
        {
            return @"\\10.10.10.30\d$\mdt";
        }
    }
}
