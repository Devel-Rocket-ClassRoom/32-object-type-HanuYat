class Item
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"Name = {Name}, Price: {Price}";
    }
}