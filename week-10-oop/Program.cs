namespace week_10_oop;

class Program
{
    static void Main()
    {
        var party = new Party();
        party.AddMember(new Hero("Funyusha", Role.Mage, 33, 323, 45));
        party.AddMember(new Hero("Fenix", Role.Archer, 123, 123, 12));
        party.AddMember(new Hero("Owosi", Role.Healer, 89, 632, 345));
        party.AddMember(new Hero("Dark", Role.Paladin, 66, 2534, 990));
        
        
    }
}