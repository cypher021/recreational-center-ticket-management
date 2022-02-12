using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace Coursework
{
    class Utility
    {
        private static string _filepath = "Price_file.json";

        public static string Write(string data)
        {
            if (!File.Exists(_filepath))
            {
                using (File.Create(_filepath)) ;
            }
            using (StreamWriter outputfile = new StreamWriter(_filepath))
            {
     
                outputfile.WriteLine(data);
                outputfile.Close();

            }
            return "Done.";
        }
        public static string DeleteAll()
        {
            if (File.Exists(_filepath))
            {
                try
                {
                    File.Delete(_filepath);
                    using (File.Create(_filepath));
                }
                catch (Exception ex) { }

            }
            return null;
        }
  

        public static string Read()
        {
            string json;
            if (File.Exists(_filepath))
            {


                return json = File.ReadAllText(_filepath);

            }
            else
            {
                return json = null;
            }
        }

   }

}