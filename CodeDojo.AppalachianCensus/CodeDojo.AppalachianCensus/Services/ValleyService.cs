using CodeDojo.AppalachianCensus.Models;

namespace CodeDojo.AppalachianCensus.Services;

public class ValleyService
{
    public IEnumerable<FamilyMember> GetPeopleInValley()
    {
        return CompareFamiliesAndRemoveDuplicates(new [] { VisitFamilyClacket(), VisitFamilyHope() });
    }

    private static IEnumerable<FamilyMember> CompareFamiliesAndRemoveDuplicates(IEnumerable<FamilyTreeNode> families)
    {
        return families.SelectMany(s => s.Flatten()).DistinctBy(s => s.ToString());
    }

    internal FamilyTreeNode VisitFamilyClacket()
    {
        var familyHead = new FamilyTreeNode(new FamilyMember("John", string.Empty, string.Empty));
        familyHead.AddChild("TallBoy", "Margaret");
        var arthur = familyHead.AddChild("Arthur", "Margaret");
        var vera = familyHead.AddChild("Vera", "Margaret");
        var majorie = familyHead.AddChild("Marjorie", "Margaret");

        //majorie
        var alice = majorie.AddChild("Alice", "Thomas McHoon");
        var desiree = majorie.AddChild("Desiree", "Thomas McHoon");
        majorie.AddChild("Thomas Jr", "Thomas McHoon");

        //vera
        var cyril = vera.AddChild("Cyril", "Jona");
        var jedamaih = vera.AddChild("Jedamaih", "Jona");
        vera.AddChild("Hope", "Jona");

        //arthur
        var clancy = arthur.AddChild("Clancy", "Jennifer");
        var peaches = arthur.AddChild("Peaches", "Jennifer");

        //alice
        alice.AddChild("Jedamaih Jr", "Jedamaih");
        alice.AddChild("Jona", "Cyril");

        //desiree 
        desiree.AddChild("Little Clanc", "Clancy");
        desiree.AddChild("Roberta", "Clancy");
        desiree.AddChild("Lyv", "Clancy");

        //cyril
        cyril.AddChild("Jona", "Alice");

        //jedamaih
        jedamaih.AddChild("Jedamaih Jr", "Alice");
        jedamaih.AddChild("Mary Sue", "Peaches");

        //clancy
        clancy.AddChild("Little Clanc", "Desiree");
        clancy.AddChild("Roberta", "Desiree");
        clancy.AddChild("Lyv", "Desiree");

        //peaches
        peaches.AddChild("Mary Sue", "Jedamaih");

        return familyHead;
    }

    internal FamilyTreeNode VisitFamilyHope()
    {
        var familyHead = new FamilyTreeNode(new FamilyMember("Tiny", string.Empty, string.Empty));
        var jona = familyHead.AddChild("Jona", "Jenny");
        var jennifer = familyHead.AddChild("Jennifer", "Jenny");

        //jennifer
        var clancy = jennifer.AddChild("Clancy", "Arthur");
        var peaches = jennifer.AddChild("Peaches", "Arthur");

        //jona
        var cyril = jona.AddChild("Cyril", "Vera");
        var jedamaih = jona.AddChild("Jedamaih", "Vera");
        jona.AddChild("Hope", "Vera");

        //jedemaih
        jedamaih.AddChild("Jedamaih Jr", "Alice");
        jedamaih.AddChild("Mary Sue", "Peaches");

        //cyril
        cyril.AddChild("Jona", "Alice");

        //clancy
        clancy.AddChild("Little Clanc", "Desiree");
        clancy.AddChild("Roberta", "Desiree");
        clancy.AddChild("Lyv", "Desiree");

        //peaches
        peaches.AddChild("Mary Sue", "Jedamaih");

        return familyHead;
    }
}