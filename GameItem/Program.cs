using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 인벤토리 시스템 테스트 ===");
Console.WriteLine();

Inventory inventory = new Inventory();
inventory.AddItem(new Weapon { Name = "불꽃 검", Price = 500, Damage = 25 });
inventory.AddItem(new Weapon { Name = "얼음 활", Price = 450, Damage = 20 });
inventory.AddItem(new Potion { Name = "체력 물약", Price = 50, HealAmount = 100 });
inventory.AddItem(new Potion { Name = "마나 물약", Price = 80, HealAmount = 50 });

inventory.ShowInventory();
Console.WriteLine();

Console.WriteLine("=== 타입 확인 테스트 ===");

Item sword = new Weapon();
sword.Name = "sword";

Console.WriteLine($"sword의 타입: {sword.GetType()}");
Console.WriteLine($"sword.GetType() == typeof(Weapon): {sword.GetType() == typeof(Weapon)}");
Console.WriteLine($"sword.GetType() == typeof(Item): {sword.GetType() == typeof(Item)}");
Console.WriteLine($"sword is Item: {sword is Item}");