using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.VM
{
    public class DocumentActionsVM
    {
        public int Id { get; set; }
        public Nullable<int> RefId { get; set; }
        public Nullable<int> ProgramId { get; set; }
        public Nullable<int> MainActivityId { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public Nullable<int> SubActivityId { get; set; }
        public string Status { get; set; }
        public string ActionTaken { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> ActionDate { get; set; }
        public string CreatedBy { get; set; }
        public string TableName { get; set; }
        public string Remarks { get; set; }
        public string EndorsedTo { get; set; }
        public Nullable<bool> IsSend { get; set; }
        public Nullable<bool> isSaved { get; set; }
        public string ControlNo { get; set; }
        public Nullable<bool> isDone { get; set; }
        public Nullable<int> ActionId { get; set; }
        public string ObR_PR_No { get; set; }
        public Nullable<int> Year { get; set; }
        public virtual Users CreatedByUsers { get; set; }
        public Actions Programs{ get; set; }
        public Actions MainActivity{ get; set; }
        public Actions Activity{ get; set; }
        public Actions SubActivity{ get; set; }
        public string Description{ get; set; }
        public decimal? TotalAmount{ get; set; }
        public string RouterUsers{ get; set; }
    }
}
