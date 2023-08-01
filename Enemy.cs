public class Enemy
{
    //Fields --------------
    public string NameOfEnemy;
    private int EnemyHealth;
    public int _EnemyHealth
    {
        get
        {
            return EnemyHealth;
        }
    }
    
    public List<Attack> EnemyAttackList;




    //Constructors --------------
    public Enemy(string nameOfEnemy)
    {
        NameOfEnemy = nameOfEnemy;
        EnemyHealth = 100;
        EnemyAttackList = new List<Attack>();
    }


    //Method --------------
    public void RandomAttack()
    {
        Random random = new Random();
        int randomAttackIndex = random.Next(0, EnemyAttackList.Count);
        Attack randomAttack = EnemyAttackList[randomAttackIndex];

        Console.WriteLine($"{NameOfEnemy} attacked with {randomAttack.NameOfAttack} ");
    }

    public void AddToAttackList(Attack newAttack)
    {
        EnemyAttackList.Add(newAttack);
    }

}