namespace W9_assignment_template.Models;

public abstract class Character : ICharacter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }

    // Foreign key to Room
    public int RoomId { get; set; }

    // Navigation property to Room
    public virtual Room Room { get; set; }
    public virtual ICollection<Ability> Abilities { get; set; } = new List<Ability>();

    public virtual Ability? ChooseAbility()
    {
        return Abilities?.FirstOrDefault();
    }

    public virtual void ExecuteAbility(Ability ability)
    {
        if (ability != null)
        {
            Console.WriteLine($"{Name} uses {ability.Name}!");
        }
        else
        {
            Console.WriteLine($"{Name} has no abilities to use.");
        }
    }
    public virtual void Attack(ICharacter target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}!");

        var ability = ChooseAbility();
        if (ability != null)
        {
            ExecuteAbility(ability);
        }
    }
}