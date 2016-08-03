﻿using System;
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
                ScriptData SData = new ScriptData();
                if (!data.Contains("[") && !data.Contains("]"))
                {
                    SData.TypeNum = Const.TYPE_TEXT;
                    SData.Line = data;
                }
                else
                {
                    string tmp = data.Replace("[", "");
                    tmp = tmp.Replace("]", "");
                    string[] command = tmp.Split(' ');

                    SData.Line = string.Empty;

                    switch (command[0])
                    { //[commandName opt1 opt2 opt3 ... ]
                        case "ChangeBGI":
                            SData.TypeNum = Const.TYPE_CHANGE_BGI;
                            break;
                            // 他のOption
                            // TODO add more option
                    }

                    for (int i = 2;i < command.Length; i++)
                    {
                        SData.AddOption(command[i]);
                    }           
                }

                Datas.Add(SData);

            }
        }

        public List<ScriptData> GetDatas()
        {
            return Datas;
        }
    }
}
