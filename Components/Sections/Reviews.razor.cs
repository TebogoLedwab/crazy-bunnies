using crazybunnies.Models;
namespace crazybunnies.Components.Sections;
public partial class Reviews
{
    record Quote(string Text, string Who, string When);
    static readonly Quote[] Quotes =
    {
        new("Simphiwe was awesome with my daughter's braids. Very neat, had a break in between and overall friendly and Punctual.", "Mologadi Mathosa", "2 years ago"),
        new("They do the best hairstyles, but the problem is that the saloon gets too packed, and its not really child friendly.", "Mpumi Mpumlwana", "2 years ago"),
    };
}
