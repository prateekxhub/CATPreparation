using Microsoft.AspNetCore.Identity;

namespace CATPrepGamified.Models;

public class ApplicationUser : IdentityUser 
{
    public int ExperiencePoints { get; set; } = 0;
    public int Level { get; set; } = 1;
}