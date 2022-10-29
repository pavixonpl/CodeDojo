namespace CodeDojo.AppalachianCensus.Models;

public class FamilyTreeNode
{
    private readonly FamilyMember _familyMember;
    private readonly List<FamilyTreeNode> _children;

    public FamilyTreeNode(FamilyMember familyMember)
    {
        _familyMember = familyMember;
        _children = new List<FamilyTreeNode>();
    }

    public FamilyTreeNode AddChild(string name, string otherParent)
    {
        var child = new FamilyMember(name, _familyMember.Name, otherParent);
        var node = new FamilyTreeNode(child);
        _children.Add(node);

        return node;
    }

    public IEnumerable<FamilyMember> Flatten()
    {
        return new[] {_familyMember}.Concat(_children.SelectMany(s => s.Flatten()));
    }
}