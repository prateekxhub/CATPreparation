namespace CATPrepGamified.Models;

public class Question
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Section { get; set; } = string.Empty; 
    public string Topic { get; set; } = string.Empty;
    public string QuestionText { get; set; } = string.Empty;
    public string OptionA { get; set; } = string.Empty;
    public string OptionB { get; set; } = string.Empty;
    public string OptionC { get; set; } = string.Empty;
    public string OptionD { get; set; } = string.Empty;
    public char CorrectOption { get; set; } 
    public bool IsActive { get; set; } = true;
}