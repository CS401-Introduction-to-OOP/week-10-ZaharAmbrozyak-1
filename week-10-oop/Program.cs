namespace week_10_oop;

class Program
{
    static void Main()
    {
        var party = new Party();
        var funyusha = new Hero("Funyusha", Role.Mage, 33, 323, 45);
        var fenix = new Hero("Fenix", Role.Archer, 123, 123, 12);
        var owosi = new Hero("Owosi", Role.Healer, 89, 632, 345);
        var dark = new Hero("Dark", Role.Paladin, 66, 2534, 990)
        party.AddMember(funyusha);
        party.AddMember(fenix);
        party.AddMember(owosi);
        party.AddMember(dark);

        var eventLog = new EventLog();
        eventLog.AddEvent(new GameEvent(1, "Party ambush! Fenix got killed!", EventType.HpLose, -123));
        fenix.Status = HeroStatus.Dead;
        
        eventLog.AddEvent(new GameEvent(2, "Dark got punched in the face!", EventType.HpLose, -50));
        dark.CurrentHp -= 50;
        
        eventLog.AddEvent(new GameEvent(3, "Dark killed first enemy", EventType.LvlUp, 1));
        dark.Level++;
        
        eventLog.AddEvent(new GameEvent(4, "Owosi healed dark", EventType.HpRestoration, 100));
        dark.CurrentHp += 100;
        
        eventLog.AddEvent(new GameEvent(5, "Party killed all enemies", EventType.LvlUp, 1));
        funyusha.Level++;
        dark.Level++;
        owosi.Level++;
        
        Console.WriteLine("All party heroes: ");
        foreach (var hero in party)
        {
            Console.WriteLine(hero);
        }
        Console.Write("\n");
        
        Console.WriteLine("Heroes with max Hp > 500");
        var bulkHeroes = party.Where(h => h.MaxHp > 500).OrderByDescending(c => c.MaxHp);
        foreach (var bulkHero in bulkHeroes)
        {
            Console.WriteLine(bulkHero);
        }
        Console.Write("\n");
        
        Console.WriteLine("Heroes with level > 100");
        var powerfulHeroes = party.Where(h => h.Level > 100).OrderByDescending(h => h.Level);
        foreach (var powerfulHero in powerfulHeroes)
        {
            Console.WriteLine(powerfulHero);
        }

        var maxGoldInParty = party.Max(h => h.GoldAmount);
        Console.WriteLine("Максимальна кількість золота в команді: " + maxGoldInParty);
        var goldSumInParty = party.Sum(h => h.GoldAmount);
        Console.WriteLine("Сума золота в команді: " + goldSumInParty);
        var averageLevel = party.Average(h => h.Level);
        Console.WriteLine("Середній рівень героїв в команді: " + averageLevel);
        var DeadHeroesCount = party.Count(h => h.Status is HeroStatus.Dead);
        Console.WriteLine("Кількість мертвих героїв в команді: " + DeadHeroesCount);

    }
}