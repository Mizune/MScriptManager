﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScriptManager
{
    public class ScriptData
    {
        private int typeNum;
        private string line;

        private ArrayList Option; // String Only

        public int TypeNum
        {
            get
            {
                return typeNum;
            }

            set
            {
                typeNum = value;
            }
        }

        public string Line
        {
            get
            {
                return line;
            }

            set
            {
                line = value;
            }
        }

        public ScriptData()
        {
            Option = new ArrayList();
        }

        public ScriptData(ArrayList options)
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

        public void RemoveOption(string option)
        {
            Option.Remove(option);
        }

        public void RemoveAllOption()
        {
            Option.Clear();
        }

    }
}
