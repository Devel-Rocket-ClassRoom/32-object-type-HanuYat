using System;

class Inventory
{
    private object[] _items = new Item[10];
    private static int _count = 0;

    public void AddItem(object item)
    {
        if (_count < _items.Length)
        {
            _items[_count] = item;
            _count++;
        }

        else
        {
            Console.WriteLine("인벤토리가 꽉 찼습니다!");
        }
    }

    public void ShowInventory()
    {
        Console.WriteLine("[인벤토리 내용]");
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine($"슬롯 {i + 1}: {_items[i].GetType()} {{ {_items[i]} }} [{_items[i].GetType()}]");
        }
    }
}