using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScriptManager
{
    class Parser
    {
        public List<ScriptData> Datas;

        public Parser()
        {
            Datas = new List<ScriptData>();
        }


        public void Parse(List<string> raw)
        {
            foreach (var data in raw)
            {
                ScriptData SData = new ScriptData()
                if (!data.Contains("[") && !data.Contains("]"))
                {
                    SData.TypeNum = Const.TYPE_TEXT;   
                }  else
                {
                    string tmp = data.Replace("[", "");
                    tmp = tmp.Replace("]", "");
                    string[] command = tmp.Split(' ');
                }
             


            }
        }

        public List<ScriptData> GetDatas()
        {
            return Datas;
        }
    }
}
