using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MScriptManager
{
    public class Reader
    {
        private List<string> Datas;
      
        public Reader()
        {
            Datas = new List<string>();
        }

        public void DataRead()
        {
            // DataRead("FirstSinarios.mst");    // only use products
            DataRead("DummyScinarios.mst");
        }


        public void DataRead(string path)
        {
            string line = "";
            using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding("UTF-8")))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    Datas.Add(line);
                }
            }

        }

        public List<string> GetData()
        {
            return Datas;
        }

    }
}
