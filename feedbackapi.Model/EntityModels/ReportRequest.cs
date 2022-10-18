using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class ReportRequest
    {
        public int Id { get; set; }
        public string ReportedType { get; set; }
        public int? ReportedTypeId { get; set; }
        public string? ReportedTypeUserId { get; set; }
        public ApplicationUser Reporter { get; set; }
        public string ReporterId { get; set; }

        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}