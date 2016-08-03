using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScriptManager
{
    public class ScriptData
    {
        private int TypeNum { get ;set; }
        private string Line { get; set; }

        private List<string> Option;

        public ScriptData()
        {
            Option = new List<string>();
        }

        public ScriptData(List<string> options)
        {
            foreach(var opt in options)
            {
                Option.Add(opt);
            }
        }

        
        public void AddOption(string option)
        {
            Option.Add(option);
        }

    }
}
