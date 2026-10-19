namespace CrazyBunnies.Components.Sections;
public partial class Services
{
    record Item(string Icon, string Title, string Text);
    static readonly Item[] Items =
    {
        new("✦", "Braids", "Neat, carefully finished braiding for children and adults."),
        new("✂", "Haircuts", "Clean cuts shaped to suit you."),
        new("❀", "Hairstyles", "Styling for everyday looks and special days."),
    };
}
