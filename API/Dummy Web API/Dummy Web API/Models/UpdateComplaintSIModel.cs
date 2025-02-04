using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class UpdateComplaintSIModel
    {
        public string complaintSIAgainst { get; set; }
        public string complaintSINumber { get; set; }
        public string complaintDate { get; set; }
        public string complaintCreatedInRITES { get; set; }
        public string dateOfPAOC_Order { get; set; }
        public string complaintClosed { get; set; }
        public string complainantName { get; set; }
        public string complainantId { get; set; }
        public string complainantDesc { get; set; }
        public string PA_RegistrationNumber { get; set; }
        public string rcbCaseNo { get; set; }
        public string PA_Name { get; set; }
        public string PAE_UEN { get; set; }
        public string PAE_Name { get; set; }
        public OutcomeDetail[] OutcomeDetails { get; set; }
    }
    public class OutcomeDetail
    {
        public string Section_Code { get; set; }
        public string Offcharge_Desc { get; set; }
        public string outcomeOfComplaint { get; set; }
        public string detailsOfComplaintOutcome { get; set; }
        public string dateOfCancellation { get; set; }
        public string startDateOfSuspension { get; set; }
        public string endDateOfSuspension { get; set; }
    }
}