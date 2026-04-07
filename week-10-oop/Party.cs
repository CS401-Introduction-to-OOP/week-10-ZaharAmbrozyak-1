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
        foreach (var hero in _party)
        {
            yield return hero;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerable<Hero> GetAliveHeroes()
    {
        foreach (var hero in _party)
        {
            if (hero.Status is HeroStatus.Alive)
            {
                yield return hero;
            }
        }
    }

    IEnumerable<Hero> GetDeadHeroes()
    {
        foreach (var hero in _party)
        {
            if (hero.Status is HeroStatus.Dead)
            {
                yield return hero;
            }
        }
    }

    IEnumerable<Hero> GetFullHpHeroes()
    {
        foreach (var hero in _party)
        {
            if (hero.CurrentHp == hero.MaxHp)
            {
                yield return hero;
            }
        }
    }
}