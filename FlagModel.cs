using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourSheet
{
    [Serializable]
    public class FlagModel
    {
        public bool IsTrue { get; set; } = false;
        public string FlagName { get; set; }
        public FlagModel(string _flagName)
        {
            FlagName = _flagName;
        }
    }
}
