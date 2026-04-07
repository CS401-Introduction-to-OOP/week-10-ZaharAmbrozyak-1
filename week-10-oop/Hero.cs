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

    public HeroStatus HeroStatus;

    public string GetStatus()
    {
        switch (HeroStatus)
        {
            case HeroStatus.Alive:
                return "Alive";
            case HeroStatus.Dead:
                return "Dead";
            case HeroStatus.Enraged:
                return "Enraged";
            case HeroStatus.Stunned:
                return "Stunned";
            default:
                throw new ArgumentException("Unknown hero status");
        }
    }

    public override string ToString()
    {
        return $"{Name} - {GetRole()} lvl {Level}, {CurrentHp}/{MaxHp}. {GetStatus()}";
    }
}