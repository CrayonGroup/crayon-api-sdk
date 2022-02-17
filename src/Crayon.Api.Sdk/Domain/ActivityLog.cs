using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Domain
{
    public enum ChangeTypeEnum
    {
        Delete = 1,
        Insert = 2,
        Update = 3,
        //Update = 4 
    };

    public class ActivityLog : ApiCollection<ActivityLogItem>
    {
        public string Entity { get; set; }
    }

    public class ActivityLogItem
    {
        public string Entity { get; set; }
        public int Id { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangedDate { get; set; }
        public string ChangedColumn { get; set; }
        public string ChangedFrom { get; set; }
        public string ChangedTo { get; set; }
        public Dictionary<string, string> CustomValues { get; set; }
        public ChangeTypeEnum ChangeType { get; set; }
    }
}
