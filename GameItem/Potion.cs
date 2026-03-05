using System;

class Potion : Item
{
    public int HealAmount;

    public override string ToString()
    {
        return $"Name = {Name}, Price = {Price}, HealAmount = {HealAmount}";
    }
}