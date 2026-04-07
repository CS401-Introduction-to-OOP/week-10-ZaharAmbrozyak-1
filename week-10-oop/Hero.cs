namespace week_10_oop;

public class Hero
{
    public string Name
    {
        get;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            field = value;
        }
    }

    public Role role;

    public int Level
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Level should be positive!");
            }

            field = value;
        }
    }

    public int CurrentHp
    {
        get;
        set
        {
            if (value > MaxHp)
            {
                field = MaxHp;
            }
            else if (value < 0)
            {
                field = 0;
            }
            else
            {
                field = value; 
            }
            
        }
    }
    public int MaxHp
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Max Hp should be positive!");
            }

            if (CurrentHp > value)
            {
                CurrentHp = value;
            }
            field = value;
            
        }
    }
    public string GetRole()
    {
        switch (role)
        {
            case Role.Archer:
                return "Archer";
            case Role.Healer:
                return "Healer";
            case Role.Mage:
                return "Mage";
            case Role.Paladin:
                return "Paladin";
            default:
                throw new ArgumentException("Unknown role");
        }
    }

    public int GoldAmount
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Gold amount should be positive!");
            }

            field = value;
        }
    }

    public Status status;

    public string GetStatus()
    {
        switch (status)
        {
            case Status.Alive:
                return "Alive";
            case Status.Dead:
                return "Dead";
            case Status.Enraged:
                return "Enraged";
            case Status.Stunned:
                return "Stunned";
        }
    }
}