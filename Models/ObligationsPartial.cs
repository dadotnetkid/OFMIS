﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class Obligations
    {
        //public string controlId => ResponsibilityCenter + "-" + ControlNo;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TotalAmount => this.ORDetails.Sum(m => m.Amount);

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AmountToWords => Amount.ToString("0.0###").NumberToWords();
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [NotMapped]
        public Signatories Governor
        {
            get
            {
                Debug.WriteLine("Position:" + ApprovedBy?.Position);
                if (Offices?.IsDivision == true)
                    return ApprovedBy?.Position == "Governor" ? null : new UnitOfWork().Signatories.Find(m => m.Position == "Governor");
                else
                    return null;

            }
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [NotMapped]
        public Signatories DVGovernor
        {
            get
            {
                Debug.WriteLine("Position:" + ApprovedBy?.Position);
                var res = DVApprovedByPosition == "Governor" ? null : new UnitOfWork().Signatories.Find(m => m.Position == "Governor");

                return res;
            }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [NotMapped]
        public Signatories DVApproved
        {
            get
            {
                Debug.WriteLine("Position:" + ApprovedBy?.Position);
                var res = new UnitOfWork().Signatories.Find(x => x.Person == DVApprovedBy);

                return res;
            }
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [NotMapped]
        public Signatories ApprovedBy => new UnitOfWork().Signatories.Find(m => m.Person == this.OBRApprovedBy);
    }
}
