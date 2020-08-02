using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class Letters
    {
        ////string res = '\u0022' + "For and in the absence of the PITD:" + '\u0022';
        ////private string _createdOfficeName;
        ////private Offices _createdOffice;
        ////public string ShowForandInTheAbsenceOf => ShowInTheAbsenceofthePLO == true ? res : "";

        ////public Offices CreatedOffice
        ////{
        ////    get
        ////    {
        ////        if (_createdOffice == null)
        ////            _createdOffice= new UnitOfWork().OfficesRepo.Find(x => x.Id == CreatedByOffice);
        ////        return _createdOffice;
        ////    }
        ////    set => _createdOffice = value;
        ////}

        ////public string CreatedOfficeName
        ////{
        ////    get
        ////    {
        ////        if (string.IsNullOrEmpty(_createdOfficeName))
        ////            _createdOfficeName = CreatedOffice?.IsDivision == true ? "OFFICE OF THE "+CreatedOffice?.UnderOfOffice.OfficeName + Environment.NewLine + CreatedOffice?.OfficeName :
        ////                CreatedOffice.OfficeName;
        ////        return _createdOfficeName.ToUpper();
        ////    }
        ////    set => _createdOfficeName = value;
        ////}
    }
}
