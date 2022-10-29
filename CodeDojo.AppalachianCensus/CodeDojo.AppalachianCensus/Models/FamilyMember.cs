using System.Text;

namespace CodeDojo.AppalachianCensus.Models;

public class FamilyMember
{
    public FamilyMember(string name, string parent1, string parent2)
    {
        Name = name;
        var parents = new[] { parent1, parent2 }.OrderBy(s=>s);
        Parent1 = parents.ElementAt(0);
        Parent2 = parents.ElementAt(1);
    }

    public readonly string Name;
    public readonly string? Parent1;
    public readonly string? Parent2;

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Family member: ");
        sb.Append(Name);
        
        if (!string.IsNullOrWhiteSpace(Parent1))
        {
            sb.Append(", with Parent 1: ");
            sb.Append(Parent1);
        }

        if (!string.IsNullOrWhiteSpace(Parent2))
        {
            sb.Append(", and with Parent 2: ");
            sb.Append(Parent2);
        }

        return sb.ToString();

    }
}