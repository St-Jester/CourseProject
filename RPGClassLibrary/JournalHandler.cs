using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class JournalHandler
    {
		#region Singletone
		public static JournalHandler instance;
		#endregion

		public Dictionary<string, string> JournalRecords { get; set; }

        public JournalHandler()
        {
			if (instance != null)
				return;

			instance = this;
            JournalRecords = new Dictionary<string, string>();
        }
        public void AddRecord(string _recordName, string _record)
        {
            JournalRecords.Add(_recordName, _record);
        }
    }
}
