using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class ReportResponse:ReportRequest
    {
        public ApplicationUser Moderator { get; set; }
        public string ModeratorId { get; set; }
    }
}