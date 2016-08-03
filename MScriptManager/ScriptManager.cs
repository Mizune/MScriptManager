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
            reader = new Reader();
            parser = new Parser();
        }

    }
}
