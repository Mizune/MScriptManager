using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScriptManager
{
    public class ScriptManager
    {
        private IEnumerable<ScriptData> datas;
        private Parser parser;
        private Reader reader;

        public ScriptManager()
        {
            Initialize();
        }

        public void Initialize()
        {
            reader = new Reader();
            parser = new Parser();
            datas = new List<ScriptData>();
        }

        public void Start()
        {
            reader.DataRead();
            parser.Parse(reader.GetData());
            SetScinarios(parser.GetDatas());
        }

        public void SetScinarios(List<ScriptData> Datas)
        {
            this.datas = parser.GetDatas();
        }

    }
}
