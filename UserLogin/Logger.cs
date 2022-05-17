using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();
        static public void LogActivity(string activity)
        {

            string activityLine = DateTime.Now + ";"
                + LoginValidation.currentUserName + ";"
                + LoginValidation.currentUserRole + ";"
                + activity;
            currentSessionActivities.Add(activityLine);
            File.AppendAllText("TestFile.txt", activityLine);
        }

        public static string GetLogActivity()
        {
            try
            {
                StreamReader sr = new StreamReader("TestFile.txt");
                string logFileData = sr.ReadToEnd();
                return logFileData;
            }
            catch (FileNotFoundException e)
            {
                File.Create("TestFile.txt");
                throw e;
            }
        }
        static public IEnumerable<string> GetAllLinesFromFile()
        {
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader("TestFile.txt");
            while (reader.Peek() >= 0)
            {
                lines.Add(reader.ReadLine());
            }
            reader.Close();
            return lines;
        }

        static public void VisualizeLogs()
        {
            IEnumerable<string> lines = GetAllLinesFromFile();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static IEnumerable <string> GetCurrentSessionActivities()
        {
            return currentSessionActivities;
        }
        static public void VisualizeCurrentLogs()
        {
            StringBuilder strBuilder = new StringBuilder();
            IEnumerable<string> currentLogs = GetCurrentSessionActivities();
            foreach (string line in currentLogs)
            {
                strBuilder.Append(line);
            }

            Console.WriteLine(strBuilder.ToString());
        }
        static public void CountLogs()
        {
            StreamReader reader = new StreamReader("TestFile.txt");
            int count = 0;
            while (reader.Peek() >= 0)
            {
                Console.WriteLine(reader.ReadLine());
                count++;
            }
            reader.Close();

            Console.WriteLine("Count of logs: " + count);
        }

        public static void OldestLog()
        {
            StreamReader reader = new StreamReader("TestFile.txt");
            string log = reader.ReadLine();
            reader.Close();

            Console.WriteLine("Oldest log: " + log);
        }


    }
}
