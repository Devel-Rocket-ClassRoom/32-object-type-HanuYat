using System;

class Weapon : Item
{
    public int Damage;

    public override string ToString()
    {
        return $"Name = {Name}, Price: {Price}, Damage: {Damage}";
    }
}