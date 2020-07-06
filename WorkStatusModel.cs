using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourSheet
{
    /// <summary>
    /// WorkStatus - Weekend, Bank Holiday, Working, Working Weekend, Working Bank Holiday, Annual Leave, Furlough
    /// Todo: Implement work status models
    /// Todo: make this list so it can be added to
    /// </summary>
    [Serializable]
    public class WorkStatusModel
    {
        public string WorkStatus { get; set; }

        public WorkStatusModel(string _workStatus)
        {
            WorkStatus = _workStatus;
        }
    }
}
