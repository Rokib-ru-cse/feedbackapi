using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using feedbackapi.Model.IdentityModels;

namespace feedbackapi.Model.EntityModels
{
    public class Follow
    {
        public int Id { get; set; }
        public string FollowedType { get; set; }
        public int? FollowedTypeId { get; set; }
        public string? FollowedTypeUserId { get; set; }
        public ApplicationUser Follower { get; set; }
        public string FollowerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}