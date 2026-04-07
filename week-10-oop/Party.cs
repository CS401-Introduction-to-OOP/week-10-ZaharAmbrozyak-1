namespace week_10_oop;

public class Party
{
    private List<Hero> party = [];

    public void AddMember(Hero hero)
    {
        party.Add(hero);
    }
}