using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScriptManager
{
    class Parser
    {
        public ArrayList Datas;

        public Parser()
        {
            Datas = new ArrayList();
        }


        public void Parse(List<string> raw)
        {
            foreach (var data in raw)
            {
                ScriptData SData = new ScriptData();
                if (!data.Contains("[") && !data.Contains("]"))
                {
                    SData.TypeNum = Const.TYPE_CHANGE_TEXT;
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
                        case "ChangeCharName":
                            SData.TypeNum = Const.TYPE_CHANGE_CHARNAME;
                            break;
                        case "ChangeBGM":
                            SData.TypeNum = Const.TYPE_CHANGE_BGM;
                            break;
                        case "ChangeCharThumbnail":
                            SData.TypeNum = Const.TYPE_CHANGE_CHARTHUMBNAIL;
                            break;
                        case "ChangeCharImage":
                            SData.TypeNum = Const.TYPE_CHANGE_CHARIMAGE;
                            break;
                     
                        case "UseSE":
                            SData.TypeNum = Const.TYPE_USE_SE;
                            break;

                        case "CreateFlag":
                            SData.TypeNum = Const.TYPE_CREATE_FLAG;
                            break;
                        case "ChangeFlagParams":
                            SData.TypeNum = Const.TYPE_CHANGE_FLAG_PARAMS;
                            break;
                        case "RemoveFlag":
                            SData.TypeNum = Const.TYPE_REMOVE_FLAG;
                            break;
                        case "CreateSwitch":
                            SData.TypeNum = Const.TYPE_CREATE_SWITCH;
                            break;
                    }

                    for (int i = 2;i < command.Length; i++)
                    {
                        SData.AddOption(command[i]);
                    }           
                }

                Datas.Add(SData);

            }
        }

        public ArrayList GetDatas()
        {
            return Datas;
        }
    }
}
