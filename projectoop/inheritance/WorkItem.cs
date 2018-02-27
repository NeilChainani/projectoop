using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace projectoop.inheritance
{
    class WorkItem
    {
        public static int currentID;//role here is to store the id of the work item
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength
        {
            get; set;
        }
        public WorkItem()
        {
            ID = 0;
            Title = "lol";
            Description = "neil was here";
            jobLength = new TimeSpan();
        }
        public WorkItem(string Title, string Description, TimeSpan jobLength)
        {
            this.ID = GetNextID();
            this.Title = Title;
            this.Description = Description;
            this.jobLength = jobLength;
        }
        static WorkItem()
        {
            currentID = 0;
        }
        protected int GetNextID()
        {
            return ++currentID;
        }
        public void Update(string Title, TimeSpan jobLength)
        {
            this.Title = Title;
            this.jobLength = jobLength;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", this.ID, this.Title);
        }
    }
}
