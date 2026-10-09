namespace CATPrepGamified.Models;

public class UserAttempt
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;
    
    public Guid QuestionId { get; set; }
    public Question Question { get; set; } = null!;
    
    public bool IsCorrect { get; set; }
    public DateTime AttemptDate { get; set; } = DateTime.UtcNow;
}