using Microsoft.EntityFrameworkCore;

namespace Guidance.Data
{
    [PrimaryKey(nameof(ProjectId), nameof(UserId))]
    public class ProjectMember
    {

        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;        
        
    }
}
