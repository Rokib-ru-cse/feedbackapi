using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class WishList
    {
        public int Id { get; set; }
        public Feedback Feedback { get; set; }
        public int FeedbackId { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}