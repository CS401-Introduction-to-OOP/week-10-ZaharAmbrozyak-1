namespace week_10_oop;

public class Menu
{
    private Party _party;
    private EventLog _eventLog;

    public Menu()
    {
        Console.WriteLine("BackStory: ");
        _party = new();
        var funyusha = new Hero("Funyusha", Role.Mage, 33, 323, 45);
        var fenix = new Hero("Fenix", Role.Archer, 123, 123, 12);
        var owosi = new Hero("Owosi", Role.Healer, 89, 632, 345);
        var dark = new Hero("Dark", Role.Paladin, 66, 2534, 990);
        _party.AddMember(funyusha);
        _party.AddMember(fenix);
        _party.AddMember(owosi);
        _party.AddMember(dark);

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
    }

    public void ShowAllPartyHeroes()
    {

        Console.WriteLine("All party heroes: ");
        foreach (var hero in _party)
        {
            Console.WriteLine(hero);
        }

        Console.Write("\n");
    }

    public void PrintHeroesByHp(int hp)
    {

        Console.WriteLine($"Heroes with max Hp > {hp}");
        var bulkHeroes = _party.Where(h => h.MaxHp > hp).OrderByDescending(c => c.MaxHp);
        foreach (var bulkHero in bulkHeroes)
        {
            Console.WriteLine(bulkHero);
        }

        Console.Write("\n");
    }

    public void PrintHeroesByLvl(int lvl)
    {
        Console.WriteLine($"Heroes with level > {lvl}");
        var powerfulHeroes = _party.Where(h => h.Level > 100).OrderByDescending(h => h.Level);
        foreach (var powerfulHero in powerfulHeroes)
        {
            Console.WriteLine(powerfulHero);
        }
    }

    public void PrintMaxMemberGold()
    {
        var maxGoldInParty = _party.Max(h => h.GoldAmount);
        Console.WriteLine("Максимальна кількість золота в команді: " + maxGoldInParty);
    }

    public void PrintPartyGoldInSum()
    {
        var goldSumInParty = _party.Sum(h => h.GoldAmount);
        Console.WriteLine("Сума золота в команді: " + goldSumInParty);
    }

    public void PrintAverageLvl()
    {
        var averageLevel = _party.Average(h => h.Level);
        Console.WriteLine("Середній рівень героїв в команді: " + averageLevel);
    }

    public void PrintDeadHeroesCount()
    {
    var DeadHeroesCount = _party.Count(h => h.Status is HeroStatus.Dead);
    Console.WriteLine("Кількість мертвих героїв в команді: " + DeadHeroesCount);
    }

    public void ShowLastEvents(int n=5)
    {
        foreach (var gameEvent in _eventLog.GetLastNEvents(n))
        {
            Console.WriteLine(gameEvent);
        }
    }
    public void Run()
    {
        Console.WriteLine("Commands:");
        Console.WriteLine("1 Show all heroes");
        Console.WriteLine("2 Show last events");
        Console.WriteLine("3 [Hp] Show heroes by hp");
        Console.WriteLine("4 [Lvl] Show heroes by lvl");
        Console.WriteLine("5 Show average heroes lvl");
        Console.WriteLine("6 Show dead heroes");
        while (true)
        {
            Console.Write("> ");
            var userChoice = Console.ReadLine();
            if (userChoice.StartsWith("1"))
            {
                ShowAllPartyHeroes();
            }
            else if (userChoice.StartsWith("2"))
            {
                ShowLastEvents(5);
            }
            else if (userChoice.StartsWith("3"))
            {
                var keys = userChoice.Split();
                PrintHeroesByHp(int.Parse(keys[1]));
            }
            else if (userChoice.StartsWith("4"))
            {
                var keys = userChoice.Split(" ");
                PrintHeroesByLvl(int.Parse(keys[1]));
            }
            else if (userChoice.StartsWith("5"))
            {
                PrintAverageLvl();
            }
            else if (userChoice.StartsWith("6"))
            {
                PrintDeadHeroesCount();
            }
        }
    }
}