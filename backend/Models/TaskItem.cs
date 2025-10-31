namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; }
        public int UserId { get; set; }

        // i comment the last code so i will not appear in fields
        
        // public User User { get; set; }= null!;
    }
}