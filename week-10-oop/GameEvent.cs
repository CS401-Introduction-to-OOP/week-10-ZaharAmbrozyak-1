namespace week_10_oop;

public class GameEvent
{
    public int TurnNumber
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Turn number should be positive!");
            }

            field = value;
        }
    }
    
    public string Description
    {
        get;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Description cannot be empty!");
            }

            field = value;
        }
    }

    public int StatChange
    {
        get;
        set;
    }

    public EventType EventType;

    public string GetEventType()
    {
        switch (EventType)
        {
            case EventType.HpLose:
                return "Hp lose";
            case EventType.LvlUp:
                return "Lvl up";
            case EventType.HpRestoration:
                return "Hp restoration";
            default:
                throw new ArgumentException("Unknown event type");
        }
    }
    public override string ToString()
    {
        return $"{TurnNumber} - {Description}. {StatChange}";
    }

    public GameEvent(int turnNumber, string description, EventType eventType, int statChange)
    {
        TurnNumber = turnNumber;
        Description = description;
        EventType = eventType;
        StatChange = statChange;
    }
}