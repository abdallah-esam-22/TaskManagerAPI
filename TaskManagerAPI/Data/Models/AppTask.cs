using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace TaskManagerAPI.Data.Models
{
    public class AppTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public string UserId { get; set; }

        public AppUser User { get; set; }
    }


    public enum Status
    {
        [EnumMember(Value = "Pending")]
        Pending = 1,

        [EnumMember(Value = "In Progress")]
        InProgress = 2,

        [EnumMember(Value = "Completed")]
        Completed = 3
    }


    public enum Priority
    {
        Low = 1,
        Medium = 2,
        High = 3
    }
}
