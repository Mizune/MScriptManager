using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScriptManager
{
    public class ScriptManager
    {
        private ArrayList datas;
        private int line;
        private Parser parser;
        private Reader reader;

        public ScriptManager()
        {
            Initialize();
        }

        public void Initialize()
        {
            line = 0;
            reader = new Reader();
            parser = new Parser();
            datas = new ArrayList();
        }

        public void Start()
        {
            reader.DataRead();
            parser.Parse(reader.GetData());
            SetScinarios(parser.GetDatas());
        }

        public void SetScinarios(ArrayList Datas)
        {
            this.datas = parser.GetDatas();
        }

        public ScriptData GetObject()
        {
            return (ScriptData)datas[line++];
        }


    }
}
