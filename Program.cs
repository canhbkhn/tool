using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace sol
{
    class Program
    {
        public static bool isExistFileSetting(string filename)
        {
            return File.Exists(filename) ? true : false;
        }

        // Read file
        public static void ReadFile()
        {

        }

        public static string get()
        {
            return "";
        }


        public static void write(string filestream)
        {
            StreamWriter sw;
            if(!isExistFileSetting(filestream))
            {
                //File.Create("settings.ini");
                sw = new StreamWriter("settings.ini");
            }
            else
            {
                sw = new StreamWriter(filestream);
            }

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("TASK_TRAY_ICON", "available");
            data.Add("REMOTE_LOCK", "unavailable");
            data.Add("SIM_CHECK", "unavailable");

            //StringBuilder sb = new StringBuilder();

            

            foreach(KeyValuePair<string, string> kvp in data)
            {
                sw.WriteLine(string.Format("{0} = {1}", kvp.Key, kvp.Value));
            }


            sw.Close();
            //filestream.Write();

            //Console.WriteLine(sb);
        }

        // Merge data from command line to file
        public static void Merge(string file)
        {
            // Read all line in settings.ini file
            var text = File.ReadAllLines(file);

           for(int i=0;i<text.Length; i++)
            {
                Console.WriteLine("{0}", text[i]);
            }
        }


        static void Main(string[] args)
        {
            ////FileStream setting;
            //if(!isExistFileSetting())
            //{
            //    // If not exist file settings.ini
            //    // Create new settings.ini file
            //    //FileStream setting = new FileStream("settings.ini", FileMode.Create, FileAccess.ReadWrite);
            //    //string filename = "settings.ini";
            //    //File.Create(filename);
            //    write("settings.ini");
            //}
            //else
            //{
            //    File.OpenWrite("settings.ini");
            //    write("settings.ini");


            //}

            write("settings.ini");

            Merge("settings.ini");

        }
    }
}
