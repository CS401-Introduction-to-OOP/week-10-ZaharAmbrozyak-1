using System.Collections;

namespace week_10_oop;

public class Party : IEnumerable<Hero>
{
    private List<Hero> _party;

    public Party()
    {
        _party = [];
    }
    
    public void AddMember(Hero hero)
    {
        _party.Add(hero);
    }


    public IEnumerator<Hero> GetEnumerator()
    {
        return _party.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}