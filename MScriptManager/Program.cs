using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       

namespace MScriptManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // do whileをonclickに
            ScriptManager manager = new ScriptManager();
            manager.Start();
            int currentType = 999;
            do
            {
                ScriptData data = manager.GetObject();
                currentType = data.TypeNum;
                switch (currentType)
                {
                    case Const.TYPE_CHANGE_TEXT:
                        DummyViewEngine.ChangeText();
                        break;
                    case Const.TYPE_CHANGE_BGI:
                        DummyViewEngine.ChangeBGI();
                        break;
                    case Const.TYPE_USE_SE:
                        DummyViewEngine.UseSE();
                        break;
                    default:
                        break;

                }
            } while (currentType != Const.TYPE_CHANGE_TEXT);

            while (true) ;         // testCode
            
        }
    }
}
