using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop.inheritance
{
    class ChangeRequest:WorkItem
    {
        protected int originalItemID { get; set; }
        public ChangeRequest() { }
        public ChangeRequest(string Title, string Description, TimeSpan JobLength, int originalID)
        {
            this.ID = GetNextID();
            this.Title = Title;
            this.Description = Description;
            this.jobLength = JobLength;
            this.originalItemID = originalID;
        }

    }
}
