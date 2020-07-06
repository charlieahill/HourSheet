using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourSheet
{
    [Serializable]
    public class ProgramDataModel
    {
        public ObservableCollection<DayModel> Days { get; set; } = new ObservableCollection<DayModel>();
        public ObservableCollection<WorkStatusModel> WorkStatuses { get; set; } = new ObservableCollection<WorkStatusModel>();
        public ObservableCollection<FlagModel> Flags { get; set; } = new ObservableCollection<FlagModel>();

        public ProgramDataModel()
        {
            Days = GetDays(DateTime.Today.AddDays(-30), DateTime.Today);
            WorkStatuses = GetWorkStatuses();
            Flags = GetFlags();
        }

        private ObservableCollection<DayModel> GetDays(DateTime dateTime, DateTime today)
        {
            throw new NotImplementedException();
        }

        private ObservableCollection<WorkStatusModel> GetWorkStatuses()
        {
            ObservableCollection<WorkStatusModel> workStatuses = new ObservableCollection<WorkStatusModel>
            {
                new WorkStatusModel("Working"),
                new WorkStatusModel("Weekend"),
                new WorkStatusModel("Working Weekend"),
                new WorkStatusModel("Annual Leave"),
                new WorkStatusModel("Bank Holiday"),
                new WorkStatusModel("Working Bank Holiday"),
                new WorkStatusModel("Furlough")
            };

            return workStatuses;
        }

        private ObservableCollection<FlagModel> GetFlags()
        {
            ObservableCollection<FlagModel> flags = new ObservableCollection<FlagModel>
            {
                new FlagModel("Travel"),
                new FlagModel("WFH")
            };

            return flags;
        }
    }
}
