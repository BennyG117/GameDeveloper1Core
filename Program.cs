// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Attack Bolt = new Attack("Lightning Bolt", 15);
Attack Fatal = new Attack("Fatal Push", 10);
Attack GFTT = new Attack("Go for the throat", 25);
Attack Shock = new Attack("Shock", 5);

List<Attack> EnemyAttackList = new List<Attack>
{
    Bolt,
    Fatal,
    GFTT,
    Shock
};

Enemy Goblin = new Enemy("Goblin Engineer");
Enemy Elf = new Enemy("Llanowar Elf");

        // Elf.EnemyAttackList.Add(Bolt);
        Elf.AddToAttackList(Fatal);
        Elf.AddToAttackList(Bolt);
        Elf.AddToAttackList(GFTT);

        Goblin.AddToAttackList(Bolt);
        Goblin.AddToAttackList(Shock);


        Elf.RandomAttack();
        Elf.RandomAttack();
        Elf.RandomAttack();
        Elf.RandomAttack();

Console.WriteLine("===================");
Console.WriteLine($"{Elf._EnemyHealth}");
        
        
Console.WriteLine("===================");
        Goblin.RandomAttack();
        Goblin.RandomAttack();


