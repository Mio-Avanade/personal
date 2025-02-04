using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class ComplaintSIModel
    {
        public string complaintSIAgainst { get; set; }
        public int typeIndicator { get; set; }
        public string complaintSINumber { get; set; }
        public string complaintDate { get; set; }
        public string complainantName { get; set; }
        public string complainantId { get; set; }
        public string complainantDesc { get; set; }
        public string PA_RegistrationNumber { get; set; }
        public string rcbCaseNo { get; set; }

        public string PA_Name { get; set; }
        public string PAE_UEN { get; set; }
        public string PAE_Name { get; set; }
        public Sectiondetail[] SectionDetails { get; set; }

    }
    public class Sectiondetail
    {
        public string Section_Code { get; set; }
        public string Offcharge_Desc { get; set; }
    }

}