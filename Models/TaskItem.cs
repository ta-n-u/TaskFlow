using System.ComponentModel.DataAnnotations;

namespace TaskFlow.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; } = false;

        [Required]
        public string Priority { get; set; } = "Medium";
    }
}
